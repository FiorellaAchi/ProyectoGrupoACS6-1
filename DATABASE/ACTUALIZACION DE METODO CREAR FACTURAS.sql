USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_factura]    Script Date: 20/07/2023 14:00:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[sp_crear_factura]
@codigo VARCHAR(5),
    @cedula VARCHAR(10),
    @nombre VARCHAR(50),
    @emision VARCHAR(80),
    @telefono VARCHAR(80),
    @domicilio VARCHAR(80),
    @descripcion VARCHAR(80) OUTPUT
AS
BEGIN
    INSERT INTO factura (codigo, cedula, nombre, emision, telefono, domicilio, descripcion)
    VALUES (@codigo, @cedula, @nombre, @emision, @telefono, @domicilio, @descripcion)
END