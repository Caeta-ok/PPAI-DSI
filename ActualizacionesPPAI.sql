--------------------------------------------------------------------------------------------------------------- Actualizaciones 26/09/2021
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








