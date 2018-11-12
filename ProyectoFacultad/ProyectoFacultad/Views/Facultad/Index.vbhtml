
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
        <h1>Facultades</h1>
        <select name="cboFacultades" id="cboFacultades" onchange="CargarCursos()">
            @For Each row In ViewData("Facultades")
                @<option value="@row("CodFacultad")">@row("Descripcion")</option>
            Next
        </select>

        <table class="table">
            <thead>
                <tr>
                    <th>Seleccionar</th>
                    <th>Cód. Curso</th>
                    <th>Descripción</th>
                    <th>Cod. Modalidad</th>
                    <th>Cod. Facultad</th>
                    <th>Fecha Inicio</th>
                    <th>Fecha Fin</th>
                </tr>
            </thead>
            <tbody id="planilla">

            </tbody>
        </table>

    
    </div>
   


    <script src="~/scripts/jquery-3.3.1.min.js"></script>

    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <script type="text/javascript">
        function CargarCursos() {
        
       var parametro = {
           codFacultad: $("#cboFacultades").val()
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
                    row += "<tr><td>Seleccionar</td><td>" + datos[i].CodCurso + "</td><td>" + datos[i].Descripcion + "</td><td>" + datos[i].CodModalidad + "</td><td>" + datos[i].CodFacultad + "</td><td>" + datos[i].FechaInicio + "</td><td>" + datos[i].FechaFin + "</td></tr>";
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
