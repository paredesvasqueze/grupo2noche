USE [ARKCentry]
GO
/****** Object:  Table [dbo].[AreaDeEstudio]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AreaDeEstudio](
	[nIdArea] [int] IDENTITY(1,1) NOT NULL,
	[cAreadeEstudio] [varchar](50) NULL,
	[cDescripcion] [varchar](500) NULL,
	[cImagen] [varchar](300) NULL,
 CONSTRAINT [XPKAreasDeEstudio] PRIMARY KEY CLUSTERED 
(
	[nIdArea] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[nIdArticulo] [int] IDENTITY(1,1) NOT NULL,
	[cTituloArticulo] [varchar](50) NULL,
	[dFechaArticulo] [datetime] NULL,
	[cTexto] [varchar](500) NULL,
	[nVolumen] [char](18) NULL,
	[nIdPublicacion] [int] NOT NULL,
	[cIdPublicacion] [varchar](25) NOT NULL,
 CONSTRAINT [XPKArticulo] PRIMARY KEY CLUSTERED 
(
	[nIdArticulo] ASC,
	[nIdPublicacion] ASC,
	[cIdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[nIdAutor] [int] NOT NULL,
	[cNombre] [varchar](200) NULL,
	[cNacionalidad] [varchar](20) NULL,
	[cEspecialidad] [varchar](260) NULL,
 CONSTRAINT [XPKAutor] PRIMARY KEY CLUSTERED 
(
	[nIdAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[nIdComentario] [int] IDENTITY(1,1) NOT NULL,
	[dFechaComentario] [datetime] NULL,
	[nIdPublicacion] [int] NOT NULL,
	[cIdPublicacion] [varchar](25) NOT NULL,
	[nIdUsuario] [int] NOT NULL,
	[cComentario] [varchar](500) NULL,
 CONSTRAINT [XPKComentario] PRIMARY KEY CLUSTERED 
(
	[nIdComentario] ASC,
	[nIdPublicacion] ASC,
	[cIdPublicacion] ASC,
	[nIdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genero]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[nIdGenero] [int] IDENTITY(1,1) NOT NULL,
	[cTipoGenero] [varchar](50) NULL,
 CONSTRAINT [XPKGenero] PRIMARY KEY CLUSTERED 
(
	[nIdGenero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Investigacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Investigacion](
	[nIdInvestigacion] [int] IDENTITY(1,1) NOT NULL,
	[cTituloInvestigacion] [varchar](250) NULL,
	[dAnioInves] [datetime] NULL,
	[cInstitucion] [varchar](260) NULL,
	[cEnlaceAcceso] [varchar](200) NULL,
	[cResumen] [varchar](500) NULL,
	[nIdPublicacion] [int] NOT NULL,
	[cIdPublicacion] [varchar](25) NOT NULL,
 CONSTRAINT [XPKInvestigacion] PRIMARY KEY CLUSTERED 
(
	[nIdInvestigacion] ASC,
	[nIdPublicacion] ASC,
	[cIdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[nIdLibro] [int] IDENTITY(1,1) NOT NULL,
	[cTituloLibro] [varchar](300) NULL,
	[cEditorial] [varchar](100) NULL,
	[nPaginas] [int] NULL,
	[cIdioma] [varchar](20) NULL,
	[nIdGenero] [int] NULL,
	[nIdPublicacion] [int] NOT NULL,
	[cIdPublicacion] [varchar](25) NOT NULL,
 CONSTRAINT [XPKLibro] PRIMARY KEY CLUSTERED 
(
	[nIdLibro] ASC,
	[nIdPublicacion] ASC,
	[cIdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicacion](
	[nIdPublicacion] [int] IDENTITY(1,1) NOT NULL,
	[cIdPublicacion] [varchar](25) NOT NULL,
	[nTipoPublicacion] [varchar](30) NULL,
	[dFechaRegistro] [datetime] NULL,
	[cAutor] [varchar](200) NULL,
	[nIdArea] [int] NULL,
 CONSTRAINT [XPKPublicacion] PRIMARY KEY CLUSTERED 
(
	[nIdPublicacion] ASC,
	[cIdPublicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicacionAutor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicacionAutor](
	[nIdPublicacionAutor] [char](18) NOT NULL,
	[nIdPublicacion] [int] NULL,
	[cIdPublicacion] [varchar](25) NULL,
	[nIdAutor] [int] NULL,
 CONSTRAINT [XPKPublicacionAutor] PRIMARY KEY CLUSTERED 
(
	[nIdPublicacionAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[nIdRol] [int] IDENTITY(1,1) NOT NULL,
	[cTipodeRol] [varchar](200) NULL,
 CONSTRAINT [XPKRol] PRIMARY KEY CLUSTERED 
(
	[nIdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usser]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usser](
	[nIDUsser] [int] IDENTITY(1,1) NOT NULL,
	[cUserName] [varchar](50) NULL,
	[cPassword] [varchar](256) NULL,
PRIMARY KEY CLUSTERED 
(
	[nIDUsser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[nIdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[cNombre] [varchar](100) NULL,
	[cApellido] [varchar](100) NULL,
	[cEmail] [varchar](100) NULL,
	[nTelefono] [varchar](12) NULL,
	[cContrasena] [varchar](20) NULL,
	[cDireccion] [varchar](50) NULL,
	[nIdRol] [int] NOT NULL,
 CONSTRAINT [XPKUsuario] PRIMARY KEY CLUSTERED 
(
	[nIdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AreaDeEstudio] ON 

INSERT [dbo].[AreaDeEstudio] ([nIdArea], [cAreadeEstudio], [cDescripcion], [cImagen]) VALUES (1, N'Antropologia', N'Estudio de la humanidad, de los pueblos antiguos y modernos y de sus estilos de vida a través de las eras geológicas de la tierra', N'https://concepto.de/wp-content/uploads/2013/03/antropologia-biologia-e1589141167925.jpg')
INSERT [dbo].[AreaDeEstudio] ([nIdArea], [cAreadeEstudio], [cDescripcion], [cImagen]) VALUES (2, N'Biologia Molecular', N' La biología molecular es la disciplina científica que estudia la estructura, composición, función y relaciones de las moléculas celulares en los seres vivos.', N'https://cdn0.ecologiaverde.com/es/posts/0/9/6/biologia_molecular_que_es_y_su_importancia_3690_600.webp')
SET IDENTITY_INSERT [dbo].[AreaDeEstudio] OFF
GO
SET IDENTITY_INSERT [dbo].[usser] ON 

INSERT [dbo].[usser] ([nIDUsser], [cUserName], [cPassword]) VALUES (1, N'Juan', N'834C318F53AA0954D71F8AA0FA06D7C81B7F3376353AE2E2A20282C00DF4A1E0')
SET IDENTITY_INSERT [dbo].[usser] OFF
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [R_32] FOREIGN KEY([nIdPublicacion], [cIdPublicacion])
REFERENCES [dbo].[Publicacion] ([nIdPublicacion], [cIdPublicacion])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [R_32]
GO
ALTER TABLE [dbo].[Investigacion]  WITH CHECK ADD  CONSTRAINT [R_33] FOREIGN KEY([nIdPublicacion], [cIdPublicacion])
REFERENCES [dbo].[Publicacion] ([nIdPublicacion], [cIdPublicacion])
GO
ALTER TABLE [dbo].[Investigacion] CHECK CONSTRAINT [R_33]
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD  CONSTRAINT [R_31] FOREIGN KEY([nIdPublicacion], [cIdPublicacion])
REFERENCES [dbo].[Publicacion] ([nIdPublicacion], [cIdPublicacion])
GO
ALTER TABLE [dbo].[Libro] CHECK CONSTRAINT [R_31]
GO
ALTER TABLE [dbo].[Libro]  WITH CHECK ADD  CONSTRAINT [R_9] FOREIGN KEY([nIdGenero])
REFERENCES [dbo].[Genero] ([nIdGenero])
GO
ALTER TABLE [dbo].[Libro] CHECK CONSTRAINT [R_9]
GO
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [R_6] FOREIGN KEY([nIdArea])
REFERENCES [dbo].[AreaDeEstudio] ([nIdArea])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [R_6]
GO
ALTER TABLE [dbo].[PublicacionAutor]  WITH CHECK ADD  CONSTRAINT [R_27] FOREIGN KEY([nIdPublicacion], [cIdPublicacion])
REFERENCES [dbo].[Publicacion] ([nIdPublicacion], [cIdPublicacion])
GO
ALTER TABLE [dbo].[PublicacionAutor] CHECK CONSTRAINT [R_27]
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_AreaDeEstudio]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_AreaDeEstudio]
    @nIdArea             int,
	@cAreadeEstudio       varchar(50),
	@cDescripcion         varchar(500),
	@cImagen              varchar(300)
as
begin
update AreaDeEstudio set
[cAreadeEstudio] = @cAreadeEstudio,
[cDescripcion] = @cDescripcion,
[cImagen] = @cImagen
where nIdArea = @nIdArea
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_actualizar_Articulo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_actualizar_Articulo]
    @nIdArticulo          int,
	@cTituloArticulo      varchar(50),
	@dFechaArticulo       datetime,
	@cTexto               varchar(500),
	@nVolumen             char(18),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25) 
as
begin
update Articulo set
[cTituloArticulo] = @cTituloArticulo,
[dFechaArticulo] = @dFechaArticulo,
[cTexto] = @cTexto,
[nVolumen]= @nVolumen,
[nIdPublicacion]= @nIdPublicacion,
[cIdPublicacion]= @cIdPublicacion
where nIdArticulo = @nIdArticulo
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Autor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Autor]
    @nIdAutor             int,
	@cNombre              varchar(200),
	@cNacionalidad        varchar(20),
	@cEspecialidad        varchar(260) 
as
begin
update Autor set
[cNombre] = @cNombre,
[cNacionalidad] = @cNacionalidad,
[cEspecialidad] = @cEspecialidad
where nIdAutor = @nIdAutor
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Comentario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Comentario]
    @nIdComentario        int,
	@dFechaComentario     datetime,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdUsuario           int,
	@cComentario          varchar(500)
as
begin
update Comentario set
[dFechaComentario] = @dFechaComentario,
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion,
[nIdUsuario] = @nIdUsuario,
[cComentario] = @cComentario
where nIdComentario = @nIdComentario
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Genero]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Genero]
    @nIdGenero            int,
	@cTipoGenero          varchar(50)
as
begin
update Genero set
[cTipoGenero] = @cTipoGenero
where nIdGenero = @nIdGenero
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Investigacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Investigacion]
    @nIdInvestigacion     int,
	@cTituloInvestigacion varchar(250),
	@dAnioInves           datetime,
	@cInstitucion         varchar(260),
	@cEnlaceAcceso        varchar(200),
	@cResumen             varchar(500),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25)
as
begin
update Investigacion set
[cTituloInvestigacion] = @cTituloInvestigacion,
[dAnioInves] = @dAnioInves,
[cInstitucion] = @cInstitucion,
[cEnlaceAcceso] = @cEnlaceAcceso,
[cResumen] = @cResumen,
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion
where nIdInvestigacion = @nIdInvestigacion
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Libro]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Libro]
    @nIdLibro             int,
	@cTituloLibro         varchar,
	@cEditorial           varchar(100),
	@nPaginas             int,
	@cIdioma              varchar(20),
	@nIdGenero            int,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25) 

as
begin
update Libro set
[cTituloLibro] = @cTituloLibro,
[cEditorial] = @cEditorial,
[nPaginas] = @nPaginas,
[cIdioma] = @cIdioma,
[nIdGenero] = @nIdGenero,
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion 


where nIdLibro = @nIdLibro 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Publicacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Publicacion]
    @nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nTipoPublicacion     varchar(30),
	@dFechaRegistro       datetime,
	@cAutor               varchar(200),
	@nIdArea              int
as
begin
update Publicacion set
[cIdPublicacion] = @cIdPublicacion,
[nTipoPublicacion] = @nTipoPublicacion,
[dFechaRegistro] = @dFechaRegistro,
[cAutor] = @cAutor,
[nIdArea] = @nIdArea
where nIdPublicacion = @nIdPublicacion
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_PublicacionAutor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_PublicacionAutor]
    @nIdPublicacionAutor  char(18),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdAutor             int   

as
begin
update PublicacionAutor set
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion,
[nIdAutor] = @nIdAutor
where nIdPublicacionAutor = @nIdPublicacionAutor
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Rol]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Rol]
    @nIdRol               int,
	@cTipodeRol           varchar(20) 

as
begin
update Rol set
[cTipodeRol ] = @cTipodeRol 
where nIdRol = @nIdRol 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Actualizar_Usuario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Actualizar_Usuario]
    @nIdUsuario           int,
	@cNombre              varchar(100),
	@cApellido            varchar(100),
	@cEmail               varchar(100),
	@nTelefono            varchar(12),
	@cContrasena          varchar(20),
	@cDireccion           varchar(50),
	@nIdRol               int  

as
begin
update Usuario set
[cNombre] = @cNombre,
[cApellido] = @cApellido, 
[cEmail] = @cEmail,
[nTelefono] = @nTelefono,  
[cContrasena] = @cContrasena,   
[cDireccion] = @cDireccion,
[nIdRol] = @nIdRol
where nIdUsuario  = @nIdUsuario  
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_AreaDeEstudio]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_AreaDeEstudio]
 @nIdArea             int
as
begin
Delete from AreaDeEstudio
where nIdArea = @nIdArea 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_eliminar_Articulo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_eliminar_Articulo]
@nIdArticulo int
as
begin
Delete from Articulo
where nIdArticulo = @nIdArticulo
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Autor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Autor]
 @nIdAutor            int
as
begin
Delete from Autor
where nIdAutor = @nIdAutor 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Comentario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Comentario]
 @nIdComentario       int
as
begin
Delete from Comentario
where nIdComentario  = @nIdComentario 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Genero]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Genero]
 @nIdGenero            int
as
begin
Delete from Genero
where nIdGenero = @nIdGenero
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Investigacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Investigacion]
 @nIdInvestigacion     int
as
begin
Delete from Investigacion
where nIdInvestigacion = @nIdInvestigacion 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Libro]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Libro]
 @nIdLibro                 int
as
begin
Delete from Libro
where nIdLibro = @nIdLibro 
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Publicacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Publicacion]
 @nIdPublicacion       int
as 
begin
Delete from Publicacion
where nIdPublicacion  = @nIdPublicacion  
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_PublicacionAutor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_PublicacionAutor]
 @nIdPublicacionAutor  char(18)
as
begin
Delete from PublicacionAutor
where nIdPublicacionAutor  = @nIdPublicacionAutor  
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Rol]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Rol]
 @nIdRol               int
as
begin
Delete from Rol
where nIdRol = @nIdRol
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Eliminar_Usuario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Eliminar_Usuario]
 @nIdUsuario           int
as
begin
Delete from Usuario
where nIdUsuario = @nIdUsuario
select CAST(@@ROWCOUNT as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_AreaDeEstudio]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_AreaDeEstudio]
	@cAreadeEstudio       varchar(50),
	@cDescripcion         varchar(500),
	@cImagen              varchar(300)
as
begin
insert into AreaDeEstudio

(cAreadeEstudio,cDescripcion,cImagen)
values
(@cAreadeEstudio, @cDescripcion, @cImagen)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_insertar_Articulo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_insertar_Articulo]
    @cTituloArticulo      varchar(50),
	@dFechaArticulo       datetime,
	@cTexto               varchar(500),
	@nVolumen             char(18),
	@nIdPublicacion       int ,
	@cIdPublicacion       varchar(25) 
as
begin
insert into Articulo

(cTituloArticulo , dFechaArticulo, cTexto, nVolumen, nIdPublicacion, cIdPublicacion)
values
(@cTituloArticulo , @dFechaArticulo, @cTexto, @nVolumen, @nIdPublicacion, @cIdPublicacion)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Autor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Autor]
	@cNombre              varchar(200),
	@cNacionalidad        varchar(20),
	@cEspecialidad        varchar(260)
as
begin
insert into Autor

(cNombre, cNacionalidad, cEspecialidad)
values
(@cNombre, @cNacionalidad,@cEspecialidad)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Comentario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Comentario]
	@dFechaComentario     datetime,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdUsuario           int,
	@cComentario          varchar(500)
as
begin
insert into Comentario

(dFechaComentario, nIdPublicacion, cIdPublicacion, nIdUsuario, cComentario)
values
(@dFechaComentario, @nIdPublicacion, @cIdPublicacion, @nIdUsuario, @cComentario)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Genero]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Genero]
	@cTipoGenero          varchar(50)
as
begin
insert into Genero

(cTipoGenero)
values
(@cTipoGenero)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Investigacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Investigacion]
	@cTituloInvestigacion varchar(250),
	@dAnioInves           datetime,
	@cInstitucion         varchar(260),
	@cEnlaceAcceso        varchar(200),
	@cResumen             varchar(500),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25)
as
begin
insert into Investigacion

(cTituloInvestigacion, dAnioInves, cInstitucion, cEnlaceAcceso, cResumen, nIdPublicacion, cIdPublicacion)
values
(@cTituloInvestigacion, @dAnioInves, @cInstitucion, @cEnlaceAcceso,	@cResumen,@nIdPublicacion, @cIdPublicacion)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Libro]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Libro]
	@cTituloLibro         varchar,
	@cEditorial           varchar(100),
	@nPaginas             int,
	@cIdioma              varchar(20),
	@nIdGenero            int,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25)  
as
begin
insert into Libro

(cTituloLibro, cEditorial, nPaginas, cIdioma, nIdGenero, nIdPublicacion, cIdPublicacion)
values
(@cTituloLibro, @cEditorial, @nPaginas, @cIdioma, @nIdGenero, @nIdPublicacion, @cIdPublicacion)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Publicacion]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Publicacion]
	@cIdPublicacion       varchar(25),
	@nTipoPublicacion     varchar(30),
	@dFechaRegistro       datetime,
	@cAutor               varchar(200),
	@nIdArea              int
as
begin
insert into Publicacion

(cIdPublicacion, nTipoPublicacion, dFechaRegistro, cAutor, nIdArea)
values
(@cIdPublicacion,@nTipoPublicacion,@dFechaRegistro, @cAutor, @nIdArea)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_PublicacionAutor]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_PublicacionAutor]
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdAutor             int 
as
begin
insert into PublicacionAutor

(nIdPublicacion,cIdPublicacion,nIdAutor)
values
(@nIdPublicacion, @cIdPublicacion, @nIdAutor)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Rol]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_Insertar_Rol]
	@cTipodeRol           varchar(200)  
as
begin
insert into Rol

(cTipodeRol)
values
(@cTipodeRol)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Insertar_Usuario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Insertar_Usuario]
	@cNombre              varchar(100),
	@cApellido            varchar(100),
	@cEmail               varchar(100),
	@nTelefono            varchar(12),
	@cContrasena          varchar(20),
	@cDireccion           varchar(50),
	@nIdRol               int   
as
begin
insert into Usuario

(cNombre, cApellido, cEmail, nTelefono, cContrasena,cDireccion, nIdRol)
values
(@cNombre, @cApellido, @cEmail, @nTelefono, @cContrasena, @cDireccion, @nIdRol)
select cast (SCOPE_IDENTITY() as int)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_AreaDeEstudio_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_AreaDeEstudio_Todo]
as
begin
select * from AreaDeEstudio
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Articulo_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Articulo_Todo]
as
begin
select * from Articulo

end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Autor_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Autor_Todo]
as
begin
select * from Autor
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Comentario_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_seleccionar_Comentario_Todo]
as
begin
select Com.*,
uss.cNombre as cNombreUsuario,
publi.cIdPublicacion  as cNombrePublicacion
from Comentario Com
inner Join Usuario uss on uss.nIdUsuario = Com.nIdUsuario
inner Join Publicacion	publi on publi.nIdPublicacion = Com.nIdPublicacion
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Genero_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Genero_Todo]
as
begin
select * from Genero
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Investigacion_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Investigacion_Todo]
as
begin
select * from Investigacion
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Libro_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Libro_Todo]
as
begin
select * from Libro
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Publicacion_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Publicacion_Todo]
as
begin
select * from Publicacion
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_PublicacionAutor_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_PublicacionAutor_Todo]
as
begin
select * from PublicacionAutor
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Rol_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Rol_Todo]
as
begin
select * from Rol
end
GO
/****** Object:  StoredProcedure [dbo].[usp_seleccionar_Usuario_Todo]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_seleccionar_Usuario_Todo]
as
begin
select * from Usuario
end
GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 11/12/2024 18:24:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ValidarUsuario]
@cUserName varchar(50),
@cPassword varchar(256)
as
begin
if exists(select * from usser where 
cUserName = @cUserName and cPassword = @cPassword)
begin
select cast(1 as bit)
end
else
begin
select cast(0 as bit)
end

end

GO
