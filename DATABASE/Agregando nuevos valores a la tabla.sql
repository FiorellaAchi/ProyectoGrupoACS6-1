USE [ProyectoAmbulancia1]
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_usuario]    Script Date: 31/07/2023 14:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[sp_listar_usuario]
as select *from usuario order by codigo

Insert into usuario (codigo, nombre, cedula, telefono, email, contrasena, tipo) 
values ('A0007', 'ronal', '0987452136', '0998877445', 'rena.ashton@gmail.com','ronal','2')
