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
    'a. Codifique un método que retorne todas las facultades existentes, usando el SP
    'codificado en el punto 1a. 
    Public Shared Function RecuperarFacultades() As DataTable
        Return gDatos.TraerDataTable("spConsultarFacultades")
    End Function


#End Region
End class
