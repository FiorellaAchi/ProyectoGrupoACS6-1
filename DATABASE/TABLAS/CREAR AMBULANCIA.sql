USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[ambulancias]    Script Date: 05/08/2023 14:31:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ambulancias](
	[codigo] [varchar](50) NOT NULL,
	[marca] [varchar](100) NULL,
	[numero_placa] [varchar](20) NULL,
	[anio] [varchar](4) NULL,
	[id_conductor] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ambulancias]  WITH CHECK ADD FOREIGN KEY([id_conductor])
REFERENCES [dbo].[conductor] ([id_conductor])
GO


