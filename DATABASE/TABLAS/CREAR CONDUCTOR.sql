USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[conductor]    Script Date: 05/08/2023 14:32:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[conductor](
	[id_conductor] [varchar](50) NOT NULL,
	[nombre] [varchar](80) NULL,
	[cedula] [varchar](10) NOT NULL,
	[telefono] [varchar](10) NULL,
	[licencia] [varchar](10) NULL,
	[direccion] [varchar](100) NULL,
	[unidad] [nvarchar](50) NULL,
	[diasLaborados] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_conductor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


