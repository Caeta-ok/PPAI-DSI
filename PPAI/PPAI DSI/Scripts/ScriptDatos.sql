use PPAI_DSI

-------------------- insert usuario-------------------- si
set identity_insert USUARIOS on
INSERT INTO USUARIOS(Id_Usuario, Nombre, Contrasenia) VALUES (1, 'PPAI', 'DSI')
set identity_insert USUARIOS off

-------------------- insert escuela-------------------- si
set identity_insert ESCUELAS on
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (1, 'Lasalle', 'lasalle@gmail.com', 'Lasalle 150', 3513478441)
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (2, 'Monserrat', 'monserrat@gmail.com', 'Caballito 456', 3513474778)
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (3, 'Belgrano', 'belgrano@gmail.com', 'Colon 1542', 3513478874)
INSERT INTO ESCUELAS(Id_Escuela, Nombre, Email, Domicilio, NroTelefono) VALUES (4, 'Ipem 54', 'ipem54@gmail.com', 'Don bosco 47', 3513478978)
set identity_insert ESCUELAS off
--------------------  Insert Sesion -------------------- si

--INSERT INTO SESION(Id_Sesion, FechaInicio, FechaFin, HoraFin, HoraInicio) VALUES (1,'Plato Principal', '', '', '')
--INSERT INTO SESION(Id_Sesion, FechaInicio, FechaFin, HoraFin, HoraInicio) VALUES (1,'Plato Principal', '', '', '')
--INSERT INTO SESION(Id_Sesion, FechaInicio, FechaFin, HoraFin, HoraInicio) VALUES (1,'Plato Principal', '', '', '')
--INSERT INTO SESION(Id_Sesion, FechaInicio, FechaFin, HoraFin, HoraInicio) VALUES (1,'Plato Principal', '', '', '')
--INSERT INTO SESION(Id_Sesion, FechaInicio, FechaFin, HoraFin, HoraInicio) VALUES (1,'Plato Principal', '', '', '')
--INSERT INTO SESION(Id_Sesion, FechaInicio, FechaFin, HoraFin, HoraInicio) VALUES (1,'Plato Principal', '', '', '')

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
INSERT INTO CARGOS(Id_Cargo, Nombre, Descripcion) VALUES (13, 'Administrador de Usuarios', 'Responsable de la Administración de los datos de los usuarios y perfiles con acceso al sistema.')
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

--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (1, '8:30:00', '14:30:00', 1)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (2, '8:30:00', '14:30:00', 2)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (3, '8:30:00', '14:30:00', 3)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (4, '8:30:00', '14:30:00', 4)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (5, '8:30:00', '14:30:00', 5)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (6, '8:30:00', '14:30:00', 6)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (7, '14:30:00', '21:30:00', 1)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (8, '14:30:00', '21:30:00', 2)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (10, '14:30:00', '21:30:00', 3)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (11, '14:30:00', '21:30:00', 4)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (12, '14:30:00', '21:30:00', 5)
--INSERT INTO HORARIOSTRABAJOS(Id_HorarioTrabajo, HoraEntrada, HoraSalida, Id_Dia) VALUES (12, '14:30:00', '21:30:00', 6)

---------------- Insert Empleados ------------------------ si

--INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioEntrada, Id_HorarioSalida) VALUES (1, 'Juan', 'Perez', '487875', 24354587893, 35458789, 'Las heras 547', '21-10-2002', '14-05-1982', 'juanP@gmail.com', 'Masculino', 3513697885, 5, 1, 1)
--INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioEntrada, Id_HorarioSalida) VALUES (2, 'Maria', 'Juarez', '487876', 22384587893, 38458789, 'Dean Funes 75', '21-12-2005', '10-05-1986', 'MariaJ@gmail.com', 'Femenino', 3513697884, 5, 2, 2)
--INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioEntrada, Id_HorarioSalida) VALUES (3, 'Roberto', 'Foden', '487877', 24424587893, 42458789, 'San martin 7', '21-01-2020', '11-02-1999', 'RobertoF@gmail.com', 'Masculino', 3513697889, 7, 1, 1)
--INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioEntrada, Id_HorarioSalida) VALUES (4, 'Paula', 'Funes', '487878', 24364587893, 36458789, 'Malvinas 57', '21-05-2008', '09-03-1989', 'Paula@gmail.com', 'Femenino', 3513697881, 7, 2, 2)
--INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioEntrada, Id_HorarioSalida) VALUES (5, 'Mario', 'Arcuci', '487879', 24344587893, 34458789, 'Salta 557', '01-10-2009', '03-11-1992', 'Mario@gmail.com', 'Masculino', 3513697882, 5, 1, 2)
set identity_insert EMPLEADOS on
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo) VALUES (1, 'Juan', 'Perez', '487875', 24354587893, 35458789, 'Las heras 547', '2002-10-21', '1982-05-14', 'juanP@gmail.com', 'Masculino', 3513697885, 5, 1)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo) VALUES (2, 'Maria', 'Juarez', '487876', 22384587893, 38458789, 'Dean Funes 75', '2005-12-21', '1986-05-10', 'MariaJ@gmail.com', 'Femenino', 3513697884, 5, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo) VALUES (3, 'Roberto', 'Foden', '487877', 24424587893, 42458789, 'San martin 7', '2020-01-21', '1999-02-11', 'RobertoF@gmail.com', 'Masculino', 3513697889, 7, 1)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo) VALUES (4, 'Paula', 'Funes', '487878', 24364587893, 36458789, 'Malvinas 57', '2008-05-21', '1989-03-09', 'Paula@gmail.com', 'Femenino', 3513697881, 7, 2)
INSERT INTO EMPLEADOS(Id_Empleado, Nombre, Apellido, CodigoValidacion, Cuit, Dni, Domicilio, FechaIngreso, FechaNacimiento, Email, Sexo, NroTelefono, Id_Cargo, Id_HorarioTrabajo) VALUES (5, 'Mario', 'Arcuci', '487879', 24344587893, 34458789, 'Salta 557', '2009-10-01', '1992-11-03', 'Mario@gmail.com', 'Masculino', 3513697882, 5, 1)
set identity_insert EMPLEADOS off

