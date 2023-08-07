USE [ProyectoAmbulancia1]
GO

/****** Object:  Table [dbo].[facturas]    Script Date: 06/08/2023 20:22:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER TABLE [dbo].[facturas]
ADD id_paciente varchar(5) NULL;

ALTER TABLE [dbo].[facturas]
ADD CONSTRAINT FK_facturas_Pacientes FOREIGN KEY (id_paciente)
REFERENCES [dbo].[Pacientes] (id_Paciente);


