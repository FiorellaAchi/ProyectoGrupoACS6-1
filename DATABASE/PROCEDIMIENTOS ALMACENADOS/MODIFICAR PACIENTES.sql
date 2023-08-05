USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_modificar_pacientes]    Script Date: 05/08/2023 14:44:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_modificar_pacientes]
@codigo varchar(5), @nombre varchar(80), @apellido varchar(50), @edad varchar(80), @fechaIngreso varchar(80), @direccion varchar(80)
as
update pacientes set nombre = @nombre, apellido = @apellido, edad = @edad, fechaIngreso = @fechaIngreso, direccion=@direccion where id_Paciente = @codigo
GO

