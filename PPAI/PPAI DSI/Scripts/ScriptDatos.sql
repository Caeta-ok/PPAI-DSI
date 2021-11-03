--use PPAI_DSI

-------------------- insert escuela-------------------- si
set identity_insert ESCUELAS on
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (1, 'Lasalle', 'lasalle@gmail.com', 'Lasalle 150', 3513478441)
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (2, 'Monserrat', 'monserrat@gmail.com', 'Caballito 456', 3513474778)
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (3, 'Belgrano', 'belgrano@gmail.com', 'Colon 1542', 3513478874)
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (4, 'Ipem 54', 'ipem54@gmail.com', 'Don bosco 47', 3513478978)
set identity_insert ESCUELAS off

------------------- Insert Cargos --------------------------------- si
set identity_insert CARGOS on
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (1, 'Responsable de Obras', 'Persona responsable de registrar la adquisición de las Obras, y la parametrización de la información necesaria para su administración.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (2, 'Responsable de Infraestructura', 'Persona responsable de la registración de las sedes y su estructura física.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (3, 'Responsable de Préstamos', 'Responsable de gestionar los préstamos de Obras tanto de Artistas como a otros Museos.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (4, 'Administrador de Exposiciones', 'Cualquier persona con permisos de acceso a la aplicación.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (5, 'Página Web Asociadas', 'Páginas Web de organizaciones que desean publicar información de las exposiciones del museo que acceden a un Web Service que el sistema crea.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (6, 'Visitante virtual', 'Usuario con permisos para realizar visitas virtuales a través de la página web.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (7, 'Responsable de Visitas', 'Persona responsable de la gestión de las vistas programadas y de reservas de estas.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (8, 'Servidor de WhatsApp', 'Software con el que se establece la comunicación para notificar a las escuelas la confirmación de la reserva medianteun mensaje de WhatsApp.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (9, 'Servidor de Correo', 'Software con el que se establece la comunicación para notificar a las escuelas la confirmación de la reserva mediante un email.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (10, 'Responsable de Ventas', 'Encargado de las ventas de entradas y de la parametrización de la información necesaria para dicha gestión.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (11, 'Administrador de RR HH', 'Encargado de la administración de información de los empleados.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (12, 'Consultor de Guías', 'Rol que realiza la consulta de la disponibilidad de Guías.')
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (13, 'Guía', 'Encargado de realizar los recorridos.')
set identity_insert CARGOS off

---------------- Insert dias ------------------------ si
set identity_insert DIAS on
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (1, 'Domingo')
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (2, 'Lunes')
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (3, 'Martes')
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (4, 'Miercoles')
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (5, 'Jueves')
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (6, 'Viernes')
INSERT INTO DIAS(Id_Dia, Nombre) VALUES (7, 'Sabado')
set identity_insert DIAS off

------------------Insert HorarioTrabajo--------------------------------- si
set identity_insert HORARIOSTRABAJOS on
INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida) VALUES (1, '8:30:00', '14:30:00')
INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida) VALUES (2, '14:30:00', '21:30:00')
set identity_insert HORARIOSTRABAJOS off

---------------- Insert Sede ------------------------ si
set identity_insert SEDES on
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia) VALUES (1, 'Alvear', 50, 25)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia) VALUES (2, 'Carlos Paz', 100, 20)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia) VALUES (3, 'Villa Cabrera', 200, 40)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia) VALUES (4, 'San Carlos', 50, 10)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia) VALUES (5, 'Materos', 500, 50)
set identity_insert SEDES off

