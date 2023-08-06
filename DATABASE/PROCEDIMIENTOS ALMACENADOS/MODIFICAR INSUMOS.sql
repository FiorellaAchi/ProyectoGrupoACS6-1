USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_insumos]    Script Date: 06/08/2023 17:06:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[sp_modificar_insumos]
@codigo varchar(5), @insumo varchar(80), @fecha varchar(50), @proveedor varchar(80), @estado varchar(80)
as
update insumos set insumo = @insumo, fecha = @fecha, proveedor = @proveedor, estado = @estado where id_Insumos = @codigo
