USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_pacientes]    Script Date: 04/08/2023 8:23:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[sp_listar_pacientes]
as select * from Pacientes order by codigo
