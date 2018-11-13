Imports System.Web.Mvc
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization
Imports ClasesFacultad
Namespace Controllers
    Public Class CursoController
        Inherits Controller

        ' GET: Curso
        Function Index() As ActionResult
            Return View()
        End Function


        Function CursosPorFacultad(id As Integer) As JsonResult
            Dim dt As New DataTable
            dt = Curso.RecuperarCursosFacultad(id)
            Return Json(Newtonsoft.Json.JsonConvert.SerializeObject(dt))

        End Function

        Function AlumnosPorCurso(id) As ActionResult
            Try
                ViewData("alumnos_curso") = Alumno.RecuperarAlumnosCurso(id).AsEnumerable
            Catch ex As Exception


            End Try
            Return View()
        End Function

    End Class
End Namespace