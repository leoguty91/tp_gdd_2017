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

/* Eliminacion de Vistas */
IF (OBJECT_ID ('GGDP.vw_automovil_listado') IS NOT NULL)
  DROP VIEW GGDP.vw_automovil_listado;
GO
IF (OBJECT_ID ('GGDP.vw_rendicion') IS NOT NULL)
  DROP VIEW GGDP.vw_rendicion;
GO

/* Eliminacion de Functions */
IF (OBJECT_ID ('GGDP.fu_existe_usuario') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_usuario
GO
IF (OBJECT_ID ('GGDP.fu_existe_cliente') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_cliente
GO
IF (OBJECT_ID ('GGDP.fu_existe_chofer') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_chofer
GO
IF (OBJECT_ID ('GGDP.fu_existe_rol') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_rol
GO
IF (OBJECT_ID ('GGDP.fu_existe_funcionalidad_rol') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_funcionalidad_rol
GO
IF (OBJECT_ID ('GGDP.fu_existe_automovil') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_automovil
GO
IF (OBJECT_ID ('GGDP.fu_existe_turno') IS NOT NULL)
  DROP FUNCTION GGDP.fu_existe_turno
GO

/* Eliminacion de Triggers */
IF OBJECT_ID ('GGDP.tr_rol','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_rol;
IF OBJECT_ID ('GGDP.tr_alta_cliente','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_cliente;
IF OBJECT_ID ('GGDP.tr_alta_chofer','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_chofer;
IF OBJECT_ID ('GGDP.tr_alta_usuario','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_usuario;
IF OBJECT_ID ('GGDP.tr_alta_viaje','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_viaje;
IF OBJECT_ID ('GGDP.tr_alta_factura','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_factura;
IF OBJECT_ID ('GGDP.tr_alta_automovil','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_automovil;
IF OBJECT_ID ('GGDP.tr_alta_turno','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_turno;
IF OBJECT_ID ('GGDP.tr_alta_rendicion','TR') IS NOT NULL
   DROP TRIGGER GGDP.tr_alta_rendicion;
GO

/* Eliminacion de Store Procedures */
IF (OBJECT_ID ('GGDP.sp_login') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_login
IF (OBJECT_ID ('GGDP.sp_login_fallido') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_login_fallido
IF (OBJECT_ID ('GGDP.sp_obtener_usuario') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_usuario
IF (OBJECT_ID ('GGDP.sp_obtener_usuarios') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_usuarios	
IF (OBJECT_ID ('GGDP.sp_obtener_roles') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_roles
IF (OBJECT_ID ('GGDP.sp_obtener_roles_usuario') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_roles_usuario
IF (OBJECT_ID ('GGDP.sp_obtener_funcionalidades') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_funcionalidades
IF (OBJECT_ID ('GGDP.sp_obtener_funcionalidades_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_funcionalidades_rol
IF (OBJECT_ID ('GGDP.sp_obtener_funcionalidades_rol_tabla') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_funcionalidades_rol_tabla
IF (OBJECT_ID ('GGDP.sp_alta_funcionalidad_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_alta_funcionalidad_rol
IF (OBJECT_ID ('GGDP.sp_baja_funcionalidad_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_baja_funcionalidad_rol
IF (OBJECT_ID ('GGDP.sp_obtener_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_rol
IF (OBJECT_ID ('GGDP.sp_obtener_rol_nombre') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_rol_nombre
IF (OBJECT_ID ('GGDP.sp_alta_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_alta_rol
IF (OBJECT_ID ('GGDP.sp_baja_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_baja_rol
IF (OBJECT_ID ('GGDP.sp_modificacion_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_modificacion_rol
IF (OBJECT_ID ('GGDP.sp_habilitacion_rol') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_habilitacion_rol
IF (OBJECT_ID ('GGDP.sp_obtener_funcionalidad') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_funcionalidad
IF (OBJECT_ID ('GGDP.sp_obtener_funcionalidad_nombre') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_obtener_funcionalidad_nombre	 
IF (OBJECT_ID ('GGDP.sp_alta_usuario') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_usuario
IF (OBJECT_ID ('GGDP.sp_alta_cliente') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_cliente
IF (OBJECT_ID ('GGDP.sp_baja_cliente') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_baja_cliente
IF (OBJECT_ID ('GGDP.sp_modificacion_cliente') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_modificacion_cliente
IF (OBJECT_ID ('GGDP.sp_obtener_cliente') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_cliente
IF (OBJECT_ID ('GGDP.sp_obtener_clientes') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_clientes
IF (OBJECT_ID ('GGDP.sp_obtener_automovil') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_automovil
IF (OBJECT_ID ('GGDP.sp_obtener_automovil_usuario') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_automovil_usuario
IF (OBJECT_ID ('GGDP.sp_obtener_automoviles') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_automoviles
IF (OBJECT_ID ('GGDP.sp_alta_automovil') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_automovil
IF (OBJECT_ID ('GGDP.sp_modificacion_automovil') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_modificacion_automovil
IF (OBJECT_ID ('GGDP.sp_obtener_marca') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_marca
IF (OBJECT_ID ('GGDP.sp_obtener_marcas') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_marcas
IF (OBJECT_ID ('GGDP.sp_obtener_turno') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_turno
IF (OBJECT_ID ('GGDP.sp_obtener_turnos') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_turnos
IF (OBJECT_ID ('GGDP.sp_alta_turno') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_turno
IF (OBJECT_ID ('GGDP.sp_modificacion_turno') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_modificacion_turno
IF (OBJECT_ID ('GGDP.sp_obtener_chofer') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_chofer
IF (OBJECT_ID ('GGDP.sp_obtener_chofer_usuario') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_chofer_usuario
IF (OBJECT_ID ('GGDP.sp_obtener_choferes') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_choferes
IF (OBJECT_ID ('GGDP.sp_alta_chofer') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_chofer
IF (OBJECT_ID ('GGDP.sp_modificacion_chofer') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_modificacion_chofer
IF (OBJECT_ID ('GGDP.sp_alta_viaje') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_viaje
IF (OBJECT_ID ('GGDP.sp_obtener_viaje') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_viaje
IF (OBJECT_ID ('GGDP.sp_alta_rendicion') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_rendicion
IF (OBJECT_ID ('GGDP.sp_obtener_rendicion') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_rendicion
IF (OBJECT_ID ('GGDP.sp_alta_rendicion_viaje') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_rendicion_viaje
IF (OBJECT_ID ('GGDP.sp_alta_factura') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_factura
IF (OBJECT_ID ('GGDP.sp_obtener_factura') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_obtener_factura
IF (OBJECT_ID ('GGDP.sp_alta_factura_viaje') IS NOT NULL)
    DROP PROCEDURE GGDP.sp_alta_factura_viaje
IF (OBJECT_ID ('GGDP.sp_chofer_mayor_recaudacion') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_chofer_mayor_recaudacion;
IF (OBJECT_ID ('GGDP.sp_chofer_viaje_largo') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_chofer_viaje_largo;
IF (OBJECT_ID ('GGDP.sp_cliente_mayor_consumo') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_cliente_mayor_consumo;
IF (OBJECT_ID ('GGDP.sp_cliente_mismo_automovil_viajes') IS NOT NULL)
	DROP PROCEDURE GGDP.sp_cliente_mismo_automovil_viajes;
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
IF OBJECT_ID('GGDP.Automovil') IS NOT NULL
    DROP TABLE GGDP.Automovil;
IF OBJECT_ID('GGDP.Turno') IS NOT NULL
    DROP TABLE GGDP.Turno;
IF OBJECT_ID('GGDP.Factura') IS NOT NULL
    DROP TABLE GGDP.Factura;
IF OBJECT_ID('GGDP.Cliente') IS NOT NULL
    DROP TABLE GGDP.Cliente;
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
	auto_marca INT NOT NULL,
	auto_modelo VARCHAR(255) NOT NULL,
	auto_patente VARCHAR(10) NOT NULL UNIQUE,
	auto_turno INT NOT NULL,
	auto_chofer INT NOT NULL,
	auto_habilitado BIT
);

CREATE TABLE GGDP.Marca(
	marc_id INT IDENTITY PRIMARY KEY,
	marc_nombre VARCHAR(255) NOT NULL
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
	rend_fecha datetime not null,
	rend_chofer int not null ,
	rend_turno int not null,
	rend_importe numeric(18,2) not null
);

CREATE TABLE GGDP.Turno (
    turn_id INT IDENTITY PRIMARY KEY NOT NULL,
	turn_hora_inicio numeric(18,0) not null,
	turn_hora_fin numeric(18,0) not null,
	turn_descripcion varchar(255) not null,
	turn_valor_kilometro numeric(18,2) not null,
	turn_precio_base numeric(18,2) not null,
	turn_habilitado BIT
);

CREATE TABLE GGDP.Factura (
    fact_id INT IDENTITY PRIMARY KEY NOT NULL,
	fact_fecha_inicio datetime NOT NULL,
	fact_fecha_fin datetime NOT NULL,
	fact_cliente int NOT NULL,
	fact_importe decimal (12,2) NOT NULL,
	fact_viajes_facturados numeric(18,0) NOT NULL
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
	usua_usuario VARCHAR(255) NOT NULL UNIQUE,
	usua_password VARCHAR(255) NOT NULL,
	usua_intentos INT NOT NULL,
	usua_habilitado BIT NOT NULL
);
GO

/* Creacion de los FK */
ALTER TABLE GGDP.Cliente
	ADD CONSTRAINT fk_clie_usuario FOREIGN KEY (clie_usuario) REFERENCES GGDP.Usuario(usua_id)

ALTER TABLE GGDP.Automovil
	ADD CONSTRAINT fk_auto_chofer FOREIGN KEY (auto_chofer) REFERENCES GGDP.Chofer(chof_id)
ALTER TABLE GGDP.Automovil
	ADD CONSTRAINT fk_auto_marca FOREIGN KEY (auto_marca) REFERENCES GGDP.Marca(marc_id)
ALTER TABLE GGDP.Automovil
	ADD CONSTRAINT fk_auto_turno FOREIGN KEY (auto_turno) REFERENCES GGDP.Turno(turn_id)

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
	ADD CONSTRAINT fk_rxu_usuario FOREIGN KEY (rxu_usuario) REFERENCES GGDP.Usuario(usua_id) 
ALTER TABLE GGDP.RolPorUsuario
	ADD CONSTRAINT fk_rxu_rol  FOREIGN KEY (rxu_rol) REFERENCES GGDP.Rol(rol_id) 

ALTER TABLE GGDP.RolPorFuncionalidad
	ADD CONSTRAINT fk_rxf_rol FOREIGN KEY (rxf_rol) REFERENCES GGDP.Rol(rol_id)
ALTER TABLE GGDP.RolPorFuncionalidad
	ADD CONSTRAINT fk_rxf_funcionalidad FOREIGN KEY (rxf_funcionalidad) REFERENCES GGDP.Funcionalidad(func_id)

ALTER TABLE GGDP.Chofer
	ADD CONSTRAINT fk_chof_usuario FOREIGN KEY (chof_usuario) REFERENCES GGDP.Usuario(usua_id)
GO

/* Creacion de Indices */
CREATE INDEX IX_Cliente ON GGDP.Cliente(clie_nombre, clie_apellido, clie_dni)
CREATE INDEX IX_Automovil ON GGDP.Automovil(auto_marca, auto_modelo, auto_patente, auto_chofer)
CREATE INDEX IX_Chofer ON GGDP.Chofer(chof_nombre, chof_apellido, chof_dni)
CREATE INDEX IX_Marca ON GGDP.Marca(marc_nombre)
GO

/* Insercion de datos */
-- Insercion roles
INSERT INTO GGDP.Rol(rol_nombre, rol_habilitado)
VALUES ('Administrador', 1), ('Cliente', 1), ('Chofer', 1)
GO

-- Insercion funcionalidades
INSERT INTO GGDP.Funcionalidad(func_nombre)
VALUES ('ABM de Rol'), ('Login y Seguridad'), ('Registro de Usuario'), ('ABM de Cliente'), ('ABM de Automovil'), ('ABM de Turno'), ('ABM de Chofer'), ('Registro de Viajes'), ('Rendicion de cuenta del chofer'), ('Facturacion a Cliente'), ('Listado Estadistico')
GO

-- Insercion roles y funcionalidades
INSERT INTO GGDP.RolPorFuncionalidad(rxf_funcionalidad, rxf_rol)
SELECT func_id, rol_id FROM GGDP.Funcionalidad, GGDP.Rol WHERE rol_nombre = 'Administrador'
GO
INSERT INTO GGDP.RolPorFuncionalidad(rxf_funcionalidad, rxf_rol)
SELECT func_id, rol_id FROM GGDP.Funcionalidad, GGDP.Rol WHERE rol_nombre = 'Chofer' AND func_nombre = 'Registro de Viajes'
GO

-- Insercion usuario admin
INSERT INTO GGDP.Usuario(usua_usuario, usua_password, usua_intentos, usua_habilitado)
VALUES ('admin', HASHBYTES('SHA2_256', 'w23e'), 0, 1)
GO
INSERT INTO GGDP.RolPorUsuario(rxu_rol, rxu_usuario)
SELECT rol_id, usua_id FROM GGDP.Rol, GGDP.Usuario
WHERE rol_nombre = 'Administrador' AND usua_usuario = 'admin'
GO

-- Insercion de usuarios clientes
INSERT INTO GGDP.Usuario(usua_usuario, usua_password, usua_intentos, usua_habilitado)
SELECT DISTINCT(Cliente_Dni), HASHBYTES('SHA2_256', CAST(Cliente_Dni as varchar(255))), 0, 1 FROM [gd_esquema].[Maestra]
GO
INSERT INTO GGDP.RolPorUsuario(rxu_rol, rxu_usuario)
SELECT rol_id, usua_id FROM GGDP.Rol, GGDP.Usuario
WHERE rol_nombre = 'Cliente' AND usua_usuario IN (SELECT DISTINCT(CAST(Cliente_Dni AS varchar(255))) FROM [gd_esquema].[Maestra])
GO

-- Insercion de usuarios choferes
INSERT INTO GGDP.Usuario(usua_usuario, usua_password, usua_intentos, usua_habilitado)
SELECT DISTINCT(Chofer_Dni), HASHBYTES('SHA2_256', CAST(Chofer_Dni as varchar(255))), 0, 1 FROM [gd_esquema].[Maestra]
GO
INSERT INTO GGDP.RolPorUsuario(rxu_rol, rxu_usuario)
SELECT rol_id, usua_id FROM GGDP.Rol, GGDP.Usuario
WHERE rol_nombre = 'Chofer' AND usua_usuario IN (SELECT DISTINCT(CAST(Chofer_Dni AS varchar(255))) FROM [gd_esquema].[Maestra])
GO

-- Insercion de clientes
INSERT INTO GGDP.Cliente(clie_dni, clie_nombre, clie_apellido, clie_telefono, clie_direccion, clie_codigo_postal, clie_mail, clie_fecha_nacimiento, clie_habilitado, clie_usuario)
SELECT DISTINCT(Cliente_Dni), Cliente_Nombre, Cliente_Apellido, Cliente_Telefono, Cliente_Direccion, 1, Cliente_Mail, Cliente_Fecha_Nac, 1, usua_id FROM [gd_esquema].[Maestra], GGDP.Usuario WHERE usua_usuario = CAST(Cliente_Dni AS varchar(255))
GO

-- Insercion de choferes
INSERT INTO GGDP.Chofer(chof_mail, chof_nombre, chof_apellido, chof_dni, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario)
SELECT DISTINCT (Chofer_Mail), Chofer_Nombre, Chofer_Apellido, Chofer_Dni, Chofer_Telefono, Chofer_Direccion, 1, Chofer_Fecha_Nac, 1, usua_id FROM [gd_esquema].[Maestra], GGDP.Usuario WHERE usua_usuario = CAST(Chofer_Dni AS varchar(255))
GO

-- Insercion de marcas de autos
INSERT INTO GGDP.Marca(marc_nombre)
SELECT DISTINCT Auto_Marca FROM [gd_esquema].[Maestra]

-- Inserccion de Turnos (y agrego precio base a la tabla de Turno)
INSERT INTO GGDP.Turno (turn_hora_inicio, turn_hora_fin, turn_descripcion, turn_valor_kilometro, turn_precio_base, turn_habilitado)
SELECT DISTINCT Turno_Hora_Inicio, Turno_Hora_Fin, Turno_Descripcion, Turno_Valor_Kilometro, Turno_Precio_Base, 1 FROM [gd_esquema].[Maestra]
WHERE (Turno_Hora_Fin - Turno_Hora_Inicio) BETWEEN 0 AND 8
GO

-- Insercion de automoviles
INSERT INTO GGDP.Automovil(auto_patente, auto_marca, auto_modelo, auto_turno, auto_chofer, auto_habilitado)
SELECT DISTINCT ([Auto_Patente]), marc_id, [Auto_Modelo], 1, chof_id, 1
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Marca ON gd_esquema.Maestra.Auto_Marca = GGDP.Marca.marc_nombre
	JOIN GGDP.Chofer ON gd_esquema.Maestra.Chofer_Dni = GGDP.Chofer.chof_dni
	JOIN GGDP.Turno ON gd_esquema.Maestra.Turno_Descripcion = GGDP.Turno.turn_descripcion
GO

-- Insercion de viajes
INSERT INTO GGDP.Viaje(viaj_automovil, viaj_chofer, viaj_turno, viaj_cantidad_kilometros, viaj_fecha_inicio, viaj_fecha_fin, viaj_cliente)
SELECT auto_id, chof_id, turn_id, Viaje_Cant_Kilometros, Viaje_Fecha, DATEADD(MINUTE, 10, Viaje_Fecha), clie_id
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Automovil ON gd_esquema.Maestra.Auto_Patente = GGDP.Automovil.auto_patente
	JOIN GGDP.Chofer ON Chofer_Dni = chof_dni
	JOIN GGDP.Turno ON Turno_Descripcion = turn_descripcion
	JOIN GGDP.Cliente ON Cliente_Dni = clie_dni
WHERE Rendicion_Nro IS NULL AND Factura_Nro IS NULL
GROUP BY auto_id, chof_id, turn_id, Viaje_Cant_Kilometros, Viaje_Fecha, DATEADD(MINUTE, 10, Viaje_Fecha), clie_id
GO

-- Insercion de facturas
INSERT INTO GGDP.Factura(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_importe, fact_viajes_facturados)
SELECT Factura_Fecha_Inicio, Factura_Fecha_Fin, clie_id, SUM(Turno_Precio_Base + (Turno_Valor_Kilometro * Viaje_Cant_Kilometros)), 0
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Cliente ON Cliente_Dni = clie_dni
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Fecha_Inicio, Factura_Fecha_Fin, clie_id

INSERT INTO GGDP.FacturaPorViaje(fxv_factura, fxv_viaje)
SELECT fact_id, viaj_id
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Automovil ON gd_esquema.Maestra.Auto_Patente = GGDP.Automovil.auto_patente
	JOIN GGDP.Chofer ON Chofer_Dni = chof_dni
	JOIN GGDP.Turno ON Turno_Descripcion = turn_descripcion
	JOIN GGDP.Cliente ON Cliente_Dni = clie_dni
	JOIN GGDP.Viaje ON viaj_automovil = auto_id AND viaj_chofer = chof_id AND viaj_turno = turn_id AND viaj_fecha_inicio = Viaje_Fecha AND viaj_cliente = clie_id AND Viaje_Cant_Kilometros = viaj_cantidad_kilometros
	JOIN GGDP.Factura ON fact_fecha_inicio = Factura_Fecha_Inicio AND fact_cliente = clie_id
WHERE Factura_Nro IS NOT NULL
GROUP BY Chofer_Dni, Viaje_Cant_Kilometros, Viaje_Fecha, Turno_Descripcion, Cliente_Dni, fact_id, viaj_id
GO

UPDATE GGDP.Factura SET fact_viajes_facturados = (SELECT COUNT(*) FROM GGDP.FacturaPorViaje WHERE fxv_factura = fact_id GROUP BY fxv_factura)
GO

-- Insercion de rendiciones
INSERT INTO GGDP.Rendicion(rend_fecha, rend_chofer, rend_turno, rend_importe)
SELECT Rendicion_Fecha, chof_id, turn_id, SUM(Rendicion_Importe)
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Chofer ON Chofer_Dni = chof_dni
	JOIN GGDP.Turno ON Turno_Descripcion = turn_descripcion
WHERE Rendicion_Nro IS NOT NULL
GROUP BY Rendicion_Nro, Rendicion_Fecha, chof_id, turn_id
GO

INSERT INTO GGDP.RendicionPorViaje(rxv_rendicion, rxv_viaje)
SELECT rend_id, viaj_id
FROM [gd_esquema].[Maestra]
	JOIN GGDP.Automovil ON gd_esquema.Maestra.Auto_Patente = GGDP.Automovil.auto_patente
	JOIN GGDP.Chofer ON Chofer_Dni = chof_dni
	JOIN GGDP.Turno ON Turno_Descripcion = turn_descripcion
	JOIN GGDP.Cliente ON Cliente_Dni = clie_dni
	JOIN GGDP.Viaje ON viaj_automovil = auto_id AND viaj_chofer = chof_id AND viaj_turno = turn_id AND viaj_fecha_inicio = Viaje_Fecha AND viaj_cliente = clie_id AND Viaje_Cant_Kilometros = viaj_cantidad_kilometros
	JOIN GGDP.Rendicion ON rend_fecha = Rendicion_Fecha AND rend_chofer = chof_id AND rend_turno = turn_id
WHERE Rendicion_Nro IS NOT NULL
GROUP BY Chofer_Dni, Viaje_Cant_Kilometros, Viaje_Fecha, Turno_Descripcion, Cliente_Dni, Rendicion_Importe, rend_id, viaj_id
GO

/* Creacion de Vistas */
CREATE VIEW GGDP.vw_automovil_listado AS
	SELECT auto_id, marc_nombre, auto_modelo, auto_patente, auto_chofer, chof_nombre + ' ' + chof_apellido AS chof_nombre_apellido
	FROM GGDP.Automovil
	JOIN GGDP.Marca ON auto_marca = marc_id
	JOIN GGDP.Chofer ON auto_chofer = chof_id;
GO

CREATE VIEW GGDP.vw_rendicion AS
	SELECT viaj_id, viaj_chofer, chof_nombre + ' ' + chof_apellido as chof_nombre_apellido, viaj_turno, turn_descripcion, turn_precio_base, turn_valor_kilometro, viaj_cantidad_kilometros, viaj_fecha_inicio, viaj_fecha_fin, clie_id, clie_nombre + ' ' + clie_apellido AS clie_nombre_apellido, turn_precio_base + (turn_valor_kilometro * viaj_cantidad_kilometros) AS viaj_total
	FROM GGDP.Viaje
	JOIN GGDP.Cliente ON viaj_cliente = clie_id
	JOIN GGDP.Turno ON viaj_turno = turn_id
	JOIN GGDP.Chofer ON viaj_chofer = chof_id
GO

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

CREATE FUNCTION GGDP.fu_existe_chofer(@chofer_id INT) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.Chofer WHERE chof_id = @chofer_id)
		RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION GGDP.fu_existe_rol(@rol INT) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.Rol WHERE rol_id = @rol)
		RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION GGDP.fu_existe_funcionalidad_rol(@funcionalidad INT, @rol INT) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.RolPorFuncionalidad WHERE rxf_funcionalidad = @funcionalidad AND rxf_rol = @rol)
		RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION GGDP.fu_existe_automovil(@automovil_id INT) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.Automovil WHERE auto_id = @automovil_id)
		RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION GGDP.fu_existe_turno(@turno_id INT) RETURNS BIT AS BEGIN
	IF EXISTS(SELECT 1 FROM GGDP.Turno WHERE turn_id = @turno_id)
		RETURN 1
	RETURN 0
END
GO

/* Creacion de Triggers */
CREATE TRIGGER GGDP.tr_rol ON GGDP.Rol AFTER INSERT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM inserted i WHERE i.rol_nombre = '') > 0
		BEGIN
			RAISERROR('El rol nuevo no puede tener un nombre vacio', 16, 1)
		END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_cliente ON GGDP.Cliente INSTEAD OF INSERT, UPDATE
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM GGDP.Cliente c, inserted i WHERE c.clie_id != i.clie_id AND c.clie_telefono = i.clie_telefono) > 0
		BEGIN
			RAISERROR('El telefono ya existe, debe ingresar otro', 16, 1)
		END
		IF EXISTS(SELECT * FROM inserted)
		BEGIN
			IF EXISTS(SELECT * FROM deleted)
			BEGIN
				UPDATE GGDP.Cliente
				SET clie_nombre = i.clie_nombre,
					clie_apellido = i.clie_apellido,
					clie_dni = i.clie_dni,
					clie_mail = i.clie_mail,
					clie_telefono = i.clie_telefono,
					clie_direccion = i.clie_direccion,
					clie_codigo_postal = i.clie_codigo_postal,
					clie_fecha_nacimiento = i.clie_fecha_nacimiento,
					clie_habilitado = i.clie_habilitado,
					clie_usuario = i.clie_usuario
				FROM inserted i
				INNER JOIN GGDP.Cliente c ON i.clie_id = c.clie_id
			END
			ELSE
			BEGIN
				INSERT INTO GGDP.Cliente(clie_nombre, clie_apellido, clie_dni, clie_mail, clie_telefono, clie_direccion, clie_codigo_postal, clie_fecha_nacimiento, clie_habilitado, clie_usuario)
				SELECT clie_nombre, clie_apellido, clie_dni, clie_mail, clie_telefono, clie_direccion, clie_codigo_postal, clie_fecha_nacimiento, clie_habilitado, clie_usuario FROM inserted

				INSERT INTO GGDP.RolPorUsuario(rxu_rol, rxu_usuario)
				SELECT rol_id, clie_usuario FROM GGDP.Rol, inserted
				WHERE rol_nombre = 'Cliente'
			END
		END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_chofer ON GGDP.Chofer AFTER INSERT
AS
BEGIN
	BEGIN TRANSACTION

	INSERT INTO GGDP.RolPorUsuario(rxu_rol, rxu_usuario)
	SELECT rol_id, chof_usuario FROM GGDP.Rol, inserted
	WHERE rol_nombre = 'Chofer'

	COMMIT TRANSACTION
END
GO

CREATE TRIGGER GGDP.tr_alta_usuario ON GGDP.Usuario INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM GGDP.Usuario u, inserted i WHERE u.usua_usuario = i.usua_usuario) > 0
		BEGIN
			RAISERROR('El usuario ya existe, debe ingresar otro', 16, 1)
		END
		IF (SELECT COUNT(*) FROM inserted WHERE usua_password = '') > 0
		BEGIN
			RAISERROR('El password no puede estar vacio', 16, 1)
		END
		INSERT INTO GGDP.Usuario(usua_usuario, usua_password, usua_intentos, usua_habilitado)
		SELECT usua_usuario, usua_password, usua_intentos, usua_habilitado FROM inserted
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_viaje ON GGDP.Viaje INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM GGDP.Cliente c, inserted i WHERE c.clie_id = i.viaj_cliente AND c.clie_habilitado = 0) > 0
		BEGIN
			RAISERROR('No se puede asignar un viaje a un cliente inhabilitado', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Automovil a, inserted i WHERE a.auto_id = i.viaj_automovil AND a.auto_habilitado = 0) > 0
		BEGIN
			RAISERROR('No se puede asignar un viaje a un automovil inhabilitado', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Turno t, inserted i WHERE t.turn_id = i.viaj_turno AND t.turn_habilitado = 0) > 0
		BEGIN
			RAISERROR('No se puede asignar un viaje a un turno inhabilitado', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Chofer c, inserted i WHERE c.chof_id = i.viaj_chofer AND c.chof_habilitado = 0) > 0
		BEGIN
			RAISERROR('No se puede asignar un viaje a un chofer inhabilitado', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Viaje v, inserted i WHERE v.viaj_cliente = i.viaj_cliente AND (v.viaj_fecha_inicio < i.viaj_fecha_inicio AND v.viaj_fecha_fin > i.viaj_fecha_inicio) OR (v.viaj_fecha_inicio < i.viaj_fecha_fin AND v.viaj_fecha_fin > i.viaj_fecha_fin)) > 0
		BEGIN
			RAISERROR('No se puede dar de alta un viaje donde el cliente ya ha realizado otro en el mismo horario', 16, 1)
		END
		INSERT INTO GGDP.Viaje(viaj_automovil, viaj_chofer, viaj_turno, viaj_cantidad_kilometros, viaj_fecha_inicio, viaj_fecha_fin, viaj_cliente)
		SELECT viaj_automovil, viaj_chofer, viaj_turno, viaj_cantidad_kilometros, viaj_fecha_inicio, viaj_fecha_fin, viaj_cliente FROM inserted
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_factura ON GGDP.Factura INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM GGDP.Cliente c, inserted i WHERE c.clie_id = i.fact_cliente AND c.clie_habilitado = 0) > 0
		BEGIN
			RAISERROR('No se puede realizar una facturacion a un cliente inhabilitado', 16, 1)
		END
		INSERT INTO GGDP.Factura(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_importe, fact_viajes_facturados)
		SELECT fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_importe, fact_viajes_facturados FROM inserted
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_automovil ON GGDP.Automovil INSTEAD OF INSERT, UPDATE
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM GGDP.Automovil a, inserted i WHERE a.auto_id != i.auto_id AND a.auto_patente = i.auto_patente) > 0
		BEGIN
			RAISERROR('No se puede dar de alta un automovil con una patente ya registrada', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Automovil a, inserted i WHERE a.auto_id != i.auto_id AND a.auto_chofer = i.auto_chofer AND a.auto_habilitado = 1 AND i.auto_habilitado = 1) > 0
		BEGIN
			RAISERROR('No se puede dar de alta un automovil con un chofer asignado a otro auto activo', 16, 1)
		END
		IF EXISTS(SELECT * FROM inserted)
		BEGIN
			IF EXISTS(SELECT * FROM deleted)
			BEGIN
				UPDATE GGDP.Automovil
				SET auto_marca = i.auto_marca,
					auto_modelo = i.auto_modelo,
					auto_patente = i.auto_patente,
					auto_turno = i.auto_turno,
					auto_chofer = i.auto_chofer,
					auto_habilitado = i.auto_habilitado
				FROM inserted i
				INNER JOIN GGDP.Automovil a ON i.auto_id = a.auto_id
			END
			ELSE
			BEGIN
				INSERT INTO GGDP.Automovil(auto_marca, auto_modelo, auto_patente, auto_turno, auto_chofer, auto_habilitado)
				SELECT auto_marca, auto_modelo, auto_patente, auto_turno, auto_chofer, auto_habilitado FROM inserted
			END
		END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_turno ON GGDP.Turno INSTEAD OF INSERT, UPDATE
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM inserted i WHERE i.turn_hora_inicio = i.turn_hora_fin) > 0
		BEGIN
			RAISERROR('No se puede dar de alta un turno con la misma hora de inicio y fin', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Turno t, inserted i WHERE t.turn_id != i.turn_id AND (t.turn_hora_inicio < i.turn_hora_inicio AND t.turn_hora_fin > i.turn_hora_inicio) OR (t.turn_hora_inicio < i.turn_hora_fin AND t.turn_hora_fin > i.turn_hora_fin)) > 0
		BEGIN
			RAISERROR('No se puede dar de alta un turno que superpone franja horaria con otro', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Turno t, inserted i WHERE i.turn_hora_inicio > i.turn_hora_fin OR i.turn_hora_inicio > 24 OR i.turn_hora_inicio < 0 OR i.turn_hora_fin > 24 OR i.turn_hora_fin < 0) > 0
		BEGIN
			RAISERROR('No se puede dar de alta un turno que excede las 24 horas', 16, 1)
		END
		IF EXISTS(SELECT * FROM inserted)
		BEGIN
			IF EXISTS(SELECT * FROM deleted)
			BEGIN
				UPDATE GGDP.Turno
				SET turn_hora_inicio = i.turn_hora_inicio,
					turn_hora_fin = i.turn_hora_fin,
					turn_descripcion = i.turn_descripcion,
					turn_valor_kilometro = i.turn_valor_kilometro,
					turn_precio_base = i.turn_precio_base,
					turn_habilitado = i.turn_habilitado
				FROM inserted i
				INNER JOIN GGDP.Turno t ON i.turn_id = t.turn_id
			END
			ELSE
			BEGIN
				INSERT INTO GGDP.Turno(turn_hora_inicio, turn_hora_fin, turn_descripcion, turn_valor_kilometro, turn_precio_base, turn_habilitado)
				SELECT turn_hora_inicio, turn_hora_fin, turn_descripcion, turn_valor_kilometro, turn_precio_base, turn_habilitado FROM inserted
			END
		END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

CREATE TRIGGER GGDP.tr_alta_rendicion ON GGDP.Rendicion INSTEAD OF INSERT
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF (SELECT COUNT(*) FROM GGDP.Rendicion r, inserted i WHERE r.rend_chofer = i.rend_chofer AND CONVERT(DATE, r.rend_fecha) = CONVERT(DATE, i.rend_fecha)) > 0
		BEGIN
			RAISERROR('No se puede realizar un rendicion ya hecha', 16, 1)
		END
		IF (SELECT COUNT(*) FROM GGDP.Chofer c, inserted i WHERE c.chof_id = i.rend_chofer AND c.chof_habilitado = 0) > 0
		BEGIN
			RAISERROR('No se puede realizar una rendicion a un chofer inhabilitado', 16, 1)
		END
		INSERT INTO GGDP.Rendicion(rend_fecha, rend_chofer, rend_turno, rend_importe)
		SELECT rend_fecha, rend_chofer, rend_turno, rend_importe FROM inserted
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION

		DECLARE @ErrorMessage NVARCHAR(4000);
		DECLARE @ErrorSeverity INT;
		DECLARE @ErrorState INT;

		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();

		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
	END CATCH
END
GO

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

CREATE PROCEDURE GGDP.sp_obtener_usuario(@usuario VARCHAR(255)) AS BEGIN
	SELECT usua_id, usua_usuario, usua_habilitado FROM GGDP.Usuario WHERE usua_id = @usuario
END
GO

CREATE PROCEDURE GGDP.sp_obtener_usuarios AS BEGIN
	SELECT usua_id, usua_usuario FROM GGDP.Usuario
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
END
GO

CREATE PROCEDURE GGDP.sp_obtener_roles_usuario(@usuario VARCHAR(255)) AS BEGIN
	SELECT rol_id, rol_nombre, rol_habilitado
	FROM GGDP.Rol
	JOIN GGDP.RolPorUsuario ON rol_id = rxu_rol
	WHERE rxu_usuario = @usuario
END
GO

CREATE PROCEDURE GGDP.sp_obtener_funcionalidades AS BEGIN
	SELECT func_nombre as Funcionalidad, 0 as Habilitado
	FROM GGDP.Funcionalidad
END
GO

CREATE PROCEDURE GGDP.sp_obtener_funcionalidades_rol(@rol VARCHAR(255)) AS BEGIN
	SELECT func_id, func_nombre
	FROM GGDP.Funcionalidad
	JOIN GGDP.RolPorFuncionalidad ON func_id = rxf_funcionalidad
	JOIN GGDP.Rol ON rxf_rol = rol_id
	WHERE rol_id = @rol
END
GO

CREATE PROCEDURE GGDP.sp_obtener_funcionalidades_rol_tabla(@rol VARCHAR(255)) AS BEGIN
	SELECT func_nombre as Funcionalidad, (SELECT COUNT(*) FROM GGDP.RolPorFuncionalidad WHERE func_id = rxf_funcionalidad AND rol_id = rxf_rol) as Habilitado
	FROM GGDP.Funcionalidad, GGDP.Rol
	WHERE rol_id = @rol
END
GO

CREATE PROCEDURE GGDP.sp_alta_funcionalidad_rol(@funcionalidad INT, @rol INT) AS BEGIN
	IF GGDP.fu_existe_funcionalidad_rol(@funcionalidad, @rol) = 0
	BEGIN
		INSERT GGDP.RolPorFuncionalidad(rxf_funcionalidad, rxf_rol) VALUES(@funcionalidad, @rol)
	END
END
GO

CREATE PROCEDURE GGDP.sp_baja_funcionalidad_rol(@funcionalidad INT, @rol INT) AS BEGIN
	IF GGDP.fu_existe_funcionalidad_rol(@funcionalidad, @rol) = 1
	BEGIN
		DELETE FROM GGDP.RolPorFuncionalidad WHERE rxf_funcionalidad = @funcionalidad AND rxf_rol = @rol
	END
END
GO

CREATE PROCEDURE GGDP.sp_obtener_rol(@rol VARCHAR(255)) AS BEGIN
	SELECT rol_id, rol_nombre, rol_habilitado FROM GGDP.Rol WHERE rol_id = @rol
END
GO

CREATE PROCEDURE GGDP.sp_obtener_rol_nombre(@rol_nombre VARCHAR(255)) AS BEGIN
	SELECT rol_id, rol_nombre, rol_habilitado FROM GGDP.Rol WHERE rol_nombre = @rol_nombre
END
GO

CREATE PROCEDURE GGDP.sp_alta_rol(@nombre VARCHAR(255), @habilitado BIT) AS BEGIN
BEGIN TRY
		BEGIN TRANSACTION
		INSERT GGDP.Rol(rol_nombre, rol_habilitado) VALUES (@nombre, @habilitado)
		COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
	RAISERROR('El rol nuevo no puede tener un nombre vacio', 16, 1)
END CATCH

END
GO

CREATE PROCEDURE GGDP.sp_baja_rol(@rol INT) AS BEGIN

		BEGIN TRANSACTION
		IF GGDP.fu_existe_rol(@rol) = 0
		BEGIN
			RAISERROR('El rol seleccionado no existe', 16, 1)
		END
		UPDATE GGDP.Rol SET rol_habilitado = 0 WHERE rol_id = @rol
		DELETE FROM GGDP.RolPorUsuario WHERE rxu_rol = @rol 
		COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_modificacion_rol(@rol INT, @nombre VARCHAR(255), @habilitado BIT) AS BEGIN

	BEGIN TRANSACTION
	IF GGDP.fu_existe_rol(@rol) = 0
	BEGIN
		RAISERROR('El rol seleccionado no existe', 16, 1)
	END
	UPDATE GGDP.Rol SET rol_nombre = ISNULL(@nombre, rol_nombre), rol_habilitado = ISNULL(@habilitado, rol_habilitado)
	WHERE rol_id = @rol
	IF (SELECT rol_habilitado FROM GGDP.Rol WHERE rol_id = @rol) = 0
	BEGIN
		EXEC GGDP.sp_baja_rol @rol
	END

	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE GGDP.sp_habilitacion_rol(@rol INT) AS BEGIN

		BEGIN TRANSACTION
		IF GGDP.fu_existe_rol(@rol) = 0
		BEGIN
			RAISERROR('El rol seleccionado no existe', 16, 1)
		END
		UPDATE GGDP.Rol SET rol_habilitado = 1 WHERE rol_id = @rol
		COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_obtener_funcionalidad(@funcionalidad VARCHAR(255)) AS BEGIN
	SELECT func_id, func_nombre FROM GGDP.Funcionalidad WHERE func_id = @funcionalidad
END
GO

CREATE PROCEDURE GGDP.sp_obtener_funcionalidad_nombre(@funcionalidad_nombre VARCHAR(255)) AS BEGIN
	SELECT func_id, func_nombre FROM GGDP.Funcionalidad WHERE func_nombre = @funcionalidad_nombre
END
GO

CREATE PROCEDURE GGDP.sp_alta_usuario(@usuario VARCHAR(255), @password VARCHAR(255)) AS BEGIN
	BEGIN TRANSACTION
	INSERT INTO GGDP.Usuario(usua_usuario, usua_password, usua_intentos, usua_habilitado)
	VALUES (@usuario, HASHBYTES('SHA2_256', @password), 0, 1)
	COMMIT TRANSACTION
	SELECT usua_id FROM GGDP.Usuario WHERE usua_usuario = @usuario
END
GO

CREATE PROCEDURE GGDP.sp_alta_cliente
(
	@usuario INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18, 0),
	@mail VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(8),
	@fecha_nacimiento DATETIME,
	@habilitado BIT
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Cliente(clie_nombre, clie_apellido, clie_dni, clie_mail, clie_telefono, clie_direccion, clie_codigo_postal, clie_fecha_nacimiento, clie_habilitado, clie_usuario)
	VALUES(@nombre, @apellido, @dni, @mail, @telefono, @direccion, @codigo_postal, @fecha_nacimiento, @habilitado, @usuario)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_baja_cliente(@cliente_id INT) AS
	BEGIN

			BEGIN TRANSACTION
				DECLARE @deshabilitado BIT
				SET @deshabilitado = 0
				IF GGDP.fu_existe_cliente(@cliente_id) = 0
				BEGIN
					RAISERROR('El cliente no existe', 16, 1)
				END
				UPDATE GGDP.Cliente SET clie_habilitado = @deshabilitado WHERE clie_id = @cliente_id
			COMMIT TRANSACTION
			SELECT @cliente_id

	END
GO

CREATE PROCEDURE GGDP.sp_modificacion_cliente
(
	@cliente_id INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18, 0),
	@mail VARCHAR(255),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(8),
	@fecha_nacimiento DATETIME,
	@habilitado BIT
) AS
	BEGIN

			BEGIN TRANSACTION
				IF GGDP.fu_existe_cliente(@cliente_id) = 0
				BEGIN
					RAISERROR('El cliente no existe', 16, 1)
				END
				UPDATE GGDP.Cliente SET
					clie_nombre = ISNULL(@nombre, clie_nombre),
					clie_apellido = ISNULL(@apellido, clie_apellido),
					clie_dni = ISNULL(@dni, clie_dni),
					clie_mail = ISNULL(@mail, clie_mail),
					clie_telefono = ISNULL(@telefono, clie_telefono),
					clie_direccion = ISNULL(@direccion, clie_direccion),
					clie_codigo_postal = ISNULL(@codigo_postal, clie_codigo_postal),
					clie_fecha_nacimiento = ISNULL(@fecha_nacimiento, clie_fecha_nacimiento),
					clie_habilitado = ISNULL(@habilitado, clie_habilitado)
				WHERE clie_id = @cliente_id
			COMMIT TRANSACTION

	END
GO

CREATE PROCEDURE GGDP.sp_obtener_cliente(@cliente_id INT) AS BEGIN
	SELECT clie_id, clie_nombre, clie_apellido, clie_dni, clie_mail, clie_telefono, clie_direccion, clie_codigo_postal, clie_fecha_nacimiento, clie_habilitado, clie_usuario FROM GGDP.Cliente WHERE clie_id = @cliente_id
END
GO

CREATE PROCEDURE GGDP.sp_obtener_clientes AS BEGIN
	SELECT clie_id, clie_nombre, clie_apellido, clie_dni, clie_mail, clie_telefono, clie_direccion, clie_codigo_postal, clie_fecha_nacimiento, clie_habilitado, clie_usuario FROM GGDP.Cliente
END
GO

CREATE PROCEDURE GGDP.sp_obtener_automovil(@automovil_id INT) AS BEGIN
	SELECT auto_id, auto_marca, auto_modelo, auto_patente, auto_turno, auto_chofer, auto_habilitado FROM GGDP.Automovil WHERE auto_id = @automovil_id
END
GO

CREATE PROCEDURE GGDP.sp_obtener_automovil_usuario(@usuario_id INT) AS BEGIN
	SELECT auto_id, auto_marca, auto_modelo, auto_patente, auto_turno, auto_chofer, auto_habilitado
	FROM GGDP.Automovil
	JOIN Chofer ON auto_chofer = chof_id
	JOIN Usuario ON chof_usuario = usua_id
	WHERE usua_id = @usuario_id AND auto_habilitado = 1
END
GO

CREATE PROCEDURE GGDP.sp_obtener_automoviles AS BEGIN
	SELECT auto_id, auto_marca, auto_modelo, auto_patente, auto_turno, auto_chofer, auto_habilitado FROM GGDP.Automovil
END
GO

CREATE PROCEDURE GGDP.sp_alta_automovil
(
	@marca INT,
	@modelo VARCHAR(255),
	@patente VARCHAR(10),
	@turno INT,
	@chofer INT,
	@habilitado BIT
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Automovil(auto_marca, auto_modelo, auto_patente, auto_turno, auto_chofer, auto_habilitado)
	VALUES(@marca, @modelo, @patente, @turno, @chofer, @habilitado)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_modificacion_automovil
(
	@automovil_id INT,
	@marca INT,
	@modelo VARCHAR(255),
	@patente VARCHAR(10),
	@turno INT,
	@chofer INT,
	@habilitado BIT
) AS
	BEGIN

			BEGIN TRANSACTION
				IF GGDP.fu_existe_automovil(@automovil_id) = 0
				BEGIN
					RAISERROR('El automovil no existe', 16, 1)
				END
				UPDATE GGDP.Automovil SET
					auto_marca = ISNULL(@marca, auto_marca),
					auto_modelo = ISNULL(@modelo, auto_modelo),
					auto_patente = ISNULL(@patente, auto_patente),
					auto_turno = ISNULL(@turno, auto_turno),
					auto_chofer = ISNULL(@chofer, auto_chofer),
					auto_habilitado = ISNULL(@habilitado, auto_habilitado)
				WHERE auto_id = @automovil_id
			COMMIT TRANSACTION

	END
GO

CREATE PROCEDURE GGDP.sp_obtener_marca(@marca_id INT) AS BEGIN
	SELECT marc_id, marc_nombre FROM GGDP.Marca WHERE marc_id = @marca_id
END
GO

CREATE PROCEDURE GGDP.sp_obtener_marcas AS BEGIN
	SELECT marc_id, marc_nombre FROM GGDP.Marca
END
GO

CREATE PROCEDURE GGDP.sp_obtener_turno(@turno_id int) AS BEGIN
	SELECT turn_id, turn_hora_inicio, turn_hora_fin, turn_descripcion, turn_valor_kilometro, turn_precio_base, turn_habilitado FROM GGDP.Turno WHERE turn_id = @turno_id
END
GO

CREATE PROCEDURE GGDP.sp_obtener_turnos AS BEGIN
	SELECT turn_id, turn_hora_inicio, turn_hora_fin, turn_descripcion, turn_valor_kilometro, turn_precio_base, turn_habilitado FROM GGDP.Turno
END
GO

CREATE PROCEDURE GGDP.sp_alta_turno
(
	@hora_inicio numeric(18,0),
	@hora_fin numeric(18,0),
	@descripcion varchar(255),
	@valor_kilometro numeric(18,2),
	@precio_base numeric(18,2),
	@habilitado BIT
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Turno(turn_hora_inicio, turn_hora_fin, turn_descripcion, turn_valor_kilometro, turn_precio_base, turn_habilitado)
	VALUES(@hora_inicio, @hora_fin, @descripcion, @valor_kilometro, @precio_base, @habilitado)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_modificacion_turno
(
	@turno_id INT,
	@hora_inicio numeric(18,0),
	@hora_fin numeric(18,0),
	@descripcion varchar(255),
	@valor_kilometro numeric(18,2),
	@precio_base numeric(18,2),
	@habilitado BIT
) AS
	BEGIN

			BEGIN TRANSACTION
				IF GGDP.fu_existe_turno(@turno_id) = 0
				BEGIN
					RAISERROR('El turno no existe', 16, 1)
				END
				UPDATE GGDP.Turno SET
					turn_hora_inicio = ISNULL(@hora_inicio, turn_hora_inicio),
					turn_hora_fin = ISNULL(@hora_fin, turn_hora_fin),
					turn_descripcion = ISNULL(@descripcion, turn_descripcion),
					turn_valor_kilometro = ISNULL(@valor_kilometro, turn_valor_kilometro),
					turn_precio_base = ISNULL(@precio_base, turn_precio_base),
					turn_habilitado = ISNULL(@habilitado, turn_habilitado)
				WHERE turn_id = @turno_id
			COMMIT TRANSACTION

	END
GO

CREATE PROCEDURE GGDP.sp_obtener_chofer(@chofer_id int) AS BEGIN
	SELECT chof_id, chof_nombre, chof_apellido, chof_dni, chof_mail, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario FROM GGDP.Chofer WHERE chof_id = @chofer_id
END
GO

CREATE PROCEDURE GGDP.sp_obtener_chofer_usuario(@usuario_id int) AS BEGIN
	SELECT chof_id, chof_nombre, chof_apellido, chof_dni, chof_mail, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario FROM GGDP.Chofer WHERE chof_usuario = @usuario_id
END
GO

CREATE PROCEDURE GGDP.sp_obtener_choferes AS BEGIN
	SELECT chof_id, chof_nombre, chof_apellido, chof_dni, chof_mail, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario FROM GGDP.Chofer
END
GO

CREATE PROCEDURE GGDP.sp_alta_chofer
(
    @nombre VARCHAR(225),
	@apellido VARCHAR(255),
	@dni NUMERIC(18, 0),
	@mail VARCHAR(50),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(8),
	@fecha_nacimiento datetime,
    @habilitado BIT,
	@usuario INT
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Chofer(chof_nombre, chof_apellido, chof_dni, chof_mail, chof_telefono, chof_direccion, chof_codigo_postal, chof_fecha_nacimiento, chof_habilitado, chof_usuario)
	VALUES(@nombre, @apellido, @dni, @mail, @telefono, @direccion, @codigo_postal, @fecha_nacimiento, @habilitado, @usuario)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_modificacion_chofer
(
	@chofer_id INT,
	@nombre VARCHAR(255),
	@apellido VARCHAR(255),
	@dni NUMERIC(18, 0),
	@mail VARCHAR(50),
	@telefono NUMERIC(18, 0),
	@direccion VARCHAR(255),
	@codigo_postal VARCHAR(8),
	@fecha_nacimiento DATETIME,
	@habilitado BIT
) AS
	BEGIN

			BEGIN TRANSACTION
				IF GGDP.fu_existe_chofer(@chofer_id) = 0
				BEGIN
					RAISERROR('El chofer no existe', 16, 1)
				END
				UPDATE GGDP.Chofer SET
					chof_nombre = ISNULL(@nombre, chof_nombre),
					chof_apellido = ISNULL(@apellido, chof_apellido),
					chof_dni = ISNULL(@dni, chof_dni),
					chof_mail = ISNULL(@mail, chof_mail),
					chof_telefono = ISNULL(@telefono, chof_telefono),
					chof_direccion = ISNULL(@direccion, chof_direccion),
					chof_codigo_postal = ISNULL(@codigo_postal, chof_codigo_postal),
					chof_fecha_nacimiento = ISNULL(@fecha_nacimiento, chof_fecha_nacimiento),
					chof_habilitado = ISNULL(@habilitado, chof_habilitado)
				WHERE chof_id = @chofer_id
			COMMIT TRANSACTION

	END
GO

CREATE PROCEDURE GGDP.sp_alta_viaje
(
	@automovil INT,
	@chofer INT,
	@turno INT,
	@cantidad_kilometros NUMERIC(18, 0),
	@fecha_inicio DATETIME,
	@fecha_fin DATETIME,
	@cliente INT
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Viaje(viaj_automovil, viaj_chofer, viaj_turno, viaj_cantidad_kilometros, viaj_fecha_inicio, viaj_fecha_fin, viaj_cliente)
	VALUES(@automovil, @chofer, @turno, @cantidad_kilometros, @fecha_inicio, @fecha_fin, @cliente)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_obtener_viaje(@viaje_id int) AS BEGIN
	SELECT viaj_id, viaj_automovil, viaj_chofer, viaj_turno, viaj_cantidad_kilometros, viaj_fecha_inicio, viaj_fecha_fin, viaj_cliente FROM GGDP.Viaje WHERE viaj_id = @viaje_id
END
GO

CREATE PROCEDURE GGDP.sp_alta_rendicion
(
	@fecha datetime,
	@chofer int,
	@turno int,
	@importe numeric(18,2)
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Rendicion(rend_fecha, rend_chofer, rend_turno, rend_importe)
	VALUES(@fecha, @chofer, @turno, @importe)
	COMMIT TRANSACTION
	RETURN SELECT rend_id FROM GGDP.Rendicion WHERE rend_fecha = @fecha AND rend_chofer = @chofer AND rend_turno = @turno

END
GO

CREATE PROCEDURE GGDP.sp_obtener_rendicion(@fecha datetime, @chofer int, @turno int) AS BEGIN
	SELECT rend_id, rend_fecha, rend_chofer, rend_turno, rend_importe FROM GGDP.Rendicion WHERE CONVERT(date, rend_fecha) = CONVERT(date, @fecha) AND rend_chofer = @chofer AND rend_turno = @turno
END
GO

CREATE PROCEDURE GGDP.sp_alta_rendicion_viaje
(
	@rendicion int,
	@viaje int
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.RendicionPorViaje(rxv_rendicion, rxv_viaje)
	VALUES(@rendicion, @viaje)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_alta_factura
(
	@fecha_inicio datetime,
	@cliente int,
	@importe decimal (12,2),
	@viajes_facturados numeric(18,0)

) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.Factura(fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_importe, fact_viajes_facturados)
	VALUES(DATETIMEFROMPARTS(YEAR(@fecha_inicio), MONTH(@fecha_inicio), 1, 0, 0, 0, 0), DATETIMEFROMPARTS(YEAR(@fecha_inicio), MONTH(@fecha_inicio), DAY(EOMONTH(@fecha_inicio)), 0, 0, 0, 0), @cliente, @importe, @viajes_facturados)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_obtener_factura(@fecha_inicio datetime, @cliente int) AS BEGIN
	SELECT fact_id, fact_fecha_inicio, fact_fecha_fin, fact_cliente, fact_importe, fact_viajes_facturados 
	FROM GGDP.Factura WHERE fact_fecha_inicio = DATETIMEFROMPARTS(YEAR(@fecha_inicio), MONTH(@fecha_inicio), 1, 0, 0, 0, 0) AND fact_fecha_fin = DATETIMEFROMPARTS(YEAR(@fecha_inicio), MONTH(@fecha_inicio), DAY(EOMONTH(@fecha_inicio)), 0, 0, 0, 0) AND fact_cliente = @cliente
END
GO

CREATE PROCEDURE GGDP.sp_alta_factura_viaje
(
	@factura int,
	@viaje int
) AS
BEGIN

	BEGIN TRANSACTION
	INSERT INTO GGDP.FacturaPorViaje(fxv_factura, fxv_viaje)
	VALUES(@factura, @viaje)
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE GGDP.sp_chofer_mayor_recaudacion (@fecha_inicio datetime, @fecha_fin datetime) AS
BEGIN
	SELECT TOP 5 chof_id as Chofer_ID, chof_nombre + ' ' + chof_apellido as Chofer, SUM(rend_importe) AS Rendicion
	FROM GGDP.Chofer
	JOIN GGDP.Rendicion ON chof_id = rend_chofer
	WHERE rend_fecha BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY chof_id, chof_nombre + ' ' + chof_apellido
	ORDER BY SUM(rend_importe) DESC
END
GO

CREATE PROCEDURE GGDP.sp_chofer_viaje_largo (@fecha_inicio datetime, @fecha_fin datetime) AS
BEGIN
	SELECT DISTINCT TOP 5 chof_id as Chofer_ID, viaj_id as Viaje_ID, chof_nombre + ' ' + chof_apellido as Chofer, viaj_cantidad_kilometros as Kilometros
	FROM GGDP.Chofer
	JOIN GGDP.Viaje ON chof_id = viaj_chofer
	WHERE viaj_fecha_fin BETWEEN @fecha_inicio AND @fecha_fin
	ORDER BY viaj_cantidad_kilometros DESC
END
GO

CREATE PROCEDURE GGDP.sp_cliente_mayor_consumo (@fecha_inicio datetime, @fecha_fin datetime) AS
BEGIN
	SELECT TOP 5 fact_cliente as Factura, clie_nombre + ' ' + clie_apellido AS Cliente, SUM(fact_importe) as Consumo
	FROM GGDP.Factura
	JOIN GGDP.Cliente ON fact_cliente = clie_id
	WHERE fact_fecha_inicio BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY fact_cliente, clie_nombre + ' ' + clie_apellido
	ORDER BY SUM(fact_importe) DESC
END
GO

CREATE PROCEDURE GGDP.sp_cliente_mismo_automovil_viajes (@fecha_inicio datetime, @fecha_fin datetime) AS
BEGIN
	SELECT TOP 5 clie_nombre + ' ' + clie_apellido AS Cliente, marc_nombre + ' ' + auto_modelo + ' ' + auto_patente AS Automovil, COUNT(*) as Cantidad_veces_usado
	FROM GGDP.Factura
	JOIN GGDP.Cliente ON fact_cliente = clie_id
	JOIN GGDP.FacturaPorViaje ON fact_id = fxv_factura
	JOIN GGDP.Viaje ON fxv_viaje = viaj_id
	JOIN GGDP.Automovil ON viaj_automovil = auto_id
	JOIN GGDP.Marca on auto_marca = marc_id
	WHERE fact_fecha_inicio BETWEEN @fecha_inicio AND @fecha_fin
	GROUP BY clie_nombre + ' ' + clie_apellido, marc_nombre + ' ' + auto_modelo + ' ' + auto_patente
	ORDER BY COUNT(*) DESC
END
GO