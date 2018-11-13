@ModelType ClasesFacultad.Alumno
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Datos del Alumno</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

</head>
<body>
    <div class="Container form-horizontal">
        <div class="row">
            <div class="col-lg=8">
                   <h3>Datos del Alumno</h3>
            </div>
        </div>
    </div>

    <div class="well">
        <div class="form-group">
               <label for="NombreApellido" class="col-lg=2">NOmbre</label>
            <div>
                <label class="form-control">@Model.pNombreApellido</label>
            </div>
        </div>
        <div class="form-group">
            <label for="Direccion" class="col-lg=2">Direccion</label>
            <div>
                <label class="form-control">@Model.pDireccion</label>
            </div>
        </div>
        <div class="form-group">
            <label for="Telefono" class="col-lg=2">Telefono</label>
            <div>
                <label class="form-control">@Model.pTelefono</label>
            </div>
        </div>
        <div class="form-group">
            <label for="Email" class="col-lg=2">Mail</label>
            <div>
                <label class="form-control">@Model.pEmail</label>
            </div>
        </div>
        <div class="form-group">
            <label for="FechaNacimiento" class="col-lg=2">Nacimiento</label>
            <div>
                <label class="form-control">@Model.pFechaNacimiento</label>
            </div>
        </div>
        
        

    </div>

    <script src="~/scripts/jquery-3.3.1.min.js"></script>

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

</body>
</html>