---------------- Insert TipoVisita ------------------------ si
set identity_insert TIPOSVISITA on
INSERT INTO TIPOSVISITA(Id_TipoVisita, Nombre) VALUES (1, 'Completa')
INSERT INTO TIPOSVISITA(Id_TipoVisita, Nombre) VALUES (2, 'Por exposicion')
set identity_insert TIPOSVISITA off

---------------- Insert Obra ------------------------ si
set identity_insert OBRAS on
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (1, 'Mona Lisa', '1885-11-14', '2000-07-24', 'Pintura destacada Mona Lisa', '5 meses', '2 meses', 145, 125, 82, 15000000, 145)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (2, 'Mona llorona', '1889-10-14', '2000-07-24', 'Pintura destacada Mona Llorona', '2 meses', '1 meses', 14, 125, 8, 12000, 198)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (3, 'Mono Liso', '1895-01-11', '1895-01-11', 'Pintura destacada Mono Liso', '8 meses', '5 meses', 145, 12, 6, 2400, 475)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (4, 'Grecia', '1985-01-18', '1985-01-18', 'Pintura destacada Grecia', '15 meses', '7 meses', 145, 15, 72, 87000, 985)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (5, 'Taiwan', '2015-12-14', '2015-12-14', 'Pintura destacada Taiwan', '87 meses', '22 meses', 14, 25, 92, 46540, 135)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (6, 'Mon', '1995-12-14', '1995-12-14', 'Pintura destacada Mon', '58 meses', '25 meses', 45, 12, 44, 45645, 1985)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (7, 'Monsa', '1985-11-15', '1985-11-15', 'Pintura destacada Monsa', '47 meses', '45 meses', 15, 14, 98, 4546, 365)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (8, 'MoLi', '2002-11-14', '2003-11-14', 'Pintura destacada Moli', '5 meses', '2 meses', 145, 198, 65, 97454, 175)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (9, 'Movi', '2003-11-14', '2004-11-14', 'Pintura destacada Movi', '7 meses', '3 meses', 145, 47, 25, 48470, 1975)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (10, 'Aral', '2002-11-14', '2003-11-14', 'Pintura destacada Aral', '14 meses', '7 meses', 145, 125, 25, 64500, 4789)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (11, 'Carmesi', '2003-11-14', '2004-11-14', 'Pintura destacada Carmesi', '53 meses', '22 meses', 145, 25, 56, 540, 8887)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (12, 'Casa', '2004-07-02', '2006-07-02', 'Pintura destacada Casa', '21 meses', '9 meses', 14, 125, 62, 4545, 999)
INSERT INTO OBRAS(Id_Obra, Nombre, FechaCreacion, FechaPrimerIngreso, Descripcion, DuracionExtendida, DuracionResumida, Alto, Ancho, Peso, Valuacion, CodigoSensor) VALUES (13, 'Auto', '1885-01-21', '1898-01-21', 'Pintura destacada Auto', '7 meses', '3 meses', 145, 25, 82, 445757, 364)
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
INSERT INTO DETALLESEXPOSICION(Id_DetalleExposicion, LugarAsignado) VALUES (1, 'Pared 2')
INSERT INTO DETALLESEXPOSICION(Id_DetalleExposicion, LugarAsignado) VALUES (2, 'Pared 5')
INSERT INTO DETALLESEXPOSICION(Id_DetalleExposicion, LugarAsignado) VALUES (3, 'Pared 9')
INSERT INTO DETALLESEXPOSICION(Id_DetalleExposicion, LugarAsignado) VALUES (4, 'Pared 4')
INSERT INTO DETALLESEXPOSICION(Id_DetalleExposicion, LugarAsignado) VALUES (5, 'Pared 2')
set identity_insert DETALLESEXPOSICION off

