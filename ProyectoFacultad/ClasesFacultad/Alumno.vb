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




#End Region
End class
