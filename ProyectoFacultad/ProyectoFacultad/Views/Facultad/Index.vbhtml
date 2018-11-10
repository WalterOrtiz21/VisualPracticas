
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Facultades</title>
</head>
<body>
    <h1>FACULTADES</h1>
    <select name="cboFacultades" id="facultades">
        @For Each row In ViewData("Facultades")

        @<option value ="@row("CodFacultad")"> @row("Descripcion") </option>
            
        Next
    </select>
</body>
</html>
