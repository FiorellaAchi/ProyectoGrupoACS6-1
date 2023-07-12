use ProyectoAmbulancia1
go

create table servicios
(
codigo varchar (5),
nombre  varchar (80),
descripcion varchar(50),
precio varchar(80)
)
go

create procedure sp_crear_servicios
@codigo varchar(5),
@nombre varchar(80),
@descripcion varchar(50),
@precio varchar(80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from servicios)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into servicios(codigo,nombre, descripcion, precio)
	values(@codnuevo,@nombre, @descripcion, @precio)
end

go

create proc sp_listar_servicios
as select *from servicios order by codigo
go

create procedure sp_modificar_servicios
@codigo varchar(5), @nombre varchar(80), @descripcion varchar(50), @precio varchar(80)
as
update servicios set nombre = @nombre, descripcion = @descripcion, precio = @precio where codigo = @codigo

go

create procedure sp_eliminar_servicios
@nombre varchar(80) as
begin
	if exists(select * from servicios where nombre = @nombre)
	begin
		delete from servicios where nombre = @nombre;
		print 'El servicio ' + @nombre + ' ha sido eliminado';
	end
	else
	begin
		print 'El servicio ' + @nombre + ' no existe';
	end
end

go

--test creacion de servicios(1 by one)
exec sp_crear_servicios 1, 'jose', 'traslado', '$59';
exec sp_listar_servicios;
exec sp_eliminar_servicios 'jose';