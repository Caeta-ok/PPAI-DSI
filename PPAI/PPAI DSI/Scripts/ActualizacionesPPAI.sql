Update SEDES SET Id_Exposicion = 1 where Id_Sede = 1
Update SEDES SET Id_Exposicion = 7 where Id_Sede = 2
Update SEDES SET Id_Exposicion = 6 where Id_Sede = 3
Update SEDES SET Id_Exposicion = 3 where Id_Sede = 4
Update SEDES SET Id_Exposicion = 1 where Id_Sede = 5

alter table OBRAS drop column DuracionExtendida 
alter table OBRAS drop column DuracionResumida 

alter table OBRAS add DuracionExtendida int
alter table OBRAS add DuracionResumida int

--create table OBRASPOREXPOSICION
--    (Id_ObraPorExposicion int identity(1, 1) not null primary key,
--     Id_Obra int,
--     Id_Exposicion int,
--     constraint FK_OBRAS1 foreign key (Id_Obra) references OBRAS(Id_Obra),
--     constraint FK_EXPOSICIONES1 foreign key (Id_Exposicion) references EXPOSICIONES(Id_Exposicion))

update OBRAS set DuracionResumida = 10 where Id_Obra = 1
update OBRAS set DuracionResumida = 6 where Id_Obra = 2
update OBRAS set DuracionResumida = 2 where Id_Obra = 3
update OBRAS set DuracionResumida = 10 where Id_Obra = 4
update OBRAS set DuracionResumida = 11 where Id_Obra = 5
update OBRAS set DuracionResumida = 11 where Id_Obra = 6
update OBRAS set DuracionResumida = 7 where Id_Obra = 7
update OBRAS set DuracionResumida = 8 where Id_Obra = 8
update OBRAS set DuracionResumida = 10 where Id_Obra = 9
update OBRAS set DuracionResumida = 20 where Id_Obra = 10
update OBRAS set DuracionResumida = 15 where Id_Obra = 11
update OBRAS set DuracionResumida = 15 where Id_Obra = 12
update OBRAS set DuracionResumida = 15 where Id_Obra = 13

update OBRAS set DuracionExtendida = 10 where Id_Obra = 1
update OBRAS set DuracionExtendida = 6 where Id_Obra = 2
update OBRAS set DuracionExtendida = 2 where Id_Obra = 3
update OBRAS set DuracionExtendida = 10 where Id_Obra = 4
update OBRAS set DuracionExtendida = 11 where Id_Obra = 5
update OBRAS set DuracionExtendida = 11 where Id_Obra = 6
update OBRAS set DuracionExtendida = 7 where Id_Obra = 7
update OBRAS set DuracionExtendida = 8 where Id_Obra = 8
update OBRAS set DuracionExtendida = 10 where Id_Obra = 9
update OBRAS set DuracionExtendida = 20 where Id_Obra = 10
update OBRAS set DuracionExtendida = 15 where Id_Obra = 11
update OBRAS set DuracionExtendida = 15 where Id_Obra = 12
update OBRAS set DuracionExtendida = 15 where Id_Obra = 13

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 1)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 2)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 3)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 4)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 5)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 6)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 7)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 8)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 9)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (1, 10)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 1)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 3)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 5)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 7)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 8)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 10)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 11)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 12)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (2, 13)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 1)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 2)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 3)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 4)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 5)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 6)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 7)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 8)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 9)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 10)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 11)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 12)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (3, 13)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (4, 1)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (4, 2)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (4, 3)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (4, 11)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (4, 12)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (4, 13)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (5, 1)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (5, 2)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (5, 3)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (5, 12)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (6, 5)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (6, 6)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (6, 7)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (6, 8)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (6, 13)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (7, 10)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (7, 11)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (7, 12)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (7, 13)

insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (8, 5)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (8, 9)
insert into OBRASPOREXPOSICION(Id_Exposicion, Id_Obra) values (8, 10)

------------------------------------------------------------------------------------------------------------------------------------
-- Si hay más de tres asignaciones en la tabla ASIGNACIONESVISITA borrar las que sobran
-- Si hay más de tres reservas en la tabla RESERVAS borrar las que sobran
-- Borrar primero las reservas sino se van a generar conflictos de llaves

