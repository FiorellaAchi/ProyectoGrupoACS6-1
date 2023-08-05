USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_servicios]    Script Date: 05/08/2023 14:41:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_eliminar_servicios]
@nombre varchar(80) as
begin
	if exists(select * from servicios where nombre = @nombre)
	begin
		delete from servicios where nombre = @nombre;
		print 'El servicio ' + @nombre + ' ha sido eliminado';
	end
	else
	begin
		print 'El servicio ' + @nombre + ' no existe';
	end
end
GO

