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

