USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_conductor]    Script Date: 05/08/2023 14:40:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_eliminar_conductor]
@id VARCHAR (50) as
begin
if exists(select * from conductor where id_conductor = @id)
	begin
		delete from conductor where id_conductor = @id;
		print 'El conductor ha sido eliminado';
	end
	else
	begin
		print 'El conductor no existe';
	end
end
GO

