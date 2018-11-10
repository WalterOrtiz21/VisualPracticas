
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
        <select name="cboFacultades" id="facultades">
            @For Each row In ViewData("Facultades")

                @<option value="@row("CodFacultad")"> @row("Descripcion") </option>

            Next

        </select>

    </div>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            alert("prueba");
        });
        function cargarCursos(cod_facu) {
           

            var parametro = {
                CodFacultad: cod_facu
            };
          

            
            $.ajax({
                type: "POST",
                url: '../../Facultad/getCursosPorFacultad',
                data: parametro,
                dataType: "json",
                success: function (msg) {
                    var datos = jQuery.parseJSON(msg);
                    var row = "";
                    //for (i = 0; i < datos.length; i++) {

                    //    row += "<tr><td>" + datos[i].campo1 + "</td><td>" + datos[i].campo2 + "</td><td>" + datos[i].campo3 + "</td><td>" + datos[i].campo4 + "</td><td>" + datos[i].campo5 + "</td></tr>";
                    //}
                    //$("#planilla").html(row);
                },
                error: function () {
                    alert("se ha producido un error cargar planilla.");
                }
            });
            
        }
    </script>

</body>
</html>
