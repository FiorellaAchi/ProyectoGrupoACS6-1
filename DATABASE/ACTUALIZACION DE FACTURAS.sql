use ProyectoAmbulancia1
create table factura
(
codigo varchar (5),
cedula  varchar (10),
nombre varchar(50),
emision varchar(80),
telefono varchar (80),
domicilio varchar (80),
descripcion varchar (80)

)
go

create procedure sp_crear_factura
@codigo varchar(5),
@cedula varchar(10),
@nombre varchar(50),
@emision varchar(80),
@telefono varchar(80),
@domicilio varchar(80),
@descripcion varchar (80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(codigo) from usuario)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into factura(codigo,cedula, nombre, emision, telefono,domicilio, descripcion)
	values(@codnuevo,@cedula, @nombre, @emision, @telefono, @domicilio, @descripcion)
end

go

create proc sp_listar_factura
as select *from factura order by codigo
go

create procedure sp_modificar_factura
@codigo varchar(5), @cedula varchar(10), @nombre varchar(50), @emision varchar(80), @telefono varchar(80), @domicilio varchar(80), @descripcion varchar (80)
as
update factura set cedula = @cedula, nombre = @nombre, emision = @emision, telefono = @telefono, domicilio=@domicilio, descripcion=@descripcion where codigo = @codigo

go

create procedure sp_eliminar_factura
@codigo varchar(5) as
begin
	if exists(select * from factura where nombre = @codigo)
	begin
		delete from factura where nombre = @codigo;
		print 'factura con codigo: ' + @codigo + ' ha sido eliminada';
	end
	else
	begin
		print 'fatura con codigo:' + @codigo + ' no existe';
	end
end
