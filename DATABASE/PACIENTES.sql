use ProyectoAmbulancia1
go

create table pacientes
(
codigo varchar (5),
nombre  varchar (80),
apellido varchar(50),
edad varchar(80),
fechaIngreso varchar (80),
direccion varchar(50),
tutor varchar(80)
)
go

create procedure sp_crear_pacientes
@codigo varchar(5),
@nombre varchar(80),
@apellido varchar(50),
@edad varchar(80),
@fechaIngreso varchar(80),
@direccion varchar(80),
@tutor varchar(80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from pacientes)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into pacientes(codigo,nombre, apellido, edad, fechaIngreso,direccion,tutor)
	values(@codnuevo,@nombre, @apellido, @edad, @fechaIngreso,@direccion,@tutor)
end

go

create proc sp_listar_pacientes
as select *from pacientes order by codigo
go

create procedure sp_modificar_pacientes
@codigo varchar(5), @nombre varchar(80), @apellido varchar(50), @edad varchar(80), @fechaIngreso varchar(80), @direccion varchar(80), @tutor varchar(80)
as
update pacientes set nombre = @nombre, apellido = @apellido, edad = @edad, fechaIngreso = @fechaIngreso, direccion=@direccion, tutor=@tutor where codigo = @codigo

go

create procedure sp_eliminar_pacientes
@nombre varchar(80) as
begin
	if exists(select * from pacientes where nombre = @nombre)
	begin
		delete from pacientes where nombre = @nombre;
		print 'El paciente ' + @nombre + ' ha sido eliminado';
	end
	else
	begin
		print 'El paciente ' + @nombre + ' no existe';
	end
end

go

--test creacion de insumos (1 by one)
exec sp_crear_pacientes 1, 'jose', 'gonza', '19', '12-04-04','sauces','pepe';
exec sp_listar_pacientes;
exec sp_eliminar_pacientes 'jose';