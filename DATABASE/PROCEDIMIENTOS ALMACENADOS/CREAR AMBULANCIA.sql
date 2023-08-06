USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_ambulancia]    Script Date: 03/08/2023 19:34:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_crear_ambulancia]
    @codigo varchar (50),
    @marca VARCHAR(100),
    @numero_placa VARCHAR(20),
    @anio varchar (4),
    @id_conductor varchar (50)
AS
BEGIN
    DECLARE @codnuevo VARCHAR(5), @codmax VARCHAR(5)
    SET @codmax = (SELECT MAX(codigo) FROM ambulancias)
    SET @codmax = ISNULL(@codmax, 'A0000')
    SET @codnuevo = 'A' + RIGHT(RIGHT(@codmax, 4) + 10001, 4)

    INSERT INTO ambulancias (codigo, marca, numero_placa, anio, id_conductor)
    VALUES (@codigo, @marca, @numero_placa, @anio, @id_conductor)

	-- Realizar el INNER JOIN entre ambulancias y conductor para obtener el nombre del conductor
    SELECT a.codigo, a.marca, a.numero_placa, a.anio, c.nombre as conductor_nombre
    FROM ambulancias a
    INNER JOIN conductor c ON a.id_conductor = c.id_conductor
    WHERE a.id_conductor = @id_conductor;
END




