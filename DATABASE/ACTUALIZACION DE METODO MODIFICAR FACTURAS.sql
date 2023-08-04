USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_ambulancia]    Script Date: 04/08/2023 13:44:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE ModificarFactura (
    @id_factura varchar(5),
    @cedula varchar(10),
    @id_conductor varchar(50),
    @codigo_ambulancia varchar(50),
    @id_insumo varchar(80),
    @codigo_servicio varchar(5),
    @emision varchar(80),
    @domicilio varchar(80),
    @descripcion varchar(80),
    @subtotal DECIMAL(10, 2),
    @total DECIMAL(10, 2)
)
AS
BEGIN
    UPDATE facturas
    SET cedula = @cedula,
        id_conductor = @id_conductor,
        codigo_ambulancia = @codigo_ambulancia,
        id_Insumo = @id_insumo,
        codigo_servicio = @codigo_servicio,
        emision = @emision,
        domicilio = @domicilio,
        descripcion = @descripcion,
        subtotal = @subtotal,
        total = @total
    WHERE id_Factura = @id_factura
END