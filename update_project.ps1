# Script para actualizar el archivo de proyecto
$projectFile = "proyectoInventario.csproj"
$content = Get-Content $projectFile -Raw

# Encontrar la línea donde está Form1.Designer.cs
$pattern = '(<Compile Include="frontEnd\\Ventanas2\\Form1.Designer.cs">[\s\S]*?</Compile>)'
$replacement = @'
<Compile Include="frontEnd\Ventanas2\Form1.Designer.cs">
      <DependentUpon>Form1.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Buscar.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Buscar.Designer.cs">
  <DependentUpon>Buscar.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Descontinuar.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Descontinuar.Designer.cs">
      <DependentUpon>Descontinuar.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Login.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Login.Designer.cs">
      <DependentUpon>Login.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\Main.cs">
      <SubType>Form</SubType>
    </Compile>
<Compile Include="frontEnd\Ventanas2\Main.Designer.cs">
      <DependentUpon>Main.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\RegistrarCompra.cs">
  <SubType>Form</SubType>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\RegistrarCompra.Designer.cs">
      <DependentUpon>RegistrarCompra.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\RegistrarProducto.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\RegistrarProducto.Designer.cs">
      <DependentUpon>RegistrarProducto.cs</DependentUpon>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\RegistrarUsuarios.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="frontEnd\Ventanas2\RegistrarUsuarios.Designer.cs">
  <DependentUpon>RegistrarUsuarios.cs</DependentUpon>
    </Compile>
'@

$newContent = $content -replace $pattern, $replacement
Set-Content -Path $projectFile -Value $newContent -Encoding UTF8
Write-Host "Proyecto actualizado exitosamente"
