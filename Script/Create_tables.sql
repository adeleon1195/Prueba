USE PRUEBA;

CREATE TABLE Empresa
( 
	Id_empresa int NOT NULL IDENTITY (1,1),
	Nombre varchar (100),
	Pais varchar (100)

)

CREATE TABLE Sucursales
( 
	Id_sucursales int NOT NULL IDENTITY (1,1),
	Nombre varchar (100),
	Direcci�n varchar (100),
	Telefono int,

)

CREATE TABLE Colaboradores
( 
	Id_colaboradores int NOT NULL IDENTITY (1,1),
	Nombre varchar (100),
	CUI int

)