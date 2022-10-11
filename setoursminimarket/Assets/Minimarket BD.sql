CREATE DATABASE Minimarket
GO

USE Minimarket
GO

CREATE TABLE TipoDeDocumento (
	codigo int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	descripcion varchar(20)
)

CREATE TABLE Producto(
	codigo int IDENTITY(1, 1) PRIMARY KEY,
	nombre varchar(100) NOT NULL,
	tipo int NOT NULL FOREIGN KEY REFERENCES TipoDeDocumento(codigo),
	stock int,
	precio decimal(14, 2)
)

CREATE TABLE Cliente (
	docIdentidad varchar(8) NOT NULL PRIMARY KEY,
	nombreCompleto varchar(80) NOT NULL
)

CREATE TABLE Sucursal (
	codigo int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	direccion varchar(100)
)

CREATE TABLE Vendedor (
	docIdentidad varchar(8) NOT NULL PRIMARY KEY,
	nombreCompleto varchar(80) NOT NULL,
	sucursal int NOT NULL FOREIGN KEY REFERENCES Sucursal(codigo)
)

CREATE TABLE Comprobante (
	id int IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	tipo int NOT NULL FOREIGN KEY REFERENCES TipoDeDocumento(codigo),
	cliente varchar(8) FOREIGN KEY REFERENCES Cliente(docIdentidad),
	vendedor varchar(8) FOREIGN KEY REFERENCES Vendedor(docIdentidad),
	sucursal int FOREIGN KEY REFERENCES Sucursal(codigo),
	Neto numeric(14, 2),
	IGV numeric(14, 2),
	Total numeric(14, 2)
)

CREATE TABLE DetalleDeComprobante (
	idComprobante int NOT NULL,
	item int IDENTITY(1, 1) NOT NULL,
	producto int FOREIGN KEY REFERENCES Producto(codigo),
	cantidad numeric(14,2),
	precio numeric(14, 2),
	PRIMARY KEY(idComprobante, item)
)

INSERT INTO TipoDeDocumento VALUES ('Boleta'), ('Factura')
INSERT INTO Sucursal VALUES ('Los Alamos X'), ('Lima District')
INSERT INTO Cliente VALUES ('77777777', 'Cliente test')
INSERT INTO Vendedor VALUES ('99999999', 'Vendedor test', 1)
INSERT INTO TipoDeDocumento VALUES ('Boleta'), ('Factura')