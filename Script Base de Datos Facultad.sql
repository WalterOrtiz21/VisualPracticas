USE [Facu]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 13/06/2017 17:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 13/06/2017 17:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CursoAlumno]    Script Date: 13/06/2017 17:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Facultad]    Script Date: 13/06/2017 17:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modalidad]    Script Date: 13/06/2017 17:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Alumno] ([CodAlumno], [NombreApellido], [Direccion], [Tel�fono], [Email], [FechaNacimiento]) VALUES (1, N'Jorge Balcazar', N'Pozo Favorito', N'2039', N'jbalcazar@gmail.com', CAST(N'2001-01-01' AS Date))
INSERT [dbo].[Alumno] ([CodAlumno], [NombreApellido], [Direccion], [Tel�fono], [Email], [FechaNacimiento]) VALUES (2, N'Carlos Brizuela', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([CodAlumno], [NombreApellido], [Direccion], [Tel�fono], [Email], [FechaNacimiento]) VALUES (3, N'Fabiola Caceres', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([CodAlumno], [NombreApellido], [Direccion], [Tel�fono], [Email], [FechaNacimiento]) VALUES (4, N'Rafael Memmel', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([CodAlumno], [NombreApellido], [Direccion], [Tel�fono], [Email], [FechaNacimiento]) VALUES (5, N'Alexandra Rios', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([CodAlumno], [NombreApellido], [Direccion], [Tel�fono], [Email], [FechaNacimiento]) VALUES (6, N'Amanda Bernard', NULL, NULL, NULL, NULL)
INSERT [dbo].[Curso] ([CodCurso], [Descripcion], [CodModalidad], [CodFacultad], [FechaInicio], [FechaFin]) VALUES (1, N'Introducción ', 1, 1, NULL, NULL)
INSERT [dbo].[Curso] ([CodCurso], [Descripcion], [CodModalidad], [CodFacultad], [FechaInicio], [FechaFin]) VALUES (2, N'Curso 2', 2, 2, NULL, NULL)
INSERT [dbo].[Curso] ([CodCurso], [Descripcion], [CodModalidad], [CodFacultad], [FechaInicio], [FechaFin]) VALUES (3, N'Curso 3', 1, 1, NULL, NULL)
INSERT [dbo].[Curso] ([CodCurso], [Descripcion], [CodModalidad], [CodFacultad], [FechaInicio], [FechaFin]) VALUES (4, N'Curso4', 2, 2, NULL, NULL)
INSERT [dbo].[Curso] ([CodCurso], [Descripcion], [CodModalidad], [CodFacultad], [FechaInicio], [FechaFin]) VALUES (5, N'Curso5', 1, 1, NULL, NULL)
INSERT [dbo].[Curso] ([CodCurso], [Descripcion], [CodModalidad], [CodFacultad], [FechaInicio], [FechaFin]) VALUES (6, N'Curso 6', 1, 3, NULL, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (1, 1, CAST(N'2013-03-03' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (1, 2, CAST(N'2013-01-01' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (1, 3, CAST(N'2013-01-01' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (1, 4, CAST(N'2013-01-01' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (1, 5, CAST(N'2013-01-01' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (2, 1, CAST(N'2013-03-03' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (3, 1, CAST(N'2013-03-03' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (3, 3, CAST(N'2013-03-03' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (4, 2, CAST(N'2013-08-08' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (4, 3, CAST(N'2013-03-03' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (5, 2, CAST(N'2013-08-08' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (5, 3, CAST(N'2031-02-19' AS Date), 0, NULL)
INSERT [dbo].[CursoAlumno] ([CodCurso], [CodAlumno], [FechaMatriculacion], [NotaFinal], [Observaciones]) VALUES (6, 2, CAST(N'2013-08-08' AS Date), 0, NULL)
INSERT [dbo].[Facultad] ([CodFacultad], [Descripcion], [FechaFundacion]) VALUES (1, N'Ciencias y Tecnolog?a', NULL)
INSERT [dbo].[Facultad] ([CodFacultad], [Descripcion], [FechaFundacion]) VALUES (2, N'Econom?a', NULL)
INSERT [dbo].[Facultad] ([CodFacultad], [Descripcion], [FechaFundacion]) VALUES (3, N'Ciencias de la Salud', NULL)
INSERT [dbo].[Facultad] ([CodFacultad], [Descripcion], [FechaFundacion]) VALUES (4, N'Derecho', NULL)
INSERT [dbo].[Facultad] ([CodFacultad], [Descripcion], [FechaFundacion]) VALUES (5, N'Arquitectura', NULL)
INSERT [dbo].[Modalidad] ([CodModalidad], [Descripci�n]) VALUES (1, N'Presencial')
INSERT [dbo].[Modalidad] ([CodModalidad], [Descripci�n]) VALUES (2, N'Elearning')
