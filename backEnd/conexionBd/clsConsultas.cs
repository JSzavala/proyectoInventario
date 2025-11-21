using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace proyectoInventario.backEnd.conexionBd
{
    internal class clsConsultas
    {
        private clsConexionBd conexionBd;

        /// <summary>
        /// Constructor que inicializa la conexión a la base de datos
        /// </summary>
     public clsConsultas()
        {
 conexionBd = new clsConexionBd();
        }

   /// <summary>
 /// Método genérico para SELECT - Consulta datos de la base de datos
        /// </summary>
        /// <param name="consulta">Consulta SQL SELECT con parámetros (@parametro)</param>
      /// <param name="parametros">Diccionario con los parámetros y sus valores</param>
        /// <returns>DataTable con los resultados de la consulta</returns>
        public DataTable Select(string consulta, Dictionary<string, object> parametros = null)
     {
         DataTable tabla = new DataTable();

 try
  {
     if (conexionBd.AbrirConexion())
   {
    using (MySqlCommand comando = new MySqlCommand(consulta, conexionBd.ObtenerConexion()))
       {
    // Agregar parámetros de forma segura
             if (parametros != null)
  {
foreach (var parametro in parametros)
   {
  comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
      }
              }

          using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
    {
       adaptador.Fill(tabla);
         }
  }

      conexionBd.CerrarConexion();
      }
  }
            catch (MySqlException ex)
        {
     Console.WriteLine("Error en SELECT: " + ex.Message);
      throw new Exception("Error al ejecutar consulta SELECT: " + ex.Message, ex);
            }

        return tabla;
        }

        /// <summary>
        /// Método genérico para INSERT - Inserta datos en la base de datos
/// </summary>
        /// <param name="consulta">Consulta SQL INSERT con parámetros (@parametro)</param>
  /// <param name="parametros">Diccionario con los parámetros y sus valores</param>
  /// <returns>ID del último registro insertado (si aplica)</returns>
        public long Insert(string consulta, Dictionary<string, object> parametros)
  {
       long idGenerado = 0;

         try
         {
     if (conexionBd.AbrirConexion())
         {
        using (MySqlCommand comando = new MySqlCommand(consulta, conexionBd.ObtenerConexion()))
   {
         // Agregar parámetros de forma segura
    if (parametros != null)
          {
  foreach (var parametro in parametros)
    {
    comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
       }
     }

    comando.ExecuteNonQuery();
   idGenerado = comando.LastInsertedId;
               }

            conexionBd.CerrarConexion();
            }
     }
            catch (MySqlException ex)
            {
    Console.WriteLine("Error en INSERT: " + ex.Message);
            throw new Exception("Error al ejecutar INSERT: " + ex.Message, ex);
    }

      return idGenerado;
}

        /// <summary>
/// Método genérico para UPDATE - Actualiza datos en la base de datos
        /// </summary>
        /// <param name="consulta">Consulta SQL UPDATE con parámetros (@parametro)</param>
    /// <param name="parametros">Diccionario con los parámetros y sus valores</param>
        /// <returns>Número de filas afectadas</returns>
        public int Update(string consulta, Dictionary<string, object> parametros)
 {
      int filasAfectadas = 0;

    try
        {
    if (conexionBd.AbrirConexion())
      {
            using (MySqlCommand comando = new MySqlCommand(consulta, conexionBd.ObtenerConexion()))
             {
     // Agregar parámetros de forma segura
 if (parametros != null)
        {
            foreach (var parametro in parametros)
         {
   comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
     }
         }

     filasAfectadas = comando.ExecuteNonQuery();
            }

           conexionBd.CerrarConexion();
        }
    }
            catch (MySqlException ex)
            {
       Console.WriteLine("Error en UPDATE: " + ex.Message);
      throw new Exception("Error al ejecutar UPDATE: " + ex.Message, ex);
          }

     return filasAfectadas;
  }

     /// <summary>
        /// Método genérico para DELETE - Elimina datos de la base de datos
        /// </summary>
        /// <param name="consulta">Consulta SQL DELETE con parámetros (@parametro)</param>
   /// <param name="parametros">Diccionario con los parámetros y sus valores</param>
        /// <returns>Número de filas eliminadas</returns>
        public int Delete(string consulta, Dictionary<string, object> parametros)
  {
    int filasEliminadas = 0;

         try
      {
    if (conexionBd.AbrirConexion())
     {
      using (MySqlCommand comando = new MySqlCommand(consulta, conexionBd.ObtenerConexion()))
         {
 // Agregar parámetros de forma segura
    if (parametros != null)
     {
   foreach (var parametro in parametros)
     {
        comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
              }
  }

    filasEliminadas = comando.ExecuteNonQuery();
       }

       conexionBd.CerrarConexion();
         }
   }
        catch (MySqlException ex)
            {
       Console.WriteLine("Error en DELETE: " + ex.Message);
            throw new Exception("Error al ejecutar DELETE: " + ex.Message, ex);
      }

            return filasEliminadas;
        }
    }
}
