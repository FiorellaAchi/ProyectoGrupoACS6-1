USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_listar_conductor]    Script Date: 05/08/2023 14:41:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_listar_conductor]
as select * from conductor order by id_conductor;
GO

