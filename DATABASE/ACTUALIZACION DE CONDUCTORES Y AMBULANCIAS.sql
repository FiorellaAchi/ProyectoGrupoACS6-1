CREATE TABLE ambulancias (
    codigo VARCHAR(50),
    marca VARCHAR(100),
    numero_placa VARCHAR(20),
    anio VARCHAR(4),
    id_conductor VARCHAR(50),
    PRIMARY KEY (codigo), -- Establecer el campo "codigo" como clave primaria
    FOREIGN KEY (id_conductor) REFERENCES conductor(id_conductor) -- Crear una clave foránea para conectar con la tabla "conductor"
);

Create Table conductor(
id_conductor varchar (50) primary key,
nombre varchar (80) null,
cedula varchar (10) not null,
telefono varchar (10) null,
licencia varchar (10) null,
direccion varchar (100) null,
unidad nvarchar(50) null,
diasLaborados int
);