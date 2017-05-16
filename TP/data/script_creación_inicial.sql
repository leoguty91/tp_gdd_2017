/* Seleccion de la bd */
USE GD1C2017;
GO

/* Eliminacion de Indices */
IF EXISTS (SELECT NAME FROM sys.indexes WHERE NAME = N'IX_Cliente')  
	DROP INDEX IX_Cliente ON GGDP.Cliente;
IF EXISTS (SELECT NAME FROM sys.indexes WHERE NAME = N'IX_Chofer')  
	DROP INDEX IX_Chofer ON GGDP.Chofer;
GO

/* Eliminacion de Triggers */
/*
IF OBJECT_ID ('GGDP.T_Cliente_telefono_unico','TR') IS NOT NULL
   DROP TRIGGER GGDP.T_Cliente_telefono_unico;
GO
*/

/* Eliminacion de Tablas */
IF OBJECT_ID('GGDP.Cliente') IS NOT NULL
    DROP TABLE GGDP.Cliente;
IF OBJECT_ID('GGDP.Chofer') IS NOT NULL
    DROP TABLE GGDP.Chofer;
GO

/* Eliminacion del Eschema Principal */
IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'GGDP')
    DROP SCHEMA GGDP
GO

/* Creacion del Esquema Principal */
CREATE SCHEMA GGDP AUTHORIZATION gd;
GO

/* Creacion de las Tablas */
CREATE TABLE GGDP.Cliente(
    clie_id INT IDENTITY PRIMARY KEY,
    clie_nombre VARCHAR(225) NOT NULL,
	clie_apellido VARCHAR(255) NOT NULL,
	clie_dni NUMERIC(18, 0) NOT NULL,
	clie_mail VARCHAR(255),
	clie_telefono NUMERIC(18, 0) NOT NULL UNIQUE,
	clie_direccion VARCHAR(255) NOT NULL,
	clie_codigo_postal VARCHAR(8) NOT NULL,
	clie_fecha_nacimiento datetime NOT NULL,
    clie_habilitado BIT,
	clie_usuario INT NOT NULL);

CREATE TABLE GGDP.Chofer(
    chof_id INT IDENTITY PRIMARY KEY,
    chof_nombre VARCHAR(225) NOT NULL,
	chof_apellido VARCHAR(255) NOT NULL,
	chof_dni NUMERIC(18, 0) NOT NULL,
	chof_mail VARCHAR(50) NOT NULL,
	chof_telefono NUMERIC(18, 0) NOT NULL,
	chof_direccion VARCHAR(255) NOT NULL,
	chof_codigo_postal VARCHAR(8) NOT NULL,
	chof_fecha_nacimiento datetime NOT NULL,
    chof_habilitado BIT,
	chof_usuario INT NOT NULL);
GO

/* Creacion de los FK */
/* TODO FALTA LA TABLA CLIENTE
ALTER TABLE GGDP.Cliente
	ADD CONSTRAINT clie_usuario
	FOREIGN KEY (usua_id) REFERENCES GGDP.Usuario

ALTER TABLE GGDP.Chofer
	ADD CONSTRAINT chof_usuario
	FOREIGN KEY (usua_id) REFERENCES GGDP.Usuario
GO
*/

/* Creacion de Indices */
CREATE INDEX IX_Cliente ON GGDP.Cliente (clie_nombre, clie_apellido, clie_dni)
CREATE INDEX IX_Chofer ON GGDP.Chofer (chof_nombre, chof_apellido, chof_dni)
GO

/* Insercion de datos */
INSERT INTO GGDP.Cliente(clie_dni, clie_nombre, clie_apellido, clie_telefono, clie_direccion, clie_codigo_postal, clie_mail, clie_fecha_nacimiento, clie_habilitado, clie_usuario)
SELECT DISTINCT([Cliente_Dni]), [Cliente_Nombre], [Cliente_Apellido], [Cliente_Telefono], [Cliente_Direccion], 1, [Cliente_Mail], [Cliente_Fecha_Nac], 1, 1 FROM [gd_esquema].[Maestra]
GO
/* TODO FALTA EL FK REAL DE CLIE_USUARIO */
INSERT INTO GGDP.Chofer(chof_mail, chof_nombre, chof_apellido, chof_dni, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario)
SELECT DISTINCT ([Chofer_Mail]), [Chofer_Nombre], [Chofer_Apellido], [Chofer_Dni], [Chofer_Telefono], [Chofer_Direccion], 1, [Chofer_Fecha_Nac], 1, 1 FROM [gd_esquema].[Maestra]
GO
/* TODO FALTA EL FK REAL DE CHOF_USUARIO */

/* Creacion de Triggers */
/*
CREATE TRIGGER GGDP.T_Cliente_telefono_unico ON GGDP.Cliente INSTEAD OF INSERT
AS IF EXISTS (SELECT * FROM GGDP.Cliente c, inserted i WHERE c.clie_telefono = i.clie_telefono)
BEGIN
	PRINT('El telefono ya existe');
	ROLLBACK TRANSACTION;
	RETURN;
END;
GO
*/