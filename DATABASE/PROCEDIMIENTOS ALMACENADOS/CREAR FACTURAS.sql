USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_crear_factura]    Script Date: 05/08/2023 14:36:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_crear_factura] (
    @id_factura VARCHAR(5),
    @cedula VARCHAR(10),
    @id_conductor VARCHAR(50),
    @codigo_ambulancia VARCHAR(50),
    @id_insumo VARCHAR(80),
    @codigo_servicio VARCHAR(5),
    @emision VARCHAR(80),
    @domicilio VARCHAR(80),
    @descripcion VARCHAR(80),
    @subtotal DECIMAL(10, 2)
)
AS
BEGIN
    BEGIN TRY
        -- Calcular el total como el 112% del subtotal
        DECLARE @total DECIMAL(10, 2);
        SET @total = @subtotal * 1.12;

        -- Insertar la factura en la tabla facturas
        INSERT INTO facturas (id_Factura, cedula, id_conductor, codigo_ambulancia, id_Insumo, codigo_servicio, emision, domicilio, descripcion, subtotal, total)
        VALUES (@id_factura, @cedula, @id_conductor, @codigo_ambulancia, @id_insumo, @codigo_servicio, @emision, @domicilio, @descripcion, @subtotal, @total);



    END TRY
    BEGIN CATCH
        PRINT 'Error al insertar la factura';
    END CATCH;
END
GO


