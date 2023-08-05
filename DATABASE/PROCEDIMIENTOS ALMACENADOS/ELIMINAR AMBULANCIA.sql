USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_eliminar_ambulancia]    Script Date: 05/08/2023 14:40:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_eliminar_ambulancia]
    @codigo VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT * FROM ambulancias WHERE codigo = @codigo)
    BEGIN
        DELETE FROM ambulancias WHERE codigo = @codigo;
        PRINT 'La ambulancia ha sido eliminada';
    END
    ELSE
    BEGIN
        PRINT 'La ambulancia no existe';
    END
END
GO

