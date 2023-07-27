GO
/****** Object:  StoredProcedure [dbo].[sp_check_user_type]    Script Date: 22/7/2023 4:08:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_check_user_type]
(
  @usuario VARCHAR(50),
  @password VARCHAR(50)
)
AS
BEGIN
  DECLARE @login BIT;
  DECLARE @tipo INT;

  SELECT @login = 1, @tipo = [tipo]
  FROM [dbo].[usuario]
  WHERE [nombre] = @usuario
  AND [contrasena] = @password;

  IF @login = 1
  BEGIN
    IF @tipo = 1
    BEGIN
      RETURN 1; -- Admin
    END
    ELSE
    BEGIN
      RETURN 0; -- Usuario normal
    END
  END

  RETURN -1; -- Usuario no encontrado
END;

GO


