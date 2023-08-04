USE [ProyectoAmbulancia1]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_crear_ambulancia]
		@codigo = NULL,
		@marca = NULL,
		@numero_placa = NULL,
		@anio = NULL,
		@id_conductor = NULL

SELECT	'Return Value' = @return_value

GO

Select * from conductor
