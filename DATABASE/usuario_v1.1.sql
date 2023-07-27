GO

/****** Object:  Table [dbo].[usuario]    Script Date: 22/7/2023 4:09:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[usuario](
	[codigo] [varchar](5) NULL,
	[nombre] [varchar](80) NULL,
	[cedula] [varchar](10) NULL,
	[telefono] [varchar](10) NULL,
	[email] [varchar](255) NULL,
	[contrasena] [varchar](50) NULL,
	[tipo] [int] NULL
) ON [PRIMARY]
GO


