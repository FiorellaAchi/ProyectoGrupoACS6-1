USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_factura]    Script Date: 04/08/2023 16:13:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_eliminar_factura] (
    @id_factura varchar(5)
)
AS
BEGIN
    DELETE FROM facturas
    WHERE id_Factura = @id_factura
END