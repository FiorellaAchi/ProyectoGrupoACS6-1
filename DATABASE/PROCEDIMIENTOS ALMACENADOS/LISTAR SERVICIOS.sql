USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_listar_servicios]    Script Date: 05/08/2023 14:42:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_listar_servicios]
as select *from servicios order by codigo

GO