---------------- Insert Empleados ------------------------ si
set identity_insert EMPLEADOS on
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (1, 'Juan', 'Perez', '487875', 24354587893, 35458789, 'Las heras 547', '2002-10-21', '1982-05-14', 'juanP@gmail.com', 'Masculino', 3513697885, 5, 1, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (2, 'Maria', 'Juarez', '487876', 22384587893, 38458789, 'Dean Funes 75', '2005-12-21', '1986-05-10', 'MariaJ@gmail.com', 'Femenino', 3513697884, 5, 2, 1)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (3, 'Roberto', 'Foden', '487877', 24424587893, 42458789, 'San martin 7', '2020-01-21', '1999-02-11', 'RobertoF@gmail.com', 'Masculino', 3513697889, 7, 1, 3)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (4, 'Paula', 'Funes', '487878', 24364587893, 36458789, 'Malvinas 57', '2008-05-21', '1989-03-09', 'Paula@gmail.com', 'Femenino', 3513697881, 7, 2, 4)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (5, 'Mario', 'Arcuci', '487879', 24344587893, 34458789, 'Salta 557', '2009-10-01', '1992-11-03', 'Mario@gmail.com', 'Masculino', 3513697882, 5, 1, 5)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (6, 'Roman', 'Canquel', '487880', 24190558473, 19055847, 'Uruguay 491', '2015-09-21', '1974-10-13', 'romancanca@gmail.com', 'Masculino', 3518956587, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (7, 'Julia', 'Alvarez', '487881', 22204926813, 20492681, 'San Martin 478', '2010-12-23', '1969-01-06', 'julialva@gmail.com', 'Femenino', 3514568899, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (8, 'Ramón', 'Luis', '487882', 24432113543, 43211354, 'Roca 896', '2020-01-21', '2002-03-15', 'ramluis@gmail.com', 'Masculino', 3512356532, 13, 2, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (9, 'Maximiliano', 'Villanueva', '487883', 24391310363, 39131036, 'Boulevard Illia 455', '2018-05-01', '1997-03-03', 'maxivilla@gmail.com', 'Masculino', 3514785263, 13, 1, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo, Id_Sede) VALUES (10, 'Camila', 'Fuentes', '487884', 24332262483, 33226248, 'Obispo Oro 758', '2009-10-01', '1985-12-15', 'camifuentes@gmail.com', 'Femenino', 3511569874, 13, 1, 2)
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

-------------------- insert usuario-------------------- si
set identity_insert USUARIOS on
INSERT INTO USUARIOS(Id_Usuario, Nombre, Contrasenia, Id_Empleado) VALUES (1, 'PPAI', 'DSI', 4)
set identity_insert USUARIOS off

---------------- Insert TipoVisita ------------------------ si
set identity_insert TIPOSVISITA on
INSERT INTO TIPOSVISITA(Id_TipoVisita, Nombre) VALUES (1, 'Completa')
INSERT INTO TIPOSVISITA(Id_TipoVisita, Nombre) VALUES (2, 'Por exposicion')
set identity_insert TIPOSVISITA off

---------------- Insert Obra ------------------------ si
set identity_insert OBRAS on
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (1, 'Mona Lisa', '1885-11-14', '2000-07-24', 'Pintura destacada Mona Lisa', 15, 10, 145, 125, 82, 15000000, 145)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (2, 'Mona llorona', '1889-10-14', '2000-07-24', 'Pintura destacada Mona Llorona', 8, 6, 14, 125, 8, 12000, 198)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (3, 'Mono Liso', '1895-01-11', '1895-01-11', 'Pintura destacada Mono Liso', 4, 2, 145, 12, 6, 2400, 475)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (4, 'Grecia', '1985-01-18', '1985-01-18', 'Pintura destacada Grecia', 13, 10, 145, 15, 72, 87000, 985)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (5, 'Taiwan', '2015-12-14', '2015-12-14', 'Pintura destacada Taiwan', 14, 11, 14, 25, 92, 46540, 135)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (6, 'Mon', '1995-12-14', '1995-12-14', 'Pintura destacada Mon', 13, 11, 45, 12, 44, 45645, 1985)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (7, 'Monsa', '1985-11-15', '1985-11-15', 'Pintura destacada Monsa', 9, 7, 15, 14, 98, 4546, 365)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (8, 'MoLi', '2002-11-14', '2003-11-14', 'Pintura destacada Moli', 10, 8, 145, 198, 65, 97454, 175)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (9, 'Movi', '2003-11-14', '2004-11-14', 'Pintura destacada Movi', 12, 10, 145, 47, 25, 48470, 1975)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (10, 'Aral', '2002-11-14', '2003-11-14', 'Pintura destacada Aral', 23, 20, 145, 125, 25, 64500, 4789)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (11, 'Carmesi', '2003-11-14', '2004-11-14', 'Pintura destacada Carmesi', 17, 15, 145, 25, 56, 540, 8887)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (12, 'Casa', '2004-07-02', '2006-07-02', 'Pintura destacada Casa', 18, 15, 14, 125, 62, 4545, 999)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (13, 'Auto', '1885-01-21', '1898-01-21', 'Pintura destacada Auto', 19, 15, 145, 25, 82, 445757, 364)
set identity_insert OBRAS off

---------------- Insert PublicoDestino ------------------------ si
set identity_insert PUBLICOSDESTINO on
INSERT INTO PUBLICOSDESTINO(Id_PublicoDestino, Caracteristicas, Nombre) VALUES (1, 'Personas mayores', 'Jubilados')
INSERT INTO PUBLICOSDESTINO(Id_PublicoDestino, Caracteristicas, Nombre) VALUES (2, 'Personas en momentos de estudio, en general', 'Estudiantes')
INSERT INTO PUBLICOSDESTINO(Id_PublicoDestino, Caracteristicas, Nombre) VALUES (3, 'Estudiosos de arte', 'Estudiantes de artes')
INSERT INTO PUBLICOSDESTINO(Id_PublicoDestino, Caracteristicas, Nombre) VALUES (4, 'Personas que participan en subastas', 'Compradores')
INSERT INTO PUBLICOSDESTINO(Id_PublicoDestino, Caracteristicas, Nombre) VALUES (5, 'Personas que realizan subastas', 'Vendedores')
INSERT INTO PUBLICOSDESTINO(Id_PublicoDestino, Caracteristicas, Nombre) VALUES (6, 'Cualquier publico', 'General')
set identity_insert PUBLICOSDESTINO off

---------------- Insert DetalleExposicion ------------------------ si
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

------------------ Insert TipoExposicion -------------- si
set identity_insert TIPOSEXPOSICION on
INSERT INTO TIPOSEXPOSICION(Id_TipoExposicion, Nombre, Descripcion) VALUES (1, 'Permanente', 'tienen vigencia durante varios meses y pueden ser visitadas dentro de los Horarios de atención de cada sede.')
INSERT INTO TIPOSEXPOSICION(Id_TipoExposicion, Nombre, Descripcion) VALUES (2, 'Temporal', 'tienen vigencia durante pocos días y pueden ser visitadas sólo en determinados Horarios.')
set identity_insert TIPOSEXPOSICION off

---------------- Insert Exposicion ------------------------ si
set identity_insert EXPOSICIONES on -----                                                                                                                                                                                                 Finicio      FiReplan       Ffin         FfReplan   Hapertura    HCierre                            
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (1, 'La moderna', '2021-05-05', '2021-05-05', '2100-08-05', '2100-12-30', '8:30:00', '21:30:00', 1, 1)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (2, 'Contemporanea', '2021-08-10', '2021-08-10', '2100-09-10', '2100-12-30', '8:30:00', '21:30:00', 2, 2)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (3, 'Clasica', '2021-08-15', '2021-08-15', '2100-10-15', '2100-12-30', '8:30:00', '21:30:00', 1, 3)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (4, 'Corriente', '2021-06-05', '2021-06-05', '2100-08-05', '2100-12-30', '8:30:00', '21:30:00', 2, 4)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (5, 'Callejera', '2021-09-20', '2021-09-20', '2100-11-20', '2100-12-30', '8:30:00', '21:30:00', 1, 5)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (6, 'Movil', '2021-05-14', '2021-05-14', '2100-07-14', '2100-12-30', '8:30:00', '21:30:00', 2, 6)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (7, 'Indu', '2021-05-16', '2021-05-16', '2100-09-16', '2100-12-30', '8:30:00', '21:30:00', 1, 1)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_PublicoDestino) VALUES (8, 'Roma', '2021-03-18', '2021-03-18', '2100-12-18', '2100-12-30', '8:30:00', '21:30:00', 2, 2)
set identity_insert EXPOSICIONES off

--------------- Insert AsigancionVisita---------------- si
set identity_insert ASIGNACIONESVISITA on
INSERT INTO ASIGNACIONESVISITA(Id_AsignacionVisita, FechaInicio, FechaFin, HoraInicio, HoraFin, Id_Empleado) VALUES (1, '2021-06-13', '2021-06-13', '14:30:00', '18:00:00', 1)
INSERT INTO ASIGNACIONESVISITA(Id_AsignacionVisita, FechaInicio, FechaFin, HoraInicio, HoraFin, Id_Empleado) VALUES (2, '2021-05-14', '2021-05-14', '08:30:00', '14:30:00', 3)
INSERT INTO ASIGNACIONESVISITA(Id_AsignacionVisita, FechaInicio, FechaFin, HoraInicio, HoraFin, Id_Empleado) VALUES (3, '2021-06-05', '2021-06-05', '14:30:00', '17:00:00', 5)
set identity_insert ASIGNACIONESVISITA off

---------------- Insert Estado ------------------------ si
set identity_insert ESTADOS on
INSERT INTO ESTADOS(Id_Estado, Nombre, Descripcion, Ambito) VALUES (1, 'Pendiente de confirmacion', 'Se encuentra en el momento anterior a ser confirmada', 'Reservas')
set identity_insert ESTADOS off

---------------- Insert CambioEstado ------------------------ si
set identity_insert CAMBIOSESTADOS on
INSERT INTO CAMBIOSESTADOS(Id_CambioEstado, FechaHoraInicio, FechaHoraFin, Id_Estado) VALUES (1, '2021-06-13 18:00:00', '2021-06-13 19:00:00', 1)
INSERT INTO CAMBIOSESTADOS(Id_CambioEstado, FechaHoraInicio, FechaHoraFin, Id_Estado) VALUES (2, '2021-05-14 17:00:00', '2021-05-14 18:00:00', 1)
INSERT INTO CAMBIOSESTADOS(Id_CambioEstado, FechaHoraInicio, FechaHoraFin, Id_Estado) VALUES (3, '2021-06-05 21:00:00', '2021-06-05 22:00:00', 1)
set identity_insert CAMBIOSESTADOS off

---------------- Insert Reserva ------------------------ si
set identity_insert RESERVAS on
INSERT INTO RESERVAS(Id_Reserva, FechaHoraCreacion, FechaReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados, Id_Sede, Id_Empleado, DuracionEstimada, HoraReserva, NroReserva, Id_Escuela)
VALUES(1, '2021-06-13', '2021-06-15', '14:30:00', '18:00:00', 48, 45, 1, 2, 60, '15:30:00', 1, 2)

INSERT INTO RESERVAS(Id_Reserva, FechaHoraCreacion, FechaReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados, Id_Sede, Id_Empleado, DuracionEstimada, HoraReserva, NroReserva, Id_Escuela)
VALUES(2, '2021-06-10', '2021-06-25', '08:30:00', '14:30:00', 150, 145, 3, 3, 120, '10:00:00', 2, 3)

INSERT INTO RESERVAS(Id_Reserva, FechaHoraCreacion, FechaReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados, Id_Sede, Id_Empleado, DuracionEstimada, HoraReserva, NroReserva, Id_Escuela)
VALUES(3, '2021-06-09', '2021-07-02', '14:30:00', '17:00:00', 16, 16, 5, 4, 50, '16:00:00', 3, 4)
set identity_insert RESERVAS off

---------------------- Insert DetallesPorExposicion ----------------------- si
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
set identity_insert DETALLESPOREXPOSICION off;

--------------------------------- insert AsignacionVisitaPorReserva ----------------------------------- si
set identity_insert ASIGNACIONESVISITAPORRESERVA on
insert into ASIGNACIONESVISITAPORRESERVA (Id_AsignacionVisitaPorReserva, Id_AsignacionVisita, Id_Reserva) values(1, 1, 1)
insert into ASIGNACIONESVISITAPORRESERVA (Id_AsignacionVisitaPorReserva, Id_AsignacionVisita, Id_Reserva) values(2, 2, 2)
insert into ASIGNACIONESVISITAPORRESERVA (Id_AsignacionVisitaPorReserva, Id_AsignacionVisita, Id_Reserva) values(3, 3, 3)
set identity_insert ASIGNACIONESVISITAPORRESERVA off

-------------------------------------- insert ExposicionPorSede -------------------------------------- si
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

-------------------------------------- insert CambioEstadoPorReserva -------------------------------- si
set identity_insert CAMBIOSESTADOSPORRESERVA on
insert into CAMBIOSESTADOSPORRESERVA (Id_CambioEstadoPorReserva, Id_Reserva, Id_CambioEstado) values(1, 1, 1)
insert into CAMBIOSESTADOSPORRESERVA (Id_CambioEstadoPorReserva, Id_Reserva, Id_CambioEstado) values(2, 2, 2)
insert into CAMBIOSESTADOSPORRESERVA (Id_CambioEstadoPorReserva, Id_Reserva, Id_CambioEstado) values(3, 3, 3)
set identity_insert CAMBIOSESTADOSPORRESERVA off

------------------------------------- insert ExposicionesPorReserva --------------------------------- si
set identity_insert EXPOSICIONESPORRESERVA on
insert into EXPOSICIONESPORRESERVA (Id_ExposicionPorReserva, Id_Reserva, Id_Exposicion) values(1, 1, 1)
insert into EXPOSICIONESPORRESERVA (Id_ExposicionPorReserva, Id_Reserva, Id_Exposicion) values(2, 2, 4)
insert into EXPOSICIONESPORRESERVA (Id_ExposicionPorReserva, Id_Reserva, Id_Exposicion) values(3, 3, 8)
set identity_insert EXPOSICIONESPORRESERVA off