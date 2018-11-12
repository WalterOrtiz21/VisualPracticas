Imports System.Web.Mvc
Imports ClasesFacultad
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Namespace Controllers
    Public Class FacultadController
        Inherits Controller

        ' GET: Facultad
        Function Index() As ActionResult
            ViewData("Facultades") = Facultad.RecuperarFacultades().AsEnumerable
            Return View()
        End Function
        Function getCursosPorFacultad(codFacultad As Integer) As JsonResult
            Dim dt As New DataTable
            dt = Curso.RecuperarCursosFacultad(codFacultad)
            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(dt))
        End Function
    End Class
End Namespace