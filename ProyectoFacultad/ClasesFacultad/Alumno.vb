Imports ClasesFacultad.Util
public class Alumno

   #Region "Atributos"
   private CodAlumno as Integer
   private NombreApellido as String
   private Direccion as String
    Private Telefono As String
   private Email as String
   private FechaNacimiento as Date
   #End Region

   #Region "Propiedades"
   public property pCodAlumno() as Integer
       get
           return CodAlumno
       end get

       set(byval value as Integer)
           CodAlumno = value
       end set
   end property

   public property pNombreApellido() as String
       get
           return NombreApellido
       end get

       set(byval value as String)
           NombreApellido = value
       end set
   end property

   public property pDireccion() as String
       get
           return Direccion
       end get

       set(byval value as String)
           Direccion = value
       end set
   end property

    Public Property pTelefono() As String
        Get
            Return Telefono
        End Get

        Set(ByVal value As String)
            Telefono = value
        End Set
    End Property

   public property pEmail() as String
       get
           return Email
       end get

       set(byval value as String)
           Email = value
       end set
   end property

   public property pFechaNacimiento() as Date
       get
           return FechaNacimiento
       end get

       set(byval value as Date)
           FechaNacimiento = value
       end set
   end property

#End Region

#Region "Metodos"

    '    Codifique un método que retorne los alumnos de un curso, utilizando el SP
    'codificado en el punto 1c. 
    Public Shared Function RecuperarAlumnosCurso(CodCurso As Integer) As DataTable
        Return gDatos.TraerDataTable("spConsultarAlumnosPorCurso", CodCurso)
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
                .pFechaNacimiento = dtDatos.Rows(0).Item("FechaNacimiento")
                .pNombreApellido = dtDatos.Rows(0).Item("NombreApellido")
            End With
            Return vAlumno
        Else
            Return Nothing
        End If
    End Function

#End Region
End class
