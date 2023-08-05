USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_crear_servicios]    Script Date: 05/08/2023 14:36:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_crear_servicios]
@codigo varchar(5),
@nombre varchar(80),
@descripcion varchar(50),
@precio varchar(80) output
as
begin
	DECLARE @codnuevo varchar(5), @codmax varchar(5)
    
    
    SET @codmax = (SELECT MAX(codigo) FROM servicios)
    SET @codmax = ISNULL(@codmax, 'A0000')
    SET @codnuevo = 'A' + RIGHT(RIGHT(@codmax, 4) + 10001, 4)

    INSERT INTO servicios(codigo, nombre, descripcion, precio)
    VALUES (@codnuevo, @nombre, @descripcion, @precio)
end
GO


