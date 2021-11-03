--------------------------------------------------------------------------------------------------------------- Actualizaciones 26/09/2021
-- Las actualizaciones también están contempladas en los archivos ScriptDatos.sql y ScriptTablas.sql
-- Eliminar y volver a crear el ORM luego de actualizar la base de datos

-- Se agrega una llave foránea de ESCUELAS en la tabla RESERVAS
alter table RESERVAS add Id_Escuela int
alter table RESERVAS add constraint FK_ESCUELAS0 foreign key (Id_Escuela) references ESCUELAS(Id_Escuela)

update RESERVAS set Id_Escuela = 2 where Id_Reserva = 1
update RESERVAS set Id_Escuela = 3 where Id_Reserva = 2
update RESERVAS set Id_Escuela = 4 where Id_Reserva = 3

-- Actualización de las fechas de fin de las exposiciones para que sean vigentes y aparezcan en la grilla
update EXPOSICIONES set FechaFin = '2100-08-05' where Id_Exposicion = 1
update EXPOSICIONES set FechaFin = '2100-09-10' where Id_Exposicion = 2
update EXPOSICIONES set FechaFin = '2100-10-15' where Id_Exposicion = 3
update EXPOSICIONES set FechaFin = '2100-08-05' where Id_Exposicion = 4
update EXPOSICIONES set FechaFin = '2100-11-20' where Id_Exposicion = 5
update EXPOSICIONES set FechaFin = '2100-07-14' where Id_Exposicion = 6
update EXPOSICIONES set FechaFin = '2100-09-16' where Id_Exposicion = 7
update EXPOSICIONES set FechaFin = '2100-12-18' where Id_Exposicion = 8

update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 1
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 2
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 3
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 4
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 5
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 6
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 7
update EXPOSICIONES set FechaFinReplanificada = '2100-12-30' where Id_Exposicion = 8

-- Quitar microsegundos a las columnas HoraApertura y HoraCierre
alter table EXPOSICIONES alter column HoraApertura time(0)
alter table EXPOSICIONES alter column HoraCierre time(0)

-- Solo hay una obra por DetalleExposicion según el modelo dominio de las profes
------ Se modifican y actualizan EXPOSICIONES, DETALLESEXPOSICIONES
------ Se elimina OBRASPOREXPOSICION
------ Se crea la tabla DETALLESPOREXPOSICION con sus respectivos datos (Coincidentes con los que estaban en OBRASPOREXPOSICION)
alter table EXPOSICIONES drop constraint FK_DETALLESEXPOSICION0
alter table EXPOSICIONES drop column Id_DetalleExposicion

truncate table DETALLESEXPOSICION
drop table OBRASPOREXPOSICION

set identity_insert DETALLESEXPOSICION on
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (1, 'Pared 1', 1)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (2, 'Pared 2', 2)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (3, 'Pared 3', 3)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (4, 'Pared 4', 4)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (5, 'Pared 5', 5)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (6, 'Pared 1', 6)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (7, 'Pared 2', 7)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (8, 'Pared 3', 8)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (9, 'Pared 4', 9)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (10, 'Pared 5', 10)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (11, 'Pared 1', 11)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (12, 'Pared 2', 12)
insert into DETALLESEXPOSICION (Id_DetalleExposicion, LugarAsignado, Id_Obra) values (13, 'Pared 3', 13)
set identity_insert DETALLESEXPOSICION off


create table DETALLESPOREXPOSICION
(
	Id_DetallesPorExposicion int identity(1, 1) not null primary key,
	Id_Exposicion int,
	Id_DetalleExposicion int,
	constraint FK_EXPOSICIONES3 foreign key(Id_Exposicion) references EXPOSICIONES(Id_Exposicion),
	constraint FK_DETALLESEXPOSICION0 foreign key(Id_DetalleExposicion) references DETALLESEXPOSICION(Id_DetalleExposicion)
)

