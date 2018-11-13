
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title> Lista AlumnosPorCurso</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">

</head>
<body>
    <div> 
        <div class="container">
            <div class="row">
                <h1>Facultades</h1>
                <table class="table">
                    <thead>
                        <tr>
                            <td></td>
                            <th>Cod.Alumno</th>
                            <th>NombreApellido</th>
                        </tr>
                    </thead>
                    <tbody>
                        @For Each item In ViewData("alumnos_curso")
                            @<tr>
                                <td><a href="../../Alumno/DatosAlumno/@item("CodAlumno")" class="btn btn-info">Seleccionar</a></td>
                                <td>@item("CodAlumno")</td>
                                <td>@item("NombreApellido")</td>
                            </tr>
                        Next


                    </tbody>
                </table>

            </div>
        </div>
        </div>

    

    <script src = "~/scripts/jquery-3.3.1.min.js" ></script>

    <script src = "https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

</body>
</html>
