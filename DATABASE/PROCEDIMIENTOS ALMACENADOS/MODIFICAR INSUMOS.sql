USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_modificar_insumos]    Script Date: 05/08/2023 14:44:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_modificar_insumos]
@codigo varchar(5), @insumo varchar(80), @fecha varchar(50), @proveedor varchar(80), @estado varchar(80)
as
update insumos set insumo = @insumo, fecha = @fecha, proveedor = @proveedor, estado = @estado where codigo = @codigo

GO