------------------ Insert TipoExposicion -------------- si
set identity_insert TIPOSEXPOSICION on
INSERT INTO TIPOSEXPOSICION(Id_TipoExposicion, Nombre, Descripcion) VALUES (1, 'Permanente', 'tienen vigencia durante varios meses y pueden ser visitadas dentro de los Horarios de atención de cada sede.')
INSERT INTO TIPOSEXPOSICION(Id_TipoExposicion, Nombre, Descripcion) VALUES (2, 'Temporal', 'tienen vigencia durante pocos días y pueden ser visitadas sólo en determinados Horarios.')
set identity_insert TIPOSEXPOSICION off
---------------- Insert Exposicion ------------------------ si

--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (1, 'La moderna', '05-07-2021', '05-07-2021', '05-08-2021', '05-07-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (2, 'Contemporanea', '10-08-2021', '10-08-2021', '10-09-2021', '10-09-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (3, 'Clasica', '15-08-2021', '15-08-2021', '15-10-2021', '15-10-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (4, 'Corriente', '05-06-2021', '05-06-2021', '05-08-2021', '05-08-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (5, 'Callejera', '20-09-2021', '20-09-2021', '20-11-2021', '20-11-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (6, 'Movil', '14-05-2021', '14-05-2021', '14-07-2021', '14-07-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (7, 'Indu', '16-05-2021', '16-05-2021', '16-09-2021', '16-09-2021', '8:30:00', '21:30:00')
--INSERT INTO EXPOSICION(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre) VALUES (8, 'Roma', '18-03-2021', '18-03-2021', '18-12-2021', '18-12-2021', '8:30:00', '21:30:00')
set identity_insert EXPOSICIONES on
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (1, 'La moderna', '2021-05-05', '2021-05-05', '2021-08-05', '2021-07-05', '8:30:00', '21:30:00', 1, 1, 1)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (2, 'Contemporanea', '2021-08-10', '2021-08-10', '2021-09-10', '2021-09-10', '8:30:00', '21:30:00', 2, 2, 2)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (3, 'Clasica', '2021-08-15', '2021-08-15', '2021-10-15', '2021-10-15', '8:30:00', '21:30:00', 1, 3, 3)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (4, 'Corriente', '2021-06-05', '2021-06-05', '2021-08-05', '2021-08-05', '8:30:00', '21:30:00', 2, 4, 4)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (5, 'Callejera', '2021-09-20', '2021-09-20', '2021-11-20', '2021-11-20', '8:30:00', '21:30:00', 1, 5, 5)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (6, 'Movil', '2021-05-14', '2021-05-14', '2021-07-14', '2021-07-14', '8:30:00', '21:30:00', 2, 1, 6)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (7, 'Indu', '2021-05-16', '2021-05-16', '2021-09-16', '2021-09-16', '8:30:00', '21:30:00', 1, 2, 1)
INSERT INTO EXPOSICIONES(Id_Exposicion, Nombre, FechaInicio, FechaInicioReplanificada, FechaFin, FechaFinReplanificada, HoraApertura, HoraCierre, Id_TipoExposicion, Id_DetalleExposicion, Id_PublicoDestino) VALUES (8, 'Roma', '2021-03-18', '2021-03-18', '2021-12-18', '2021-12-18', '8:30:00', '21:30:00', 2, 3, 2)
set identity_insert EXPOSICIONES off

--------------- Insert AsigancionVisita---------------- si
set identity_insert ASIGNACIONESVISITA on
--INSERT INTO ASIGNACIONVISITA(Id_AsignacionVisita, FechaHoraInicio, FechaHoraFin) VALUES (1, '13-06-2021 18:00:00', '13-06-2021 19:00:00')
--INSERT INTO ASIGNACIONVISITA(Id_AsignacionVisita, FechaHoraInicio, FechaHoraFin) VALUES (2, '14-05-2021 17:00:00', '14-05-2021 18:00:00')
--INSERT INTO ASIGNACIONVISITA(Id_AsignacionVisita, FechaHoraInicio, FechaHoraFin) VALUES (3, '05-06-2021 21:00:00', '05-06-2021 22:00:00')

-- Lo cambio para coincidan los horarios con los horarios de las reservas
INSERT INTO ASIGNACIONESVISITA(Id_AsignacionVisita, FechaHoraInicio, FechaHoraFin) VALUES (1, '2021-06-13 14:30:00', '2021-06-13 18:00:00')
INSERT INTO ASIGNACIONESVISITA(Id_AsignacionVisita, FechaHoraInicio, FechaHoraFin) VALUES (2, '2021-05-14 08:30:00', '2021-05-14 14:30:00')
INSERT INTO ASIGNACIONESVISITA(Id_AsignacionVisita, FechaHoraInicio, FechaHoraFin) VALUES (3, '2021-06-05 14:30:00', '2021-06-05 17:00:00')
set identity_insert ASIGNACIONESVISITA off

---------------- Insert Sede ------------------------ si
set identity_insert SEDES on
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia, Id_Exposicion) VALUES (1, 'Alvear', 50, 25, 1)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia, Id_Exposicion) VALUES (2, 'Carlos Paz', 100, 20, 3)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia, Id_Exposicion) VALUES (3, 'Villa Cabrera', 200, 40, 4)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia, Id_Exposicion) VALUES (4, 'San Carlos', 50, 10, 6)
INSERT INTO SEDES(Id_Sede, Nombre, CantidadMaximaVisitantes, CantidadMaximaPorGuia, Id_Exposicion) VALUES (5, 'Materos', 500, 50, 8)
set identity_insert SEDES off

