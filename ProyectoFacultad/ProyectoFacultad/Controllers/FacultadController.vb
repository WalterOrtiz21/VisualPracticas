Imports System.Web.Mvc
Imports ClasesFacultad
Namespace Controllers
    Public Class FacultadController
        Inherits Controller

        ' GET: Facultad
        Function Index() As ActionResult
            ViewData("Facultades") = Facultad.recuperarFacultades().AsEnumerable
            Return View()
        End Function
    End Class
End Namespace