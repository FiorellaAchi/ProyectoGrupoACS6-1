USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_factura]    Script Date: 05/08/2023 14:39:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminar_factura] (
    @id_factura varchar(5)
)
AS
BEGIN
    DELETE FROM facturas
    WHERE id_Factura = @id_factura
END
GO

