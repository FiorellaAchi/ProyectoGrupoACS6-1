USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_insumos]    Script Date: 05/08/2023 14:40:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_eliminar_insumos]
@insumo varchar(80) as
begin
	if exists(select * from insumos where insumo = @insumo)
	begin
		delete from insumos where insumo = @insumo;
		print 'El insumo ' + @insumo + ' ha sido eliminado';
	end
	else
	begin
		print 'El insumo ' + @insumo + ' no existe';
	end
end
GO

