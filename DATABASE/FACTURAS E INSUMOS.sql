use ProyectoAmbulancia1
go

create table insumos
(
codigo varchar (5),
insumo  varchar (80),
fecha varchar(50),
proveedor varchar(80),
estado varchar (80)
)
go

create procedure sp_crear_insumos
@codigo varchar(5),
@insumo varchar(80),
@fecha varchar(50),
@proveedor varchar(80),
@estado varchar(80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from usuario)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into insumos(codigo,insumo, fecha, proveedor, estado)
	values(@codnuevo,@insumo, @fecha, @proveedor, @estado)
end

go

create proc sp_listar_insumos
as select *from insumos order by codigo
go

create procedure sp_modificar_insumos
@codigo varchar(5), @insumo varchar(80), @fecha varchar(50), @proveedor varchar(80), @estado varchar(80)
as
update insumos set insumo = @insumo, fecha = @fecha, proveedor = @proveedor, estado = @estado where codigo = @codigo

go

create procedure sp_eliminar_insumos
@insumo varchar(80) as
begin
	if exists(select * from insumos where insumo = @insumo)
	begin
		delete from insumos where insumo = @insumo;
		print 'El insumo ' + @insumo + ' ha sido eliminado';
	end
	else
	begin
		print 'El insumo ' + @insumo + ' no existe';
	end
end

go

--test creacion de insumos (1 by one)
exec sp_crear_insumos 1, 'vendajes', '02-03-2023', 'Jaime Rojas', 'nuevo';
exec sp_listar_insumos;
exec sp_eliminar_insumos 'vendajes';


create table factura
(
codigo varchar (5),
cedula  varchar (10),
nombre varchar(50),
emision varchar(80),
telefono varchar (80),
domicilio varchar (80)
)
go

create procedure sp_crear_factura
@codigo varchar(5),
@cedula varchar(10),
@nombre varchar(50),
@emision varchar(80),
@telefono varchar(80),
@domicilio varchar(80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from usuario)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into factura(codigo,cedula, nombre, emision, telefono,domicilio)
	values(@codnuevo,@cedula, @nombre, @emision, @telefono, @domicilio)
end

go

create proc sp_listar_factura
as select *from factura order by codigo
go

create procedure sp_modificar_factura
@codigo varchar(5), @cedula varchar(10), @nombre varchar(50), @emision varchar(80), @telefono varchar(80), @domicilio varchar(80)
as
update factura set cedula = @cedula, nombre = @nombre, emision = @emision, telefono = @telefono, domicilio=@domicilio where codigo = @codigo

go

create procedure sp_eliminar_factura
@nombre varchar(80) as
begin
	if exists(select * from factura where nombre = @nombre)
	begin
		delete from factura where nombre = @nombre;
		print 'factura de ' + @nombre + ' ha sido eliminado';
	end
	else
	begin
		print 'fatura de ' + @nombre + ' no existe';
	end
end

go

--test creacion de factura (1 by one)
exec sp_crear_factura 1, '0953374436','Jose', '02-03-2023', '0925452365', 'sauces 3';
exec sp_listar_factura;
exec sp_eliminar_factura 'Jose';