Imports ClasesFacultad.Util
public class Modalidad

   #Region "Atributos"
   private CodModalidad as Integer
    Private Descripcion As String
   #End Region

   #Region "Propiedades"
   public property pCodModalidad() as Integer
       get
           return CodModalidad
       end get

       set(byval value as Integer)
           CodModalidad = value
       end set
   end property

    Public Property pDescripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

#End Region

#Region "Metodos"




#End Region
End class
