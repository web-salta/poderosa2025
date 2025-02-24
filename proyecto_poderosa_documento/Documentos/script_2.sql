
CREATE DATABASE [noticia_prueba] 
GO
USE [noticia_prueba]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 07/14/2017 17:34:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[nom_usu] [varchar](250) NULL,
	[clave] [varchar](250) NULL,
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [XPKusuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[seccion]    Script Date: 07/14/2017 17:34:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[seccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre_espanol] [varchar](200) NULL,
	[nombre_ingles] [varchar](200) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_seccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[noticia]    Script Date: 07/14/2017 17:34:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[noticia](
	[id_noticia] [int] IDENTITY(1,1) NOT NULL,
	[titulo_espanol] [varchar](250) NULL,
	[descripcion_espanol] [text] NULL,
	[descripcion_ingles] [text] NULL,
	[titulo_ingles] [varchar](250) NULL,
	[foto] [varchar](200) NULL,
	[orden] [int] NULL,
	[principal] [int] NULL,
	[fecha] [varchar](250) NULL,
	[fecha_modificacion] [datetime] NULL,
	[id_usuario] [int] NULL,
 CONSTRAINT [XPKnoticia] PRIMARY KEY CLUSTERED 
(
	[id_noticia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_seccion]    Script Date: 07/14/2017 17:34:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalle_seccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[seccionId] [int] NULL,
	[titulo_espanol] [varchar](200) NULL,
	[titulo_ingles] [varchar](200) NULL,
	[descripcion_espanol] [varchar](900) NULL,
	[descripcion_ingles] [varchar](900) NULL,
	[documento_espanol] [varchar](900) NULL,
	[documento_ingles] [varchar](900) NULL,
	[foto_espanol] [varchar](500) NULL,
	[foto_ingles] [varchar](500) NULL,
	[url_web] [varchar](900) NULL,
	[activar_urlweb] [bit] NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_detalle_seccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO


INSERT INTO usuario (nom_usu, clave)VALUES ('admin', 'e10adc3949ba59abbe56e057f20f883e');