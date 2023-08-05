USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 05/08/2023 14:42:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_login]
(
  @usuario VARCHAR(50),
  @password VARCHAR(50)
)
AS
BEGIN
  DECLARE @login BIT;

  SELECT @login = 1
  FROM [dbo].[usuario]
  WHERE [nombre] = @usuario
  AND [contrasena] = @password;

  RETURN @login;
END;

GO

