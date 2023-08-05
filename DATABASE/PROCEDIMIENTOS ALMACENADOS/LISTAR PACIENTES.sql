USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_listar_pacientes]    Script Date: 05/08/2023 14:42:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_listar_pacientes]
as select * from Pacientes order by id_Paciente
GO