set identity_insert DETALLESPOREXPOSICION on
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(1, 1, 1)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(2, 1, 2)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(3, 1, 3)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(4, 1, 4)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(5, 1, 5)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(6, 1, 6)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(7, 1, 7)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(8, 1, 8)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(9, 1, 9)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(10, 1, 10)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(11, 2, 1)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(12, 2, 3)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(13, 2, 5)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(14, 2, 7)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(15, 2, 8)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(16, 2, 10)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(17, 2, 11)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(18, 2, 12)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(19, 2, 13)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(20, 3, 1)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(21, 3, 2)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(22, 3, 3)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(23, 3, 4)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(24, 3, 5)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(25, 3, 6)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(26, 3, 7)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(27, 3, 8)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(28, 3, 9)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(29, 3, 10)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(30, 3, 11)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(31, 3, 12)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(32, 3, 13)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(33, 4, 1)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(34, 4, 2)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(35, 4, 3)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(36, 4, 11)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(37, 4, 12)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(38, 4, 13)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(39, 5, 1)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(40, 5, 2)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(41, 5, 3)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(42, 5, 12)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(43, 6, 5)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(44, 6, 6)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(45, 6, 7)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(46, 6, 8)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(47, 6, 13)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(48, 7, 10)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(49, 7, 11)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(50, 7, 12)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(51, 7, 13)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(52, 8, 5)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(53, 8, 9)
insert into DETALLESPOREXPOSICION(Id_DetallesPorExposicion, Id_Exposicion, Id_DetalleExposicion) values(54, 8, 10)
set identity_insert DETALLESPOREXPOSICION off


--------------------------------------------------------------------------------------------------------------- Actualizaciones 11/02/2021
-- Estaba mal la llave foránea de Id_Sedes en EXPOSICIONESPORSEDE
alter table EXPOSICIONESPORSEDE drop constraint FK_SEDES2
alter table EXPOSICIONESPORSEDE add constraint FK_SEDES2 foreign key (Id_Sede) references SEDES (Id_Sede)

truncate table EXPOSICIONESPORSEDE

-- Se agregan más datos a EXPOSICIONESPORSEDE
set identity_insert EXPOSICIONESPORSEDE on
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(1, 1, 1)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(2, 2, 2)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(3, 3, 3)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(4, 4, 4)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(5, 5, 5)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(6, 6, 1)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(7, 7, 2)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(8, 8, 3)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(9, 1, 4)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(10, 2, 5)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(11, 3, 1)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(12, 4, 2)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(13, 5, 3)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(14, 6, 4)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(15, 7, 5)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(16, 8, 1)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(17, 1, 2)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(18, 2, 3)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(19, 3, 4)
insert into EXPOSICIONESPORSEDE	(Id_ExposicionPorSede, Id_Exposicion, Id_Sede) values(20, 4, 5)
set identity_insert EXPOSICIONESPORSEDE off

-- Se agregan más datos a la tabla EMPLEADOS. Todos guías
set identity_insert EMPLEADOS on
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (11, 'Damian', 'Galleguillo', '487885', 24190558473, 35458789, 'Las heras 547', '2002-10-21', '1982-05-14', 'DamianP@gmail.com', 'Masculino', 3513697885, 13, 1, 3)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (12, 'Julian', 'Juarez', '487886', 22204926813, 38458789, 'Dean Funes 75', '2005-12-21', '1986-05-10', 'Julian@gmail.com', 'Masculino', 3513697884, 13, 2, 3)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (13, 'Jorge', 'Galleguillo', '487887', 24432113543, 42458789, 'San martin 7', '2020-01-21', '1999-02-11', 'Jorge@gmail.com', 'Masculino', 3513697889, 13, 1, 3)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (14, 'Virginia', 'Rojos', '487888', 24391310363, 36458789, 'Malvinas 57', '2008-05-21', '1989-03-09', 'Virginia@gmail.com', 'Femenino', 3513697881, 13, 2, 4)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (15, 'Jose', 'Perez', '487889', 24332262483, 34458789, 'Salta 557', '2009-10-01', '1992-11-03', 'jose@gmail.com', 'Masculino', 3513697882, 13, 1, 5)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (16, 'Ryan', 'Schultz', '487890', 24430486073, 19055847, 'Uruguay 491', '2015-09-21', '1974-10-13', 'ryan@gmail.com', 'Masculino', 3518956587, 13, 2, 4)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (17, 'Brandon', 'Groetsque', '487891', 22417272343, 20492681, 'San Martin 478', '2010-12-23', '1969-01-06', 'brandon@gmail.com', 'Masculino', 3514568899, 13, 2, 5)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (18, 'Jerri', 'Denzel', '487892', 24309796083, 43211354, 'Roca 896', '2020-01-21', '2002-03-15', 'jerri@gmail.com', 'Masculino', 3512356532, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (19, 'Richard', 'Yvonne', '487893', 24579555963, 39131036, 'Boulevard Illia 455', '2018-05-01', '1997-03-03', 'richard@gmail.com', 'Masculino', 3514785263, 13, 1, 3)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (20, 'Ramona', 'Richards', '487894', 24419671623, 33226248, 'Obispo Oro 758', '2009-10-01', '1985-12-15', 'ramona@gmail.com', 'Femenino', 3511569874, 13, 1, 1)
set identity_insert EMPLEADOS off