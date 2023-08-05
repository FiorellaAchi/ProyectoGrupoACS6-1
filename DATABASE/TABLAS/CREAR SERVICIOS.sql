USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[servicios]    Script Date: 05/08/2023 14:34:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[servicios](
	[codigo] [varchar](5) NOT NULL,
	[nombre] [varchar](80) NULL,
	[descripcion] [varchar](50) NULL,
	[precio] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


