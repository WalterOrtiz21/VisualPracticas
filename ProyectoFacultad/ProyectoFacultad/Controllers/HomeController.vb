Imports System.Web.Mvc
Imports ClasesFacultad

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Util.inicializaSesion("M203-19", "Facu", "sa", "@lumno123")

            Return View()
        End Function
    End Class
End Namespace