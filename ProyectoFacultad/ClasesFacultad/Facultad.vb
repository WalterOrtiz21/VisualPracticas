Imports ClasesFacultad.Util
public class Facultad

   #Region "Atributos"
   private CodFacultad as Integer
   private Descripcion as String
   private FechaFundacion as Date
   #End Region

   #Region "Propiedades"
   public property pCodFacultad() as Integer
       get
           return CodFacultad
       end get

       set(byval value as Integer)
           CodFacultad = value
       end set
   end property

   public property pDescripcion() as String
       get
           return Descripcion
       end get

       set(byval value as String)
           Descripcion = value
       end set
   end property

   public property pFechaFundacion() as Date
       get
           return FechaFundacion
       end get

       set(byval value as Date)
           FechaFundacion = value
       end set
   end property

#End Region

#Region "Metodos"
    '    Codifique un método que retorne todas las facultades existentes, usando el SP
    'codificado en el punto 1a. 
    Public Shared Function recuperarFacultades() As DataTable
        Return gDatos.TraerDataTable("spConsultarFacultades")
    End Function

    '    Codifique un método que retorne cursos por facultad, utilizando el SP codificado
    'en el punto 1b. 


    Public Shared Function RecuperarCursosFacultad(CodFacultad As Integer) As DataTable
        Return gDatos.TraerDataTable("spConsultaCursosPorFacultad", CodFacultad)
    End Function


    '    Codifique un método que retorne los alumnos de un curso, utilizando el SP
    'codificado en el punto 1c. 


    Public Shared Function RecuperarAlumnosCursos(CodFacultad As Integer) As DataTable
        Return gDatos.TraerDataTable("spConsultarAlumnosPorCurso", CodFacultad)
    End Function

    '    Codifique un método que retorne un alumno a partir de su código, utilizando el
    'SP codificado en el punto 1D. Retorna un objeto de tipo Alumno. 

    Public Function RecuperarAlumnoPorCodigo(CodAlumno As Integer) As Alumno
        Dim dtDatos As New DataTable
        dtDatos = gDatos.TraerDataTable("spConsultarAlumnoPorCodigo", CodAlumno)
        If dtDatos.Rows.Count > 0 Then
            Dim vAlumno As New Alumno
            With vAlumno
                .pCodAlumno = dtDatos.Rows(0).Item("CodAlumno")
                .pTelefono = dtDatos.Rows(0).Item("Telefono")
                .pDireccion = dtDatos.Rows(0).Item("Direccion")
                .pEmail = dtDatos.Rows(0).Item("Email")
                .pFechaNacimiento = dtDatos.Rows(0).Item("fechaNacimiento")
                .pNombreApellido = dtDatos.Rows(0).Item("NombreApellido")


            End With
            Return vAlumno
        Else
            Return Nothing

        End If
    End Function




#End Region
End class
