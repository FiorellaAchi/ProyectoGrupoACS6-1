USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_pacientes]    Script Date: 04/08/2023 9:30:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER procedure [dbo].[sp_crear_pacientes]
@codigo varchar(5),
@nombre varchar(80),
@apellido varchar(50),
@edad varchar(80),
@fechaIngreso varchar(80),
@direccion varchar(80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(id_Paciente) from Pacientes)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into Pacientes(id_Paciente,nombre, apellido, edad, fechaIngreso,direccion)
	values(@codnuevo,@nombre, @apellido, @edad, @fechaIngreso,@direccion)
end

