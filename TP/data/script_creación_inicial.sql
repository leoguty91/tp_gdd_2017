/* Seleccion de la bd */
USE GD1C2017;
GO

/* Eliminacion de Indices */
IF EXISTS (SELECT NAME FROM sys.indexes WHERE NAME = N'IX_Cliente')  
	DROP INDEX IX_Cliente ON GGDP.Cliente;
IF EXISTS (SELECT NAME FROM sys.indexes WHERE NAME = N'IX_Automovil')  
	DROP INDEX IX_Automovil ON GGDP.Automovil;
IF EXISTS (SELECT NAME FROM sys.indexes WHERE NAME = N'IX_Chofer')  
	DROP INDEX IX_Chofer ON GGDP.Chofer;
GO

/* Eliminacion de Functions */
IF (OBJECT_ID ('GGDP.fu_existe_usuario') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_usuario
GO
IF (OBJECT_ID ('GGDP.fu_existe_cliente') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_cliente
GO

/* Eliminacion de Triggers */
/*
IF OBJECT_ID ('GGDP.tr_cliente_telefono_unico','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_cliente_telefono_unico;
GO
*/

/* Eliminacion de Store Procedures */
IF (OBJECT_ID ('GGDP.sp_login') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_login
IF (OBJECT_ID ('GGDP.sp_login_fallido') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_login_fallido
IF (OBJECT_ID ('GGDP.sp_obtener_roles') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_roles
IF (OBJECT_ID ('GGDP.sp_obtener_roles_usuario') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_roles_usuario
IF (OBJECT_ID ('GGDP.sp_obtener_funcionalidades') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_funcionalidades
IF OBJECT_ID ('GGDP.sp_alta_cliente') IS NOT NULL
    DROP PROCEDURE GGDP.sp_alta_cliente
IF OBJECT_ID ('GGDP.sp_baja_cliente') IS NOT NULL
    DROP PROCEDURE GGDP.sp_baja_cliente
IF OBJECT_ID ('GGDP.modificacion_cliente') IS NOT NULL
    DROP PROCEDURE GGDP.sp_modificacion_cliente
GO

/* Eliminacion de Tablas */
IF OBJECT_ID('GGDP.FacturaPorViaje') IS NOT NULL
    DROP TABLE GGDP.FacturaPorViaje;
IF OBJECT_ID('GGDP.RendicionPorViaje') IS NOT NULL
    DROP TABLE GGDP.RendicionPorViaje;
IF OBJECT_ID('GGDP.RolPorUsuario') IS NOT NULL
    DROP TABLE GGDP.RolPorUsuario;
IF OBJECT_ID('GGDP.RolPorFuncionalidad') IS NOT NULL
    DROP TABLE GGDP.RolPorFuncionalidad;
IF OBJECT_ID('GGDP.Rendicion') IS NOT NULL
    DROP TABLE GGDP.Rendicion;
IF OBJECT_ID('GGDP.Viaje') IS NOT NULL
    DROP TABLE GGDP.Viaje;
IF OBJECT_ID('GGDP.Turno') IS NOT NULL
    DROP TABLE GGDP.Turno;
IF OBJECT_ID('GGDP.Factura') IS NOT NULL
    DROP TABLE GGDP.Factura;
IF OBJECT_ID('GGDP.Cliente') IS NOT NULL
    DROP TABLE GGDP.Cliente;
IF OBJECT_ID('GGDP.Automovil') IS NOT NULL
    DROP TABLE GGDP.Automovil;
IF OBJECT_ID('GGDP.Marca') IS NOT NULL
    DROP TABLE GGDP.Marca;
IF OBJECT_ID('GGDP.Chofer') IS NOT NULL
    DROP TABLE GGDP.Chofer;
IF OBJECT_ID('GGDP.Funcionalidad') IS NOT NULL
    DROP TABLE GGDP.Funcionalidad;
IF OBJECT_ID('GGDP.Rol') IS NOT NULL
    DROP TABLE GGDP.Rol;
IF OBJECT_ID('GGDP.Usuario') IS NOT NULL
    DROP TABLE GGDP.Usuario;
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
	clie_usuario INT NOT NULL
);

CREATE TABLE GGDP.Automovil(
	auto_id INT IDENTITY PRIMARY KEY,
	auto_marca INT,
	auto_modelo VARCHAR(255),
	auto_patente VARCHAR(10) UNIQUE,
	auto_turno INT,
	auto_chofer INT,
	auto_habilitado BIT
);

CREATE TABLE GGDP.Marca(
	marc_id INT IDENTITY PRIMARY KEY,
	marc_nombre VARCHAR(255)
);

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
	chof_usuario INT NOT NULL
);

CREATE TABLE GGDP.Viaje(
    viaj_id INT IDENTITY PRIMARY KEY NOT NULL,
	viaj_automovil int not null,
	viaj_chofer int not null, 
	viaj_turno int not null,
	viaj_cantidad_kilometros numeric(18,0) not null,
	viaj_fecha_inicio datetime not null,
	viaj_fecha_fin datetime not null,
	viaj_cliente int not null
);

CREATE TABLE GGDP.Rendicion(
	rend_id INT IDENTITY PRIMARY KEY NOT NULL,
	rend_chofer int not null ,
	rend_turno int not null,
	rend_importe numeric(18,2) not null,
	rend_viaje int not null
);
	
CREATE TABLE GGDP.Turno (
    turn_id INT IDENTITY PRIMARY KEY NOT NULL,
	turn_hora_inicio numeric(18,0) not null,
	turn_hora_fin numeric(18,0) not null,
	turn_descripcion varchar(255) not null,
	turn_valor_kilometro numeric(18,2) not null,
	turn_habilitado BIT
);

CREATE TABLE GGDP.Factura (
    fact_id INT IDENTITY PRIMARY KEY NOT NULL,
	fact_fecha_inicio datetime,
	fact_fecha_fin datetime,
	fact_cliente int,
	fact_importe decimal (12,2),
	fact_viajes_facturados numeric(18,0)
);

CREATE TABLE GGDP.FacturaPorViaje (
    fxv_factura INT NOT NULL,
    fxv_viaje INT NOT NULL,
);

CREATE TABLE GGDP.RendicionPorViaje (
    rxv_rendicion INT NOT NULL,
    rxv_viaje INT NOT NULL,
);

CREATE TABLE GGDP.Rol (
	rol_id INT IDENTITY PRIMARY KEY NOT NULL,
	rol_nombre VARCHAR(255) NOT NULL,
	rol_habilitado BIT NOT NULL,
);

CREATE TABLE GGDP.RolPorUsuario (
	rxu_rol INT NOT NULL, 
	rxu_usuario INT NOT NULL,
	CONSTRAINT pk_rol_por_usuario PRIMARY KEY CLUSTERED (rxu_rol ASC, rxu_usuario ASC)
);

CREATE TABLE GGDP.RolPorFuncionalidad (
	rxf_rol INT NOT NULL,
	rxf_funcionalidad INT NOT NULL
);

CREATE TABLE GGDP.Funcionalidad (
	func_id INT IDENTITY PRIMARY KEY NOT NULL,
	func_nombre VARCHAR(255) NOT NULL,
);

CREATE TABLE GGDP.Usuario(
	usua_id INT IDENTITY PRIMARY KEY NOT NULL,
	usua_usuario VARCHAR(255) NOT NULL,
	usua_password VARCHAR(255) NOT NULL,
	usua_intentos INT NOT NULL,
	usua_habilitado BIT NOT NULL
);
GO

/* Creacion de los FK */
/*
ALTER TABLE GGDP.Cliente
	ADD CONSTRAINT fk_clie_usuario FOREIGN KEY (clie_usuario) REFERENCES GGDP.Usuario(usua_id)
*/
ALTER TABLE GGDP.Automovil
	ADD CONSTRAINT fk_auto_chofer FOREIGN KEY (auto_chofer) REFERENCES GGDP.Chofer(chof_id)

ALTER TABLE GGDP.Viaje
	ADD CONSTRAINT fk_viaj_chofer FOREIGN KEY (viaj_chofer) REFERENCES GGDP.Chofer(chof_id)
ALTER TABLE GGDP.Viaje
    ADD	CONSTRAINT fk_viaj_automovil FOREIGN KEY (viaj_automovil) REFERENCES GGDP.Automovil(auto_id)
ALTER TABLE GGDP.Viaje
    ADD CONSTRAINT fk_viaj_turno FOREIGN KEY (viaj_turno) REFERENCES GGDP.Turno(turn_id)
ALTER TABLE GGDP.Viaje
    ADD	CONSTRAINT fk_viaj_cliente FOREIGN KEY (viaj_cliente) REFERENCES GGDP.Cliente(clie_id)

ALTER TABLE GGDP.Rendicion
	ADD CONSTRAINT fk_rend_chofer FOREIGN KEY (rend_chofer) REFERENCES GGDP.Cliente(clie_id)
ALTER TABLE GGDP.Rendicion
	ADD CONSTRAINT fk_rend_turno FOREIGN KEY (rend_turno) REFERENCES GGDP.Turno(turn_id)
ALTER TABLE GGDP.Rendicion
	ADD CONSTRAINT fk_rend_viaje FOREIGN KEY (rend_viaje) REFERENCES GGDP.Viaje(viaj_id)

ALTER TABLE GGDP.Factura
	ADD CONSTRAINT fk_fact_cliente FOREIGN KEY (fact_cliente) REFERENCES GGDP.Cliente(clie_id)
	
ALTER TABLE GGDP.FacturaPorViaje
	ADD CONSTRAINT fk_fxv_factura FOREIGN KEY (fxv_factura) REFERENCES GGDP.Factura(fact_id)
ALTER TABLE GGDP.FacturaPorViaje
	ADD CONSTRAINT fk_fxv_viaje FOREIGN KEY (fxv_viaje) REFERENCES GGDP.Viaje(viaj_id)
	
ALTER TABLE GGDP.RendicionPorViaje
	ADD CONSTRAINT fk_rxv_rendicion FOREIGN KEY (rxv_rendicion) REFERENCES GGDP.Rendicion(rend_id)
ALTER TABLE GGDP.RendicionPorViaje
	ADD CONSTRAINT fk_rxv_viaje FOREIGN KEY (rxv_viaje) REFERENCES GGDP.Viaje(viaj_id)

ALTER TABLE GGDP.RolPorUsuario
	ADD CONSTRAINT fk_rxu_usuario  FOREIGN KEY (rxu_usuario) REFERENCES GGDP.Usuario(usua_id) 
ALTER TABLE GGDP.RolPorUsuario
	ADD CONSTRAINT fk_rxu_rol  FOREIGN KEY (rxu_rol) REFERENCES GGDP.Rol(rol_id) 

ALTER TABLE GGDP.RolPorFuncionalidad
	ADD CONSTRAINT fk_rxf_rol FOREIGN KEY (rxf_rol) REFERENCES GGDP.Rol(rol_id)
ALTER TABLE GGDP.RolPorFuncionalidad
	ADD CONSTRAINT fk_rxf_funcionalidad FOREIGN KEY (rxf_funcionalidad) REFERENCES GGDP.Funcionalidad(func_id)
/*
ALTER TABLE GGDP.Chofer
	ADD CONSTRAINT fk_chof_usuario FOREIGN KEY (chof_usuario) REFERENCES GGDP.Usuario(usua_id)
*/
GO

/* Creacion de Indices */
CREATE INDEX IX_Cliente ON GGDP.Cliente (clie_nombre, clie_apellido, clie_dni)
CREATE INDEX IX_Automovil ON GGDP.Automovil(auto_marca, auto_modelo, auto_patente, auto_chofer)
CREATE INDEX IX_Chofer ON GGDP.Chofer (chof_nombre, chof_apellido, chof_dni)
CREATE INDEX IX_Marca ON GGDP.Marca(marc_nombre)
GO

/* Insercion de datos */
-- TODO Falta clie_usuario
INSERT INTO GGDP.Cliente(clie_dni, clie_nombre, clie_apellido, clie_telefono, clie_direccion, clie_codigo_postal, clie_mail, clie_fecha_nacimiento, clie_habilitado, clie_usuario)
SELECT DISTINCT(Cliente_Dni), Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Direccion, 1, Cliente_Mail, Cliente_Fecha_Nac, 1, 1 FROM [gd_esquema].[Maestra]
GO

-- TODO Falta chof_usuario
INSERT INTO GGDP.Chofer(chof_mail, chof_nombre, chof_apellido, chof_dni, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario)
SELECT DISTINCT (Chofer_Mail), Chofer_Nombre, Chofer_Apellido, Chofer_Dni, Chofer_Telefono, Chofer_Direccion, 1, Chofer_Fecha_Nac, 1, 1 FROM [gd_esquema].[Maestra]
GO

INSERT INTO GGDP.Marca(marc_nombre)
SELECT DISTINCT Auto_Marca FROM [gd_esquema].[Maestra]

-- TODO Falta auto_turno
INSERT INTO GGDP.Automovil(auto_patente, auto_marca, auto_modelo, auto_turno, auto_chofer, auto_habilitado)
SELECT DISTINCT ([Auto_Patente]), GGDP.Marca.marc_id, [Auto_Modelo], 1, GGDP.Chofer.chof_id, 1
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Marca ON gd_esquema.Maestra.Auto_Marca = GGDP.Marca.marc_nombre
	JOIN GGDP.Chofer ON gd_esquema.Maestra.Chofer_Dni = GGDP.Chofer.chof_dni 
GO

-- Insercion usuario admin
DECLARE @usua_password VARCHAR(255);
SELECT @usua_password = HASHBYTES('SHA2_256', 'w23e');

INSERT INTO GGDP.Usuario(usua_usuario, usua_password, usua_intentos, usua_habilitado)
VALUES ('admin', @usua_password, 0, 1)
GO

-- TODO Esta tabla tiene un error de sintaxis, REVISAR
/*
INSERT INTO GGDP.RolPorUsuario(rxu_rol, rxu_usuario)
SELECT DISTINCT ([Rxu_Rol], [Rxu_Usuario])
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Rol ON gd_esquema.Maestra.Rxu_rol = GGDP.Rol.rol_nombre
	JOIN GGDP.Usuario ON gd_esquema.Maestra.Usuario = GGDP.Usuario.usua_usuario
*/	


/* Creacion de Functions*/
CREATE FUNCTION GGDP.fu_existe_usuario(@usuario VARCHAR(255)) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.Usuario WHERE usua_usuario = @usuario)
		RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION GGDP.fu_existe_cliente(@cliente_id INT) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.Cliente WHERE clie_id = @cliente_id)
		RETURN 1
	RETURN 0
END
GO

/* Creacion de Triggers */
/*
CREATE TRIGGER GGDP.tr_cliente_telefono_unico ON GGDP.Cliente INSTEAD OF INSERT
AS IF EXISTS (SELECT * FROM GGDP.Cliente c, inserted i WHERE c.clie_telefono = i.clie_telefono)
BEGIN
	PRINT('El telefono ya existe');
	ROLLBACK TRANSACTION;
	RETURN;
END;
GO
*/

/* Creacion de Store Procedures */
CREATE PROCEDURE GGDP.sp_login_fallido(@usuario VARCHAR(255)) AS BEGIN
	UPDATE GGDP.Usuario
		SET usua_intentos = usua_intentos + 1
		WHERE usua_usuario = @usuario
	UPDATE GGDP.Usuario
		SET usua_habilitado = 0
		WHERE usua_usuario = @usuario
		AND usua_intentos = 3
END
GO

CREATE PROCEDURE GGDP.sp_login(@usuario VARCHAR(255), @password VARCHAR(255)) AS BEGIN
	DECLARE @usuario_login_ok BIT
	IF GGDP.fu_existe_usuario(@usuario) = 0 BEGIN
		RETURN -1
	END

	SELECT @usuario_login_ok=COUNT(*) FROM GGDP.Usuario
		WHERE usua_usuario = @usuario
		AND usua_password = HASHBYTES('SHA2_256', @password)

	IF @usuario_login_ok = 0 BEGIN
		EXEC GGDP.sp_login_fallido @usuario
		RETURN -1
	END
	ELSE BEGIN
		UPDATE GGDP.Usuario SET usua_intentos = 0 WHERE usua_usuario = @usuario
		SELECT usua_id, usua_usuario, usua_habilitado FROM GGDP.Usuario WHERE usua_usuario = @usuario
	END
END
GO

CREATE PROCEDURE GGDP.sp_obtener_roles AS BEGIN
	SELECT rol_nombre, rol_habilitado, rol_id
	FROM GGDP.Rol
	JOIN GGDP.RolPorUsuario ON rol_id = rxu_rol
END
GO

CREATE PROCEDURE GGDP.sp_obtener_roles_usuario(@usuario VARCHAR(255)) AS BEGIN
	SELECT rol_nombre, rol_habilitado, rol_id
	FROM GGDP.Rol
	JOIN GGDP.RolPorUsuario ON rol_id = rxu_rol
	WHERE rxu_usuario = @usuario AND rol_habilitado = 1
END
GO

CREATE PROCEDURE GGDP.sp_obtener_funcionalidades(@rol VARCHAR(255)) AS BEGIN
	SELECT func_nombre
	FROM GGDP.Funcionalidad
	JOIN GGDP.RolPorFuncionalidad ON func_id = rxf_funcionalidad
	WHERE rxf_rol = @rol
END
GO
/*
CREATE PROCEDURE GGDP.alta_cliente
(
	@usuario VARCHAR(255),
	@password VARCHAR(255),
	@rol INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18, 0),
	@mail VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(8),
	@fecha_nacimiento DATETIME
) AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		DECLARE @codigo_usuario INT
		DECLARE @habilitado BIT
		SET @habilitado = 1 */
		/* TODO FALTA EL SP ALTA USUARIO */
		/*
		EXEC @codigo_usuario = GGDP.alta_usuario(@usuario, @password, @rol)
		IF @codigo_usuario = -1
			RAISERROR('El usuario ya existe', 16, 1)
		INSERT INTO GGDP.Cliente(clie_nombre, clie_apellido, clie_dni, clie_mail, clie_telefono, clie_direccion, clie_codigo_postal, clie_fecha_nacimiento, clie_habilitado, clie_usuario)
		VALUES(@nombre, @apellido, @dni, @mail, @telefono, @direccion, @codigo_postal, @fecha_nacimiento, @habilitado, @codigo_usuario)
		COMMIT TRANSACTION
			SELECT @codigo_usuario
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
			SELECT -1
	END CATCH
END
GO
*/
/*
CREATE PROCEDURE GGDP.baja_cliente(@cliente_id INT) AS
	BEGIN
		BEGIN TRY
			BEGIN TRANSACTION
				DECLARE @deshabilitado BIT
				SET @deshabilitado = 0
				IF GGDP.fu_existe_cliente(@cliente_id) = 0
					RAISERROR('El cliente no existe', 16, 1)
				UPDATE GGDP.Cliente SET clie_habilitado = @deshabilitado WHERE clie_id = @cliente_id
			COMMIT TRANSACTION
			SELECT @cliente_id
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
				SELECT -1
		END CATCH
	END
GO
CREATE PROCEDURE GGDP.modificacion_cliente
(
	@cliente_id INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18, 0),
	@mail VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(8),
	@fecha_nacimiento DATETIME
) AS
	BEGIN
		BEGIN TRY
			BEGIN TRANSACTION
				IF GGDP.fu_existe_cliente(@cliente_id) = 0
					RAISERROR('El cliente no existe', 16, 1)
				UPDATE GGDP.Cliente SET
					clie_nombre = @nombre,
					clie_apellido = @apellido,
					clie_dni = @dni,
					clie_mail = @mail,
					clie_telefono = @telefono,
					clie_direccion = @direccion,
					clie_codigo_postal = @codigo_postal,
					clie_fecha_nacimiento = @fecha_nacimiento
				WHERE clie_id = @cliente_id
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
				SELECT -1
		END CATCH
	END
GO
*/
