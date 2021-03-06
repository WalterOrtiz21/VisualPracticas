go
create database Facu
go
USE [Facu]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 12/11/2018 9:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[CodAlumno] [int] NOT NULL,
	[NombreApellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[Tel�fono] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[CodAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[CodCurso] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[CodModalidad] [int] NOT NULL,
	[CodFacultad] [int] NOT NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[CodCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CursoAlumno]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CursoAlumno](
	[CodCurso] [int] NOT NULL,
	[CodAlumno] [int] NOT NULL,
	[FechaMatriculacion] [date] NOT NULL,
	[NotaFinal] [int] NOT NULL,
	[Observaciones] [varchar](50) NULL,
 CONSTRAINT [PK_CursoAlumno] PRIMARY KEY CLUSTERED 
(
	[CodCurso] ASC,
	[CodAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facultad]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facultad](
	[CodFacultad] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[FechaFundacion] [date] NULL,
 CONSTRAINT [PK_Facultad] PRIMARY KEY CLUSTERED 
(
	[CodFacultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modalidad]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modalidad](
	[CodModalidad] [int] NOT NULL,
	[Descripci�n] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Modalidad] PRIMARY KEY CLUSTERED 
(
	[CodModalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaCursosPorFacultad]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spConsultaCursosPorFacultad] @Codfacultad int
as
select * from Curso where CodFacultad=@Codfacultad order by Descripcion
GO
/****** Object:  StoredProcedure [dbo].[spConsultarAlumnoPorCodigo]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultarAlumnoPorCodigo] @CodAlumno int
as
select * from Alumno where CodAlumno=@CodAlumno
exec spConsultarAlumnoPorCodigo 1
GO
/****** Object:  StoredProcedure [dbo].[spConsultarAlumnosPorCurso]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultarAlumnosPorCurso] @CodCurso int
as
select* from CursoAlumno CA
join Alumno A on A.CodAlumno=Ca.CodAlumno
where CA.CodAlumno=@CodCurso
GO
/****** Object:  StoredProcedure [dbo].[spConsultarFacultades]    Script Date: 12/11/2018 9:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultarFacultades]
as
select * from Facultad order by Descripcion
GO
