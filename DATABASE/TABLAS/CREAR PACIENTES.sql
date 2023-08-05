USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[Pacientes]    Script Date: 05/08/2023 14:33:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pacientes](
	[id_Paciente] [varchar](5) NOT NULL,
	[nombre] [varchar](80) NULL,
	[apellido] [varchar](50) NULL,
	[edad] [varchar](50) NULL,
	[fechaIngreso] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


