-- Actualizar contraseña y tipo para todos los registros en la tabla "usuario"
UPDATE [ProyectoAmbulancia1].[dbo].[usuario]
SET [contrasena] = 'rer',
    [tipo] = '0'
WHERE nombre = 'Loro';