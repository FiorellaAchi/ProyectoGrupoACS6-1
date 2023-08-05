USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_modificar_conductor]    Script Date: 05/08/2023 14:43:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_modificar_conductor]
@id varchar(50), @nombre varchar(80),@cedula varchar(10),@telefono varchar(10), @licencia varchar(2), @direccion varchar(100),@unidad nvarchar(50),@diasLaborados int
as
update conductor set nombre = @nombre, cedula = @cedula, telefono = @telefono, licencia = @licencia, direccion = @direccion, unidad = @unidad, diasLaborados = @diasLaborados where id_conductor = @id;
GO

