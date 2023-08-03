USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_usuario]    Script Date: 01/08/2023 10:11:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_crear_usuario]
@codigo varchar(5),
@nombre varchar(80),
@cedula varchar(10),
@telefono varchar(10),
@email varchar(255), 
@contrasena varchar (255),
@tipo varchar (2) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from usuario)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into usuario(codigo,nombre, cedula, telefono, email, contrasena, tipo)
	values(@codnuevo,@nombre, @cedula, @telefono, @email, @contrasena, @tipo)
end
