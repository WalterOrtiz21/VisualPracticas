Imports System.Web.Mvc
Imports ClasesFacultad
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Namespace Controllers
    Public Class FacultadController
        Inherits Controller

        ' GET: Facultad
        Function Index() As ActionResult
            ViewData("Facultades") = Facultad.recuperarFacultades().AsEnumerable
            Return View()
        End Function

        Function getCursosPorFacultad(codfacultad As Integer) As JsonResult
            Dim dt As New DataTable
            dt = Facultad.RecuperarCursosFacultad(codfacultad)
            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(dt))
        End Function

    End Class
End Namespace