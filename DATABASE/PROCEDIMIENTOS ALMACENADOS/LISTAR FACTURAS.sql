USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_factura]    Script Date: 06/08/2023 20:29:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_listar_factura]
AS
BEGIN
    SELECT
        f.id_Factura,
        c.nombre AS nombre_conductor,
        c.id_conductor,
        p.nombre AS nombre_paciente, -- Cambiado p.id_Paciente a p.nombre
        a.codigo AS codigo_ambulancia,
        a.numero_placa,
        i.id_Insumos,
        i.insumo,
        s.codigo AS codigo_servicio,
        s.nombre AS nombre_servicio,
        f.domicilio as domicilio,
        f.emision as emision,
        f.descripcion as descripcion,
        f.subtotal as subtotal,
        f.total as total
    FROM
        facturas f
        INNER JOIN conductor c ON f.id_conductor = c.id_conductor
        INNER JOIN ambulancias a ON f.codigo_ambulancia = a.codigo
        INNER JOIN insumos i ON f.id_Insumo = i.id_Insumos
        INNER JOIN servicios s ON f.codigo_servicio = s.codigo
        INNER JOIN Pacientes p ON f.id_Paciente = p.id_Paciente; -- Corregido la condición de JOIN
END