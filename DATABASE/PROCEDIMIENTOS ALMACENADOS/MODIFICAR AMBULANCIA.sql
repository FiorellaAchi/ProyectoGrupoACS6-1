USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_modificar_ambulancia]    Script Date: 05/08/2023 14:43:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_modificar_ambulancia]
    @codigo VARCHAR(50),
    @marca VARCHAR(100),
    @numero_placa VARCHAR(20),
    @anio varchar (4),
    @id_conductor varchar (50)
AS
BEGIN
    UPDATE ambulancias
    SET marca = @marca,
        numero_placa = @numero_placa,
        anio = @anio,
        id_conductor = @id_conductor
    WHERE codigo = @codigo;

	-- Realizar el INNER JOIN entre ambulancias y conductor para obtener el nombre del conductor
    SELECT a.codigo, a.marca, a.numero_placa, a.anio, c.nombre as conductor_nombre
    FROM ambulancias a
    INNER JOIN conductor c ON a.id_conductor = c.id_conductor
    WHERE a.id_conductor = @id_conductor;
END


GO

