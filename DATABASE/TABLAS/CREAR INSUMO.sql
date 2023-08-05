USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[insumos]    Script Date: 05/08/2023 14:33:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[insumos](
	[id_Insumos] [varchar](80) NOT NULL,
	[insumo] [varchar](80) NULL,
	[proveedor] [varchar](80) NULL,
	[fecha] [varchar](50) NULL,
	[estado] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Insumos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


