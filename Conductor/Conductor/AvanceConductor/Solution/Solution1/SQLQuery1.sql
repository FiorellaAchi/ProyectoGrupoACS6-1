
USE CONDUCTOR_DB;
CREATE TABLE Conductores (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100),
    Cedula VARCHAR(15),
    Celular VARCHAR(15),
    Licencia VARCHAR(20),
    Direccion VARCHAR(100),
    UnidadCargo VARCHAR(50),
    DiasLaborados INT
);