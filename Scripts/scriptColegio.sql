USE [Colegio]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 2/10/2024 15:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[nId] [int] IDENTITY(1,1) NOT NULL,
	[cNombre] [varchar](50) NULL,
	[cApellido] [varchar](50) NULL,
	[dFechaNacimiento] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[nId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([nId], [cNombre], [cApellido], [dFechaNacimiento]) VALUES (1, N'Juan', N'Perez', CAST(N'2024-10-02T19:53:46.927' AS DateTime))
INSERT [dbo].[Alumno] ([nId], [cNombre], [cApellido], [dFechaNacimiento]) VALUES (2, N'Juan', N'Perez', CAST(N'2024-10-02T19:54:48.600' AS DateTime))
SET IDENTITY_INSERT [dbo].[Alumno] OFF
GO
/****** Object:  StoredProcedure [dbo].[USP_GET_Alumno_Todos]    Script Date: 2/10/2024 15:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GET_Alumno_Todos]
as
select * from alumno

GO
/****** Object:  StoredProcedure [dbo].[USP_Insert_Alumno]    Script Date: 2/10/2024 15:01:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc  [dbo].[USP_Insert_Alumno]
@cNombre varchar(50),
@cApellido varchar(50),
@dFechaNacimiento datetime
as
begin
insert into alumno
(cNombre,cApellido,dFechaNacimiento)
values
(@cNombre,@cApellido,@dFechaNacimiento)
select cast(SCOPE_IDENTITY() as int)
end
GO
