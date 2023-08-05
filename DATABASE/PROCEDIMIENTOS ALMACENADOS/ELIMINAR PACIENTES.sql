USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_pacientes]    Script Date: 05/08/2023 14:40:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_eliminar_pacientes]
@nombre varchar(80) as
begin
	if exists(select * from pacientes where nombre = @nombre)
	begin
		delete from pacientes where nombre = @nombre;
		print 'El paciente ' + @nombre + ' ha sido eliminado';
	end
	else
	begin
		print 'El paciente ' + @nombre + ' no existe';
	end
end
GO

