USE [ProyectoAmbulancia1]
GO

/****** Object:  StoredProcedure [dbo].[sp_crear_conductor]    Script Date: 05/08/2023 14:36:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_crear_conductor] 
@id VARCHAR (50), @nombre varchar(80),@cedula varchar(10),@telefono varchar(10), @licencia varchar(2), @direccion varchar(100),@unidad nvarchar(50),@diasLaborados int
as
insert into conductor values (@id,@nombre,@cedula,@telefono,@licencia,@direccion,@unidad,@diasLaborados);
GO


