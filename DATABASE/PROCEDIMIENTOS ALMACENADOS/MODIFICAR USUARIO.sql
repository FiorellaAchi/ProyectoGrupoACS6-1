USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_modificar_usuario]    Script Date: 05/08/2023 14:45:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_modificar_usuario]
@codigo varchar(5), @nombre varchar(80), @cedula varchar(10), @telefono varchar(10), @email varchar(255), @contrasena varchar (255)
as
update usuario set nombre = @nombre, cedula = @cedula, telefono = @telefono, email = @email, contrasena = @contrasena where codigo = @codigo
GO

