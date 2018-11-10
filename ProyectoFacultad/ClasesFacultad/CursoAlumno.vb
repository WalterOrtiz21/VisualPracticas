Imports ClasesFacultad.Util
public class CursoAlumno

   #Region "Atributos"
   private CodCurso as Integer
   private CodAlumno as Integer
   private FechaMatriculacion as Date
   private NotaFinal as Integer
   private Observaciones as String
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

   public property pCodAlumno() as Integer
       get
           return CodAlumno
       end get

       set(byval value as Integer)
           CodAlumno = value
       end set
   end property

   public property pFechaMatriculacion() as Date
       get
           return FechaMatriculacion
       end get

       set(byval value as Date)
           FechaMatriculacion = value
       end set
   end property

   public property pNotaFinal() as Integer
       get
           return NotaFinal
       end get

       set(byval value as Integer)
           NotaFinal = value
       end set
   end property

   public property pObservaciones() as String
       get
           return Observaciones
       end get

       set(byval value as String)
           Observaciones = value
       end set
   end property

#End Region

#Region "Metodos"




#End Region
End class
