USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_listar_ambulancia]    Script Date: 05/08/2023 14:41:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_listar_ambulancia]
AS
BEGIN
    SELECT a.codigo,
           a.marca,
           a.numero_placa,
           a.anio,
           c.nombre AS nombre_conductor  -- Utilizar un alias para el nombre del conductor
    FROM ambulancias a
    INNER JOIN conductor c ON a.id_conductor = c.id_conductor
    ORDER BY a.codigo;
END
GO

