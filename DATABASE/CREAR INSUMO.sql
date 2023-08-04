USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_insumos]    Script Date: 04/08/2023 9:24:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_crear_insumos]
@codigo varchar(5),
@insumo varchar(80),
@fecha varchar(50),
@proveedor varchar(80),
@estado varchar(80) output
as
begin
	declare @codnuevo varchar(5), @codmax varchar(5)
	set @codmax = (select max(id_Insumos) from insumos)
	set @codmax = isnull(@codmax,'A0000')
	set @codnuevo = 'A'+RIGHT(RIGHT(@codmax,4)+10001,4)
	insert into insumos(id_Insumos, insumo, fecha, proveedor, estado)
	values(@codnuevo, @insumo, @fecha, @proveedor, @estado)
end