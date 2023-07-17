USE ProyectoAmbulancia1
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
	set @codmax = (select max(codigo) from insumos)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into insumos(codigo, insumo, fecha, proveedor, estado)
	values(@codnuevo, @insumo, @fecha, @proveedor, @estado)
end

