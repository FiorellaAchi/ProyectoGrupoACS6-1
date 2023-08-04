CREATE TABLE facturas (
    id_Factura varchar(5) PRIMARY KEY,
    cedula varchar(10),
    id_conductor varchar(50),
    codigo_ambulancia varchar(50),
    id_Insumo varchar (80),
    codigo_servicio varchar(5),
    emision varchar(80),
    domicilio varchar(80),
    descripcion varchar(80),
    subtotal DECIMAL(10, 2),
    total DECIMAL(10, 2),
    -- Otras columnas relacionadas con los registros
    FOREIGN KEY (id_conductor) REFERENCES conductor(id_conductor),
    FOREIGN KEY (codigo_ambulancia) REFERENCES ambulancias(codigo),
    FOREIGN KEY (id_Insumo) REFERENCES insumos(id_Insumos),
    FOREIGN KEY (codigo_servicio) REFERENCES servicios(codigo)
);