---------------- Insert Estado ------------------------ si
set identity_insert ESTADOS on
INSERT INTO ESTADOS(Id_Estado, Nombre, Descripcion) VALUES (1, 'Pendiente de confirmacion', 'Se encuentra en el momento anterior a ser confirmada')
set identity_insert ESTADOS off

---------------- Insert CambioEstado ------------------------ si
set identity_insert CAMBIOSESTADOS on
INSERT INTO CAMBIOSESTADOS(Id_CambioEstado, FechaHoraInicio, FechaHoraFin) VALUES (1, '2021-06-13 18:00:00', '2021-06-13 19:00:00')
INSERT INTO CAMBIOSESTADOS(Id_CambioEstado, FechaHoraInicio, FechaHoraFin) VALUES (2, '2021-05-14 17:00:00', '2021-05-14 18:00:00')
INSERT INTO CAMBIOSESTADOS(Id_CambioEstado, FechaHoraInicio, FechaHoraFin) VALUES (3, '2021-06-05 21:00:00', '2021-06-05 22:00:00')
set identity_insert CAMBIOSESTADOS off

---------------- Insert Reserva ------------------------ si
set identity_insert RESERVAS on
--INSERT INTO RESERVA(Id_Reserva, DuracionEstimada, FechaHoraCreacion, FechaHoraReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados) VALUES (1, '5 horas', '13-06-2021 18:00:00', '15-06-2021 13:00:00', '13:30:00', '18:00:00', 48, 45)
--INSERT INTO RESERVA(Id_Reserva, DuracionEstimada, FechaHoraCreacion, FechaHoraReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados) VALUES (2, '8 horas', '10-06-2021 09:00:00', '25-06-2021 08:00:00', '08:30:00', '16:30:00', 150, 145)
--INSERT INTO RESERVA(Id_Reserva, DuracionEstimada, FechaHoraCreacion, FechaHoraReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados) VALUES (3, '2 horas', '09-06-2021 15:00:00', '02-07-2021 12:00:00', '12:00:00', '14:00:00', 16, 16)

INSERT INTO RESERVAS(Id_Reserva, DuracionEstimada, FechaHoraCreacion, FechaHoraReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados, Id_Sede, Id_AsignacionVisita, Id_Exposicion, Id_Empleado, Id_CambioEstado)
VALUES (1, '5 horas', '2021-06-13 18:00:00', '2021-06-15 13:00:00', '14:30:00', '18:00:00', 48, 45, 1, 1, 1, 2, 1)

INSERT INTO RESERVAS(Id_Reserva, DuracionEstimada, FechaHoraCreacion, FechaHoraReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados, Id_Sede, Id_AsignacionVisita, Id_Exposicion, Id_Empleado, Id_CambioEstado)
VALUES (2, '8 horas', '2021-06-10 09:00:00', '2021-06-25 08:00:00', '08:30:00', '14:30:00', 150, 145, 3, 2, 4, 3, 2)

INSERT INTO RESERVAS(Id_Reserva, DuracionEstimada, FechaHoraCreacion, FechaHoraReserva, HoraInicioReal, HoraFinReal, CantidadAlumnos, CantidadAlumnosConfirmados, Id_Sede, Id_AsignacionVisita, Id_Exposicion, Id_Empleado, Id_CambioEstado)
VALUES (3, '2 horas', '2021-06-09 15:00:00', '2021-07-02 12:00:00', '14:30:00', '17:00:00', 16, 16, 5, 3, 7, 4, 3)

