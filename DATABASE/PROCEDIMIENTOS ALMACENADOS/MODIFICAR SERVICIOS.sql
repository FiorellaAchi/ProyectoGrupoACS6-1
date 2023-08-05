USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_modificar_servicios]    Script Date: 05/08/2023 14:44:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_modificar_servicios]
@codigo varchar(5), @nombre varchar(80), @descripcion varchar(50), @precio varchar(80)
as
update servicios set nombre = @nombre, descripcion = @descripcion, precio = @precio where codigo = @codigo

GO

