using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Negocio;

namespace PPAI_DSI.Backend
{
    public static class Persistencia
    {
        public static List<Escuela> traerEscuelas()
        {
            List<Escuela> listaEscuelas = new List<Escuela>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var list = db.ESCUELAS;
                foreach (ESCUELAS esc in list)
                {
                    Escuela escNueva = new Escuela(esc);
                    listaEscuelas.Add(escNueva);
                }
            }
            return listaEscuelas;
        }

        public static List<Sede> traerSedesPorCapacidadVisitantes(int numeroVisitantes)
        {
            List<Sede> listaSedes = new List<Sede>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaSedesSql = (from sede in db.SEDES.ToList()
                                     where sede.CantidadMaximaVisitantes >= numeroVisitantes
                                     select new
                                     {
                                         sede.Id_Sede,
                                         sede.Nombre,
                                         sede.CantidadMaximaPorGuia,
                                         sede.CantidadMaximaVisitantes,
                                     }).ToList();

                foreach(var s in listaSedesSql)
                {
                    Sede sede = new Sede();
                    sede.setId(s.Id_Sede);
                    sede.setNombre(s.Nombre);
                    sede.setCantidadMaximaPorGuia(s.CantidadMaximaPorGuia.Value);
                    sede.setCantidadMaximaVisitantes(s.CantidadMaximaVisitantes.Value);

                    var listaExposPorSedeSql = db.EXPOSICIONESPORSEDE.Where(e => e.Id_Sede == s.Id_Sede);
                    foreach(var expoPorSedeSql in listaExposPorSedeSql)
                    {
                        Exposicion exposicion = traerExposicionPorId(expoPorSedeSql.Id_Exposicion.Value);
                        sede.conocerExposicion(exposicion);
                    }
                    listaSedes.Add(sede);
                }
            }
            return listaSedes;
        }

        public static List<TipoVisita> traerTipoVisita()
        {
            List<TipoVisita> listaTiposVisita = new List<TipoVisita>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaTiposVisitaSql = db.TIPOSVISITA;
                foreach(TIPOSVISITA tv in listaTiposVisitaSql)
                {
                    TipoVisita tipoVisita = new TipoVisita(tv);
                    listaTiposVisita.Add(tipoVisita);
                }
            }
            return listaTiposVisita;
        }

        public static Exposicion traerExposicionPorId(int Id_Exposicion)
        {
            Exposicion exposicion;
            DetalleExposicion detalleExposicion = new DetalleExposicion();
            TipoExposicion tipoExposicion;
            PublicoDestino publicoDestino;
            using (PPAIEntities db = new PPAIEntities())
            {
                EXPOSICIONES expoSql = db.EXPOSICIONES.Find(Id_Exposicion);
                TIPOSEXPOSICION tipoExpoSql = db.TIPOSEXPOSICION.Find(expoSql.Id_TipoExposicion);
                PUBLICOSDESTINO publicDestinoSql = db.PUBLICOSDESTINO.Find(expoSql.Id_PublicoDestino);
                var listaObrasPorExposicionSql = db.OBRASPOREXPOSICION.Where(ob => ob.Id_Exposicion == expoSql.Id_Exposicion);

                foreach(var ob in listaObrasPorExposicionSql)
                {
                    OBRAS obraSql = db.OBRAS.Find(ob.Id_Obra);
                    Obra obra = new Obra(obraSql);
                    detalleExposicion.conocerObra(obra);
                }

                tipoExposicion = new TipoExposicion(tipoExpoSql);
                publicoDestino = new PublicoDestino(publicDestinoSql);

                exposicion = new Exposicion(expoSql);
                exposicion.conocerDetalleExposicion(detalleExposicion);
                exposicion.conocerTipoExposicion(tipoExposicion);
                exposicion.conocerPublicoDestino(publicoDestino);
            }
            return exposicion;
        }
        
        public static List<Reserva> traerReservasPorIdSede(int Id_Sede)
        {
            List<Reserva> listaReservas = new List<Reserva>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaReservasSql = db.RESERVAS.Where(res => res.Id_Sede == Id_Sede);
                foreach(RESERVAS res in listaReservasSql) // Recorrer reservasSql
                {
                    Reserva reserva = new Reserva(res); // Crear reserva

                    // Conocer las asignacionesVisita y empleados
                    var listaAsingacionesVisitaSql = db.ASIGNACIONESVISITAPORRESERVA.Where(asign => asign.Id_Reserva == res.Id_Reserva);
                    foreach (var asign in listaAsingacionesVisitaSql) 
                    {
                        ASIGNACIONESVISITA asignacionVisitaSql = db.ASIGNACIONESVISITA.Find(asign.Id_AsignacionVisita);
                        Empleado empleado = traerEmpleadoPorId(asignacionVisitaSql.Id_Empleado.Value);
                        AsignacionVisita asignacionVisita = new AsignacionVisita(asignacionVisitaSql);
                        asignacionVisita.conocerEmpleado(empleado);
                        reserva.conocerAsignacionVisita(asignacionVisita);
                    }

                    // Conocer exposiciones de la reserva
                    var listaExposicionesPorReservaSql = db.EXPOSICIONESPORRESERVA.Where(expo => expo.Id_Reserva == res.Id_Reserva);
                    foreach(var expo in listaExposicionesPorReservaSql)
                    {
                        Exposicion exposicion = traerExposicionPorId(expo.Id_Exposicion.Value);
                        reserva.conocerExposicion(exposicion);
                    }

                    // Conocer los cambios de estado
                    var listaCambiosEstadosSql = db.CAMBIOSESTADOSPORRESERVA.Where(cambio => cambio.Id_Reserva == res.Id_Reserva);
                    foreach(CAMBIOSESTADOSPORRESERVA cambio in listaCambiosEstadosSql)
                    {
                        CAMBIOSESTADOS cambioEstadoSql = db.CAMBIOSESTADOS.Find(cambio.Id_CambioEstado);
                        CambioEstado cambioEstado = new CambioEstado(cambioEstadoSql);
                        reserva.conocerCambioEstado(cambioEstado);
                    }

                    // Asignar la sede
                    reserva.conocerSede(traerSedePorId(Id_Sede));
                }
            }
            return listaReservas;
        }

        public static Empleado traerEmpleadoPorId(int Id_Empleado)
        {
            Empleado empleado;
            using (PPAIEntities db = new PPAIEntities())
            {
                EMPLEADOS empleadoSql = db.EMPLEADOS.Find(Id_Empleado);
                HORARIOSTRABAJOS horarioTrabajoSql = db.HORARIOSTRABAJOS.Find(empleadoSql.Id_HorarioTrabajo);
                CARGOS cargoSql = db.CARGOS.Find(empleadoSql.Id_Cargo);

                empleado = new Empleado(empleadoSql);
                empleado.conocerHorario(new HorarioTrabajo(horarioTrabajoSql));
                empleado.conocerCargo(new Cargo(cargoSql));
            }
            return empleado;
        }

        public static Sede traerSedePorId(int Id_Sede)
        {
            Sede sede;
            using (PPAIEntities db = new PPAIEntities())
            {
                SEDES sedeSql = db.SEDES.Find(Id_Sede);
                sede = new Sede(sedeSql);
            }
            return sede;
        }

        public static List<Empleado> traerEmpeladosGuias()
        {
            List<Empleado> listaGuias = new List<Empleado>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaGuiasSql = db.EMPLEADOS.Where(emp => emp.Id_Cargo == 13).ToList();
                foreach(EMPLEADOS emp in listaGuiasSql)
                {
                    Empleado empleado = new Empleado(emp);
                    HORARIOSTRABAJOS horarioTrabajoSql = db.HORARIOSTRABAJOS.Find(emp.Id_HorarioTrabajo);
                    CARGOS cargoSql = db.CARGOS.Find(emp.Id_Cargo);

                    empleado.conocerHorario(new HorarioTrabajo(horarioTrabajoSql));
                    empleado.conocerCargo(new Cargo(cargoSql));
                    listaGuias.Add(empleado);
                }
            }
            return listaGuias;
        }

        public static List<Empleado> traerEmpeladosGuiasPorIdSede(int Id_Sede)
        {
            List<Empleado> listaGuias = new List<Empleado>();
            using(PPAIEntities db = new PPAIEntities())
            {
                var listaGuiasSql = db.EMPLEADOS.Where(guia => guia.Id_Sede == Id_Sede && guia.Id_Cargo == 13);
                foreach(EMPLEADOS guiaSql in listaGuiasSql)
                {
                    HORARIOSTRABAJOS horarioTrabajoSql = db.HORARIOSTRABAJOS.Find(guiaSql.Id_HorarioTrabajo);
                    CARGOS cargoSql = db.CARGOS.Find(guiaSql.Id_Cargo);

                    Empleado guia = new Empleado(guiaSql);
                    guia.conocerHorario(new HorarioTrabajo(horarioTrabajoSql));
                    guia.conocerCargo(new Cargo(cargoSql));
                    listaGuias.Add(guia);
                }
            }
            return listaGuias;
        }

        public static List<AsignacionVisita> traerAsignacionesVisita()
        {
            List<AsignacionVisita> listaAsignacionesVisita = new List<AsignacionVisita>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaAsignacionesVisitaSql = db.ASIGNACIONESVISITA;
                foreach(ASIGNACIONESVISITA asign in listaAsignacionesVisitaSql)
                {
                    AsignacionVisita asignacionVisita = new AsignacionVisita(asign);
                    Empleado empleado = traerEmpleadoPorId(asign.Id_Empleado.Value);
                    asignacionVisita.conocerEmpleado(empleado);
                    listaAsignacionesVisita.Add(asignacionVisita);
                }
            }
            return listaAsignacionesVisita;
        }

        public static Usuario traerUsuarioPorId(int Id_Usuario)
        {
            Usuario usuario;
            using (PPAIEntities db = new PPAIEntities())
            {
                USUARIOS usuarioSql = db.USUARIOS.Find(Id_Usuario);
                Empleado empleado = traerEmpleadoPorId(usuarioSql.Id_Empleado.Value);
                usuario = new Usuario(usuarioSql);
                usuario.conocerEmpleado(empleado);
            }
            return usuario;
        }

        public static int traerUltimoNroReserva()
        {
            int ultimoNroReserva = -1;
            using (PPAIEntities db = new PPAIEntities())
            {
                ultimoNroReserva = db.RESERVAS.Max(res => res.NroReserva).Value;
            }
            return ultimoNroReserva;
        }

        public static Estado traerEstadoPendienteParaReservas()
        {
            Estado estado;
            using (PPAIEntities db = new PPAIEntities())
            {
                ESTADOS estadoSql = db.ESTADOS.Where(est => (est.Nombre == "Pendiente de confirmacion") && (est.Ambito == "Reservas")).First();
                estado = new Estado(estadoSql);
            }
            return estado;
        }

        private static int insertarReservaParcialGetId(RESERVAS reserva)
        {
            int idReserva = 0;
            using (PPAIEntities db = new PPAIEntities())
            {
                db.RESERVAS.Add(reserva);
                db.SaveChanges();
                idReserva = reserva.Id_Reserva;
            }
            return idReserva;
        }

        public static void insertarNuevaReserva(Reserva reserva)
        {
            using (PPAIEntities db = new PPAIEntities())
            {
                RESERVAS reservaSql = new RESERVAS();
                List<ASIGNACIONESVISITAPORRESERVA> listaAsignacionesPorVisita = new List<ASIGNACIONESVISITAPORRESERVA>();
                List<ASIGNACIONESVISITA> listaAsignacionesVisita = new List<ASIGNACIONESVISITA>();
                List<EXPOSICIONESPORRESERVA> listaExposicionesPorReserva = new List<EXPOSICIONESPORRESERVA>();

                //------------------------------------------------------------------------------------------- Preparar datos
                reservaSql.FechaHoraCreacion = reserva.getFechaHoraCreacion();
                reservaSql.FechaReserva = reserva.getFechaReserva();
                reservaSql.HoraReserva = TimeSpan.Parse(reserva.getHoraReserva().ToString("HH:mm:ss"));
                reservaSql.CantidadAlumnos = reserva.getCantidadAlumnos();
                reservaSql.Id_Sede = reserva.getSede().getId();
                reservaSql.Id_Empleado = reserva.getEmpeladoRegistrador().getId();
                reservaSql.DuracionEstimada = reserva.getDuracionEstimada();
                reservaSql.NroReserva = reserva.getNroReserva();

                // Guardar asignaciones
                foreach (AsignacionVisita asignacionVisita in reserva.getAsignacionesVisita())
                {
                    ASIGNACIONESVISITA asignacionVisitaSql = new ASIGNACIONESVISITA();
                    asignacionVisitaSql.FechaInicio = asignacionVisita.getFechaInicio();
                    asignacionVisitaSql.HoraInicio = TimeSpan.Parse(asignacionVisita.getHoraInicio().ToString("HH:mm:ss"));
                    asignacionVisitaSql.FechaFin = asignacionVisita.getFechaFin();
                    asignacionVisitaSql.HoraFin = TimeSpan.Parse(asignacionVisita.getHoraFin().ToString("HH:mm:ss"));
                    asignacionVisitaSql.Id_Empleado = asignacionVisita.getEmpleado().getId();
                    listaAsignacionesVisita.Add(asignacionVisitaSql);
                }

                // Guardar el ultimo cambio de estado
                CAMBIOSESTADOS cambioEstadoSql = new CAMBIOSESTADOS();
                CambioEstado ultimoCambioEstado = reserva.getCambioEstadoActual();
                cambioEstadoSql.FechaHoraInicio = ultimoCambioEstado.getFechaHoraInicio();
                cambioEstadoSql.Id_Estado = ultimoCambioEstado.getEstado().getId();

                // ---------------------------------------------------------------------------------------- Grabar datos 
                int idReserva = insertarReservaParcialGetId(reservaSql);

                //Grabar asignaciones
                foreach(ASIGNACIONESVISITA asignacionSql in listaAsignacionesVisita)
                {
                    int idAsignacionVisita = insertarAsignacionVisitaGetId(asignacionSql);
                    ASIGNACIONESVISITAPORRESERVA asignacionPorReservaSql = new ASIGNACIONESVISITAPORRESERVA();
                    asignacionPorReservaSql.Id_AsignacionVisita = idAsignacionVisita;
                    asignacionPorReservaSql.Id_Reserva = idReserva;
                    db.ASIGNACIONESVISITAPORRESERVA.Add(asignacionPorReservaSql);
                }
                // Grabar exposiciones
                foreach (Exposicion exposicion in reserva.getExposiciones())
                {
                    EXPOSICIONESPORRESERVA exposicionPorReservaSql = new EXPOSICIONESPORRESERVA();
                    exposicionPorReservaSql.Id_Reserva = idReserva;
                    exposicionPorReservaSql.Id_Exposicion = exposicion.getId();
                    //listaExposicionesPorReserva.Add(exposicionPorReservaSql);
                    insertarExposicionPorReserva(exposicionPorReservaSql);
                }

                // Grabar cambio de estado
                int idCambioEstado = insertarCambioEstadoGetId(cambioEstadoSql);

                CAMBIOSESTADOSPORRESERVA cambioEstadoPorReservaSql = new CAMBIOSESTADOSPORRESERVA();
                cambioEstadoPorReservaSql.Id_CambioEstado = idCambioEstado;
                cambioEstadoPorReservaSql.Id_Reserva = idReserva;
                db.CAMBIOSESTADOSPORRESERVA.Add(cambioEstadoPorReservaSql);
                db.SaveChanges();
            }
        }

        private static int insertarAsignacionVisitaGetId(ASIGNACIONESVISITA asignacionVisitaSql)
        {
            int idAsignacionVisita = 0;
            using (PPAIEntities db = new PPAIEntities())
            {
                db.ASIGNACIONESVISITA.Add(asignacionVisitaSql);
                db.SaveChanges();
                idAsignacionVisita = asignacionVisitaSql.Id_AsignacionVisita;
            }
            return idAsignacionVisita;
        }

        private static int insertarCambioEstadoGetId(CAMBIOSESTADOS cambioEstadosql)
        {
            int idCambioEstado = 0;
            using (PPAIEntities db = new PPAIEntities())
            {
                db.CAMBIOSESTADOS.Add(cambioEstadosql);
                db.SaveChanges();
                idCambioEstado = cambioEstadosql.Id_CambioEstado;
            }
            return idCambioEstado;
        }

        private static void insertarExposicionPorReserva(EXPOSICIONESPORRESERVA exposicionPorReservaSql)
        {
            using (PPAIEntities db = new PPAIEntities())
            {
                db.EXPOSICIONESPORRESERVA.Add(exposicionPorReservaSql);
                db.SaveChanges();
            }
        }

        public static void insertarSesion(Sesion sesion)
        {
            using (PPAIEntities db = new PPAIEntities())
            {
                SESIONES sesionSql = new SESIONES();
                sesionSql.FechaHoraInicio = sesion.getFechaHoraInicio();
                sesionSql.FechaHoraFin = sesion.getFechaHoraFin();
                sesionSql.Id_Usuario = sesion.getUsuario().getId();
                db.SESIONES.Add(sesionSql);
                db.SaveChanges();
            }
        }
    }
}
