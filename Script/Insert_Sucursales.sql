USE PRUEBA

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE SucursalInsert (
	@Nombre varchar (100),
	@Direccion varchar (100),	
	@Telefono int,
	@MENSAJE varchar(100) OUTPUT )
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Sucursales (Nombre, Dirección, Telefono)
	VALUES (@Nombre, @Direccion, @Telefono)
	SET @MENSAJE='Registrado Ok'

END