create table ASIGNACIONESVISITAPORRESERVA
	(Id_AsignacionVisitaPorReserva int identity(1, 1) not null primary key,
	 Id_AsignacionVisita int,
	 Id_Reserva int,
	 constraint FK_ASIGNACIONESVISITA1 foreign key (Id_AsignacionVisita) references ASIGNACIONESVISITA(Id_AsignacionVisita),
	 constraint FK_RESERVAS0 foreign key (Id_Reserva) references RESERVAS(Id_Reserva))

alter table RESERVAS drop constraint FK_ASIGNACIONESVISITA0
alter table RESERVAS drop column Id_AsignacionVisita

set identity_insert ASIGNACIONESVISITAPORRESERVA on
insert into ASIGNACIONESVISITAPORRESERVA (Id_AsignacionVisitaPorReserva, Id_AsignacionVisita, Id_Reserva) values(1, 1, 1)
insert into ASIGNACIONESVISITAPORRESERVA (Id_AsignacionVisitaPorReserva, Id_AsignacionVisita, Id_Reserva) values(2, 2, 2)
insert into ASIGNACIONESVISITAPORRESERVA (Id_AsignacionVisitaPorReserva, Id_AsignacionVisita, Id_Reserva) values(3, 3, 3)
set identity_insert ASIGNACIONESVISITAPORRESERVA off

alter table RESERVAS add HoraReserva time(0)
update RESERVAS set HoraReserva = '15:30' where Id_Reserva = 1
update RESERVAS set HoraReserva = '10:00' where Id_Reserva = 2
update RESERVAS set HoraReserva = '16:00' where Id_Reserva = 3

------------------------------------------------------------------------------------------------------------------------------------------------
alter table HORARIOSTRABAJOS alter column HoraEntrada time(0)
alter table HORARIOSTRABAJOS alter column HoraSalida time(0)

----------------------------------------------------------------------------------------------------------------------------------
alter table RESERVAS drop constraint FK_CAMBIOSESTADOS
alter table RESERVAS drop column Id_CambioEstado

alter table RESERVAS drop constraint FK_EXPOSICION0
alter table RESERVAS drop column Id_Exposicion

alter table RESERVAS add FechaReserva date

create table CAMBIOSESTADOSPORRESERVA
	(Id_CambioEstadoPorReserva int identity(1, 1) not null primary key,
	 Id_Reserva int,
	 Id_CambioEstado int,
	 constraint FK_RESERVAS1 foreign key (Id_Reserva) references RESERVAS(Id_Reserva),
	 constraint FK_CAMBIOSESTADOS0 foreign key (Id_CambioEstado) references CAMBIOSESTADOS(Id_CambioEstado))

create table EXPOSICIONESPORRESERVA
	(Id_ExposicionPorReserva int identity(1, 1) not null primary key,
	 Id_Reserva int,
	 Id_Exposicion int,
	 constraint FK_RESERVAS2 foreign key(Id_Reserva) references RESERVAS(Id_Reserva),
	 constraint FK_EXPOSICIONES2 foreign key (Id_Exposicion) references EXPOSICIONES(Id_Exposicion))


set identity_insert CAMBIOSESTADOSPORRESERVA on
insert into CAMBIOSESTADOSPORRESERVA (Id_CambioEstadoPorReserva, Id_Reserva, Id_CambioEstado) values(1, 1, 1)
insert into CAMBIOSESTADOSPORRESERVA (Id_CambioEstadoPorReserva, Id_Reserva, Id_CambioEstado) values(2, 2, 2)
insert into CAMBIOSESTADOSPORRESERVA (Id_CambioEstadoPorReserva, Id_Reserva, Id_CambioEstado) values(3, 3, 3)
set identity_insert CAMBIOSESTADOSPORRESERVA off

set identity_insert EXPOSICIONESPORRESERVA on
insert into EXPOSICIONESPORRESERVA (Id_ExposicionPorReserva, Id_Reserva, Id_Exposicion) values(1, 1, 1)
insert into EXPOSICIONESPORRESERVA (Id_ExposicionPorReserva, Id_Reserva, Id_Exposicion) values(2, 2, 4)
insert into EXPOSICIONESPORRESERVA (Id_ExposicionPorReserva, Id_Reserva, Id_Exposicion) values(3, 3, 8)
set identity_insert EXPOSICIONESPORRESERVA off

