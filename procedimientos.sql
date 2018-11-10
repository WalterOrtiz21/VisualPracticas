create procedure spConsultaCursosPorFacultad @Codfacultad int
as
select * from Curso where CodFacultad=@Codfacultad order by Descripcion


create procedure spConsultarAlumnosPorCurso @CodCurso int
as
select* from CursoAlumno CA
join Alumno A on A.CodAlumno=Ca.CodAlumno
where CA.CodAlumno=@CodCurso


create procedure spConsultarFacultades
as
select * from Facultad order by Descripcion


create procedure spConsultarAlumnoPorCodigo @CodAlumno int
as
select * from Alumno where CodAlumno=@CodAlumno
exec spConsultarAlumnoPorCodigo 1