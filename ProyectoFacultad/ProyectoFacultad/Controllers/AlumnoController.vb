Imports System.Web.Mvc
Imports ClasesFacultad
Namespace Controllers
    Public Class AlumnoController
        Inherits Controller

        ' GET: Alumno
        Function Index() As ActionResult
            Return View()
        End Function

        Function DatosAlumno(id As Integer) As ActionResult
            Dim vAlumno As New Alumno
            vAlumno = vAlumno.RecuperarAlumnoPorCodigo(id)
            Return View(vAlumno)
        End Function
    End Class


End Namespace