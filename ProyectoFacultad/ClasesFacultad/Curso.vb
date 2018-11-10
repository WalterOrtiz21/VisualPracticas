Imports ClasesFacultad.Util
public class Curso

   #Region "Atributos"
   private CodCurso as Integer
   private Descripcion as String
   private CodModalidad as Integer
   private CodFacultad as Integer
   private FechaInicio as Date
   private FechaFin as Date
   #End Region

   #Region "Propiedades"
   public property pCodCurso() as Integer
       get
           return CodCurso
       end get

       set(byval value as Integer)
           CodCurso = value
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

   public property pCodModalidad() as Integer
       get
           return CodModalidad
       end get

       set(byval value as Integer)
           CodModalidad = value
       end set
   end property

   public property pCodFacultad() as Integer
       get
           return CodFacultad
       end get

       set(byval value as Integer)
           CodFacultad = value
       end set
   end property

   public property pFechaInicio() as Date
       get
           return FechaInicio
       end get

       set(byval value as Date)
           FechaInicio = value
       end set
   end property

   public property pFechaFin() as Date
       get
           return FechaFin
       end get

       set(byval value as Date)
           FechaFin = value
       end set
   end property

#End Region

#Region "Metodos"



#End Region
End class
