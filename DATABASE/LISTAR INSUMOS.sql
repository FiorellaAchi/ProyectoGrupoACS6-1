USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_insumos]    Script Date: 04/08/2023 9:26:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER proc [dbo].[sp_listar_insumos]
as select *from insumos order by id_Insumos
