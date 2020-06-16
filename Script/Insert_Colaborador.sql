USE PRUEBA

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ColaboradorInsert (
	@Nombre varchar (100),
	@CUI int,
	@MENSAJE varchar(100) OUTPUT )
AS
BEGIN

	SET NOCOUNT ON;

	INSERT INTO Colaboradores (Nombre, CUI)
	VALUES (@Nombre, @CUI)
	SET @MENSAJE='Registrado Ok'

END