alter table RESERVAS add NroReserva int
update RESERVAS set NroReserva = 1 where Id_Reserva = 1
update RESERVAS set NroReserva = 2 where Id_Reserva = 2
update RESERVAS set NroReserva = 3 where Id_Reserva = 3
alter table RESERVAS add constraint UC_NRORESERVA unique (NroReserva)

---------------------------------------------------------------------------------------------------------------------------------------------
alter table SEDES drop constraint FK_EXPOSICIONES0
alter table SEDES drop column Id_Exposicion

create table EXPOSICIONESPORSEDE
	(Id_ExposicionPorSede int identity(1, 1) not null primary key,
	Id_Exposicion int,
	Id_Sede int,
	constraint FK_EXPOSICIONES0 foreign key (Id_Exposicion) references EXPOSICIONES(Id_Exposicion),
	constraint FK_SEDES1 foreign key (Id_Sede) references SEDES(Id_sede))

set identity_insert EXPOSICIONESPORSEDE on
insert into EXPOSICIONESPORSEDE (Id_ExposicionPorSede, Id_Sede, Id_Exposicion) values(1, 1, 1)
insert into EXPOSICIONESPORSEDE (Id_ExposicionPorSede, Id_Sede, Id_Exposicion) values(2, 2, 2)
insert into EXPOSICIONESPORSEDE (Id_ExposicionPorSede, Id_Sede, Id_Exposicion) values(3, 3, 3)
insert into EXPOSICIONESPORSEDE (Id_ExposicionPorSede, Id_Sede, Id_Exposicion) values(4, 4, 4)
insert into EXPOSICIONESPORSEDE (Id_ExposicionPorSede, Id_Sede, Id_Exposicion) values(5, 5, 7)
set identity_insert EXPOSICIONESPORSEDE off

-----------------------------------------------------------------------------------------------------------------
alter table EMPLEADOS add Id_Sede int
alter table EMPLEADOS add constraint FK_SEDES2 foreign key (Id_Sede) references SEDES(Id_Sede)

update EMPLEADOS set Id_Sede = 2 where Id_Empleado = 1
update EMPLEADOS set Id_Sede = 1 where Id_Empleado = 2
update EMPLEADOS set Id_Sede = 3 where Id_Empleado = 3
update EMPLEADOS set Id_Sede = 4 where Id_Empleado = 4
update EMPLEADOS set Id_Sede = 5 where Id_Empleado = 5

----------------------------------------------------------------------------------------------------------
-- Más datos de empleados
set identity_insert EMPLEADOS on
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (6, 'Roman', 'Mansilla', '487880', 24190558473, 19055847, 'Uruguay 491', '2015-09-21', '1974-10-13', 'romanmansi@gmail.com', 'Masculino', 3518956587, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (7, 'Julia', 'Alvarez', '487881', 22204926813, 20492681, 'San Martin 478', '2010-12-23', '1969-01-06', 'julialva@gmail.com', 'Femenino', 3514568899, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (8, 'Ramón', 'Luis', '487882', 24432113543, 43211354, 'Roca 896', '2020-01-21', '2002-03-15', 'ramluis@gmail.com', 'Masculino', 3512356532, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (9, 'Maximiliano', 'Villanueva', '487883', 24391310363, 39131036, 'Boulevard Illia 455', '2018-05-01', '1997-03-03', 'maxivilla@gmail.com', 'Masculino', 3514785263, 13, 1, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (10, 'Camila', 'Fuentes', '487884', 24332262483, 33226248, 'Obispo Oro 758', '2009-10-01', '1985-12-15', 'camifuentes@gmail.com', 'Femenino', 3511569874, 13, 1, 2)
set identity_insert EMPLEADOS off

---------------------------------------------------------------------------------------------------------
drop table SESION
create table SESIONES
	(Id_Sesion int identity(1, 1) not null primary key,
	 FechaHoraInicio datetime,
	 FechaHoraFin datetime,
	 Id_Usuario int,
	 constraint FK_USUARIOS0 foreign key (Id_Usuario) references USUARIOS(Id_Usuario))

-----------------------------------------------------------------------------------------------------------
alter table ESTADOS add Ambito varchar(50)
update ESTADOS set Ambito = 'Reservas' where Id_Estado = 1

set identity_insert ESTADOS on
insert into ESTADOS(Id_Estado, Nombre, Descripcion, Ambito) values (2, 'Programada', 'Se registra una nueva reserva', 'Reservas')
set identity_insert ESTADOS off




