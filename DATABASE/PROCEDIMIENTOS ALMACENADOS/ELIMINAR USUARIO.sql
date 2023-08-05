USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_usuario]    Script Date: 05/08/2023 14:40:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_eliminar_usuario]
@nombre varchar(80) as
begin
	if exists(select * from usuario where nombre = @nombre)
	begin
		delete from usuario where nombre = @nombre;
		print 'El usuario ' + @nombre + ' ha sido eliminado';
	end
	else
	begin
		print 'El usuario ' + @nombre + ' no existe';
	end
end
GO

