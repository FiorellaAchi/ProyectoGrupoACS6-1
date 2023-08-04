create table servicios(
codigo varchar(5) primary key not null, 
nombre varchar(5) null,
descripcion varchar(50) null,
precio varchar(80) null
);

ALTER TABLE servicios
ALTER COLUMN nombre varchar(80) NULL;
