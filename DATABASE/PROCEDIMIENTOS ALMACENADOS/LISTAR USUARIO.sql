USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_listar_usuario]    Script Date: 05/08/2023 14:42:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_listar_usuario]
as select *from usuario order by codigo
GO

