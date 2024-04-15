CREATE DATABASE MiniCoreVentas
GO

USE MiniCoreVentas
GO

CREATE TABLE vendedores 
(
	idVendedor int not null Primary Key IDENTITY(1,1),
	NombreVendedor varchar(500) not null
)

CREATE TABLE Ventas
(
	idVenta int not null Primary Key IDENTITY(1,1),
	idVendedor int not null,
	ventas varchar(900) not null, 
	Monto int not null,
	fechaVenta Date not null, 
	CONSTRAINT FK_PersonOrder FOREIGN KEY (idVendedor) references vendedores(idVendedor)
)

INSERT INTO vendedores VALUES ('Darwin Hidrobo')
INSERT INTO vendedores VALUES ('Samantha Caicedo')
INSERT INTO vendedores VALUES ('Edwin Torres')
INSERT INTO vendedores VALUES ('Kate Dittmer')


SELECT * FROM vendedores

INSERT INTO Ventas VALUES (1, 'Xiaomi Redmi', 400, '2023-01-10')
INSERT INTO Ventas VALUES (1, 'Playstation 5', 600, '2023-01-10')
INSERT INTO Ventas VALUES (2, 'Laptop Asus', 900, '2023-01-10')
INSERT INTO Ventas VALUES (2, 'Iphone 14 pro max', 1400, '2023-01-10')

SELECT * FROM Ventas

SELECT a.NombreVendedor, sum(c.Monto) FROM Ventas c
INNER JOIN vendedores a ON c.idVendedor = a.idVendedor
WHERE fechaVenta = '2023-01-10'
GROUP BY a.NombreVendedor
