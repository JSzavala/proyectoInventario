using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoInventario.backEnd.conexionBd;
using proyectoInventario.backEnd.POCOS;
using MySql.Data.MySqlClient;

namespace proyectoInventario.backEnd.Servicios
{
    internal class srvRegistrarMovimientoInventario
    {
        private clsConexionBd conexionBd;
        private clsConsultas consultas;

        /// <summary>
        /// Constructor que inicializa la conexión a la base de datos
        /// </summary>
        public srvRegistrarMovimientoInventario()
        {
            conexionBd = new clsConexionBd();
            consultas = new clsConsultas();
        }

        /// <summary>
        /// Registra una factura de entrada de inventario con sus detalles usando transacciones
        /// </summary>
        /// <param name="factura">Objeto Factura con los datos principales</param>
        /// <param name="detalles">Lista de DetalleFactura con los productos</param>
        /// <returns>ID de la factura generada, o -1 si hubo error</returns>
        public long RegistrarEntradaInventario(Factura factura, List<DetalleFactura> detalles)
        {
            MySqlTransaction transaction = null;
            long idFacturaGenerada = -1;

            try
            {
                // Validar que haya detalles
                if (detalles == null || detalles.Count == 0)
                {
                    throw new Exception("Debe agregar al menos un producto a la factura");
                }

                // Abrir conexión
                if (!conexionBd.AbrirConexion())
                {
                    throw new Exception("No se pudo abrir la conexión a la base de datos");
                }

                // Iniciar transacción
                transaction = conexionBd.ObtenerConexion().BeginTransaction();

                // 1. Insertar la factura
                idFacturaGenerada = InsertarFactura(factura, transaction);

                if (idFacturaGenerada <= 0)
                {
                    throw new Exception("Error al insertar la factura");
                }

                // 2. Insertar los detalles de la factura
                foreach (var detalle in detalles)
                {
                    detalle.IdFactura = (int)idFacturaGenerada;
                    long idDetalle = InsertarDetalleFactura(detalle, transaction);

                    if (idDetalle <= 0)
                    {
                        throw new Exception($"Error al insertar el detalle del producto ID: {detalle.IdProducto}");
                    }

                    // 3. Actualizar el stock del producto
                    bool stockActualizado = ActualizarStockProducto(detalle.IdProducto, detalle.Cantidad, transaction);

                    if (!stockActualizado)
                    {
                        throw new Exception($"Error al actualizar stock del producto ID: {detalle.IdProducto}");
                    }
                }

                // Confirmar transacción
                transaction.Commit();

                return idFacturaGenerada;
            }
            catch (MySqlException ex)
            {
                // Revertir transacción en caso de error
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        Console.WriteLine("Error al hacer rollback: " + rollbackEx.Message);
                    }
                }

                Console.WriteLine("Error en RegistrarEntradaInventario: " + ex.Message);
                throw new Exception("Error al registrar la entrada de inventario: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Revertir transacción en caso de error
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        Console.WriteLine("Error al hacer rollback: " + rollbackEx.Message);
                    }
                }

                Console.WriteLine("Error en RegistrarEntradaInventario: " + ex.Message);
                throw;
            }
            finally
            {
                // Cerrar conexión
                conexionBd.CerrarConexion();
            }
        }

        /// <summary>
        /// Inserta una factura en la base de datos usando clsConsultas
        /// </summary>
        /// <param name="factura">Objeto Factura a insertar</param>
        /// <param name="transaction">Transacción activa</param>
        /// <returns>ID de la factura generada</returns>
        private long InsertarFactura(Factura factura, MySqlTransaction transaction)
        {
            string consulta = @"INSERT INTO factura (fecha, total, tipoFactura) 
            VALUES (@fecha, @total, @tipoFactura)";
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@fecha", factura.Fecha },
                { "@total", factura.Total },
                { "@tipoFactura", (int)factura.TipoFactura }
            };
            return consultas.Insert(consulta, parametros, transaction);
        }

        /// <summary>
        /// Inserta un detalle de factura en la base de datos usando clsConsultas
        /// </summary>
        /// <param name="detalle">Objeto DetalleFactura a insertar</param>
        /// <param name="transaction">Transacción activa</param>
        /// <returns>ID del detalle generado</returns>
        private long InsertarDetalleFactura(DetalleFactura detalle, MySqlTransaction transaction)
        {
            string consulta = @"INSERT INTO detalleFactura (cantidad, precioUnitario, idFactura, idProducto) 
            VALUES (@cantidad, @precioUnitario, @idFactura, @idProducto)";

            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@cantidad", detalle.Cantidad },
                { "@precioUnitario", detalle.PrecioUnitario },
                { "@idFactura", detalle.IdFactura },
                { "@idProducto", detalle.IdProducto }
            };

            return consultas.Insert(consulta, parametros, transaction);
        }

        /// <summary>
        /// Actualiza el stock de un producto sumando la cantidad recibida
        /// </summary>
        /// <param name="idProducto">ID del producto</param>
        /// <param name="cantidad">Cantidad a sumar al stock</param>
        /// <param name="transaction">Transacción activa</param>
        /// <returns>True si se actualizó correctamente</returns>
        private bool ActualizarStockProducto(int idProducto, short cantidad, MySqlTransaction transaction)
        {
            string consulta = @"UPDATE producto 
            SET stockActual = stockActual + @cantidad 
            WHERE idProducto = @idProducto";

            using (MySqlCommand comando = new MySqlCommand(consulta, conexionBd.ObtenerConexion(), transaction))
            {
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        /// <summary>
        /// Calcula el total de la factura basándose en los detalles
        /// </summary>
        /// <param name="detalles">Lista de detalles de factura</param>
        /// <returns>Total calculado</returns>
        public decimal CalcularTotalFactura(List<DetalleFactura> detalles)
        {
            decimal total = 0;

            if (detalles != null)
            {
                foreach (var detalle in detalles)
                {
                    total += detalle.Subtotal;
                }
            }
            return total;
        }

        /// <summary>
        /// Valida los datos de una entrada de inventario antes de registrarla
        /// </summary>
        /// <param name="factura">Factura a validar</param>
        /// <param name="detalles">Detalles a validar</param>
        /// <returns>Mensaje de error o cadena vacía si todo está correcto</returns>
        public string ValidarEntradaInventario(Factura factura, List<DetalleFactura> detalles)
        {
            if (factura == null)
            {
                return "La factura no puede ser nula";
            }

            if (factura.Fecha > DateTime.Now)
            {
                return "La fecha de la factura no puede ser futura";
            }

            if (detalles == null || detalles.Count == 0)
            {
                return "Debe agregar al menos un producto a la factura";
            }

            foreach (var detalle in detalles)
            {
                if (detalle.Cantidad <= 0)
                {
                    return "La cantidad de los productos debe ser mayor a cero";
                }

                if (detalle.PrecioUnitario <= 0)
                {
                    return "El precio unitario debe ser mayor a cero";
                }

                if (detalle.IdProducto <= 0)
                {
                    return "Debe seleccionar un producto válido";
                }
            }

            return string.Empty;
        }
    }
}
