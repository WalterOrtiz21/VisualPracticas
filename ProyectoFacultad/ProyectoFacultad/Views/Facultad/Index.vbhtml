
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Facultades</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    
</head>

<body>

    
    <div class="container">
        <h1>FACULTADES</h1>
        <select name="cboFacultad" id="facultad" onchange="CargarCursos">
            @For Each row In ViewData("Facultad")

                @<option value="@row("CodFacultad")"> @row("Descripcion") </option>

            Next

        </select>

        <table class="table">
            <thead>
                <tr>
                    <th>Selecccionar</th>
                    <th>Cod.Curos</th>
                    <th>Descripcion</th>
                    <th>Cod.Modalidad</th>
                    <th>Cod.Facultad</th>
                    <th>Fecha Incio</th>
                    <th>Fecha Fin</th>
                </tr>
            </thead>
        </table>


    </div>
    <script src="~/fonts/jquery-3.3.1.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <script type="text/javascript">
        
        function CargarCursos() {
            
                alert("prueba");
           

            var parametro = {
                CodFacultad: $("#cboFacultad").val()
            };
            $.ajax({
                type: "POST",
                url: '/Facultad/getCursosPorFacultad',
                data: parametro,
                dataType: "json",
                success: function (msg) {
                    var datos = jQuery.parseJSON(msg);
                    var row = "";
                    for (i = 0; i < datos.length; i++) {

                        row += "<tr><td>Selecccionar</td><td>" + datos[i].CodCurso + "</td><td>" + datos[i].Descripcion + "</td><td>" + datos[i].CodModalidad + "</td><td>" + datos[i].CodFacultad + "</td></tr>"
                            + datos[i].FechaInicio + "</td></tr>" + datos[i].FechaFin + "</td></tr>";
                    }
                    $("#planilla").html(row);
                },
                error: function () {
                    alert("se ha producido un error cargar planilla.");
                }
            });
            
        }
    </script>

</body>
</html>
