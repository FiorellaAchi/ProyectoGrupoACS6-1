USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[facturas]    Script Date: 05/08/2023 14:32:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[facturas](
	[id_Factura] [varchar](5) NOT NULL,
	[cedula] [varchar](10) NULL,
	[id_conductor] [varchar](50) NULL,
	[codigo_ambulancia] [varchar](50) NULL,
	[id_Insumo] [varchar](80) NULL,
	[codigo_servicio] [varchar](5) NULL,
	[emision] [varchar](80) NULL,
	[domicilio] [varchar](80) NULL,
	[descripcion] [varchar](80) NULL,
	[subtotal] [decimal](10, 2) NULL,
	[total] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([codigo_ambulancia])
REFERENCES [dbo].[ambulancias] ([codigo])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([codigo_servicio])
REFERENCES [dbo].[servicios] ([codigo])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([codigo_ambulancia])
REFERENCES [dbo].[ambulancias] ([codigo])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([codigo_servicio])
REFERENCES [dbo].[servicios] ([codigo])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([id_conductor])
REFERENCES [dbo].[conductor] ([id_conductor])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([id_conductor])
REFERENCES [dbo].[conductor] ([id_conductor])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([id_Insumo])
REFERENCES [dbo].[insumos] ([id_Insumos])
GO

ALTER TABLE [dbo].[facturas]  WITH CHECK ADD FOREIGN KEY([id_Insumo])
REFERENCES [dbo].[insumos] ([id_Insumos])
GO


