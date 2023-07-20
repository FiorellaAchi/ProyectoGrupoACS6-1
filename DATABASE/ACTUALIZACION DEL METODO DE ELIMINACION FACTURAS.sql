USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_factura]    Script Date: 20/07/2023 17:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[sp_eliminar_factura]
@codigo varchar(5) as
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT * FROM factura WHERE nombre = @codigo)
    BEGIN
        DELETE FROM factura WHERE nombre = @codigo;
        PRINT 'Factura con codigo: ' + @codigo + ' ha sido eliminada';
    END
    ELSE
    BEGIN
        PRINT 'Factura con codigo: ' + @codigo + ' no existe';
    END
END
