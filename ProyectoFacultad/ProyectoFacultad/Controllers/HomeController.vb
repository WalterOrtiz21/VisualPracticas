Imports System.Web.Mvc
Imports ClasesFacultad
Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Util.inicializaSesion("USER\SQLEXPRESS", "Facu", "sa", "factranus98")
            Return View()
        End Function
    End Class
End Namespace