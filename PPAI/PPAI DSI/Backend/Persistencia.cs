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

        public static List<Sede> traerSedes()
        {
            List<Sede> listaSedes = new List<Sede>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var list = db.SEDES;
                foreach (SEDES sede in list)
                {
                    Sede sedeNueva = new Sede(sede);
                    listaSedes.Add(sedeNueva);
                }
            }
            return listaSedes;
        }

        public static List<Exposicion> traerExposiciones(Sede sede)
        {
            List<Exposicion> listaExposicion = new List<Exposicion>();
            using (PPAIEntities db = new PPAIEntities())
            {
                int i = sede.getId();
                var listaExposPorSedeSql = db.EXPOSICIONESPORSEDE.Where(e => e.Id_Sede == i);
                foreach (EXPOSICIONESPORSEDE expoPorSedeSql in listaExposPorSedeSql)
                {
                    Exposicion exposicion = traerExposicionPorId(expoPorSedeSql.Id_Exposicion.Value);
                    listaExposicion.Add(exposicion);
                }
            }
            return listaExposicion;
        }

        public static List<TipoVisita> traerTipoVisita()
        {
            List<TipoVisita> listaTiposVisita = new List<TipoVisita>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaTiposVisitaSql = db.TIPOSVISITA;
                foreach (TIPOSVISITA tv in listaTiposVisitaSql)
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

                foreach (var ob in listaObrasPorExposicionSql)
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
                foreach (RESERVAS res in listaReservasSql) // Recorrer reservasSql
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
                    foreach (var expo in listaExposicionesPorReservaSql)
                    {
                        Exposicion exposicion = traerExposicionPorId(expo.Id_Exposicion.Value);
                        reserva.conocerExposicion(exposicion);
                    }

                    // Conocer los cambios de estado
                    var listaCambiosEstadosSql = db.CAMBIOSESTADOSPORRESERVA.Where(cambio => cambio.Id_Reserva == res.Id_Reserva);
                    foreach (CAMBIOSESTADOSPORRESERVA cambio in listaCambiosEstadosSql)
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
                foreach (EMPLEADOS emp in listaGuiasSql)
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

        public static List<Empleado> traerEmpleados()
        {
            // Trae todos los empleados completos
            List<Empleado> listaEmpleados = new List<Empleado>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaEmpleadosSql = db.EMPLEADOS.ToList();
                foreach (EMPLEADOS empleadoSql in listaEmpleadosSql)
                {
                    Empleado empleado = new Empleado(empleadoSql);
                    HORARIOSTRABAJOS horarioTrabajoSql = db.HORARIOSTRABAJOS.Find(empleadoSql.Id_HorarioTrabajo);
                    CARGOS cargoSql = db.CARGOS.Find(empleadoSql.Id_Cargo);

                    empleado.conocerHorario(new HorarioTrabajo(horarioTrabajoSql));
                    empleado.conocerCargo(new Cargo(cargoSql));
                    listaEmpleados.Add(empleado);
                }
            }
            return listaEmpleados;
        }

        public static List<Empleado> traerEmpeladosGuiasPorIdSede(int Id_Sede)
        {
            List<Empleado> listaGuias = new List<Empleado>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaGuiasSql = db.EMPLEADOS.Where(guia => guia.Id_Sede == Id_Sede && guia.Id_Cargo == 13);
                foreach (EMPLEADOS guiaSql in listaGuiasSql)
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
                foreach (ASIGNACIONESVISITA asign in listaAsignacionesVisitaSql)
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

        /*
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
        }*/

        public static void insertarReserva(Reserva reserva)
        {
            // Se debe pasar la reserva completa
            using (PPAIEntities db = new PPAIEntities())
            {
                // Se insertan primero los datos que son referenciados por llaves foraneas
                using (var dbTransaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        List<ASIGNACIONESVISITA> listaAsignacionesVisitaSql = new List<ASIGNACIONESVISITA>();
                        // ------------------------------------------------------------------------- 1) Insertar AsignacionesVisita
                        foreach (AsignacionVisita asignacion in reserva.getAsignacionesVisita())
                        {
                            ASIGNACIONESVISITA asignacionSql = new ASIGNACIONESVISITA //Crear objecto asignacionSql
                            {
                                // Asignarle los datos que traemos de la capa de negocio
                                FechaInicio = asignacion.getFechaInicio(),
                                FechaFin = asignacion.getFechaFin(),
                                HoraInicio = TimeSpan.Parse(asignacion.getHoraInicio().ToString("HH:mm:ss")),
                                HoraFin = TimeSpan.Parse(asignacion.getHoraFin().ToString("HH:mm:ss")),
                                Id_Empleado = asignacion.getEmpleado().getId()
                            };

                            // Insertar objeto
                            db.ASIGNACIONESVISITA.Add(asignacionSql);
                            db.SaveChanges();
                            listaAsignacionesVisitaSql.Add(asignacionSql);
                        }

                        // ------------------------------------------------------------------------- 2) Insertar CambioEstado
                        CambioEstado cambioEstado = reserva.getCambioEstadoActual();
                        CAMBIOSESTADOS cambioEstadoSql = new CAMBIOSESTADOS
                        {
                            FechaHoraInicio = cambioEstado.getFechaHoraInicio(),
                            Id_Estado = cambioEstado.getEstado().getId()
                        };
                        db.CAMBIOSESTADOS.Add(cambioEstadoSql);
                        db.SaveChanges();

                        // ------------------------------------------------------------------------- 3) Insertar Reserva
                        RESERVAS reservaSql = new RESERVAS
                        {
                            FechaHoraCreacion = reserva.getFechaHoraCreacion(),
                            FechaReserva = reserva.getFechaReserva(),
                            HoraReserva = TimeSpan.Parse(reserva.getHoraReserva().ToString("HH:mm:ss")),
                            CantidadAlumnos = reserva.getCantidadAlumnos(),
                            Id_Sede = reserva.getSede().getId(),
                            Id_Empleado = reserva.getEmpeladoRegistrador().getId(),
                            DuracionEstimada = reserva.getDuracionEstimada(),
                            NroReserva = reserva.getNroReserva()
                        };
                        db.RESERVAS.Add(reservaSql);
                        db.SaveChanges();

                        // ------------------------------------------------------------------------- 4) Insertar AsignacionPorReserva
                        foreach (ASIGNACIONESVISITA asignacionSql in listaAsignacionesVisitaSql)
                        {
                            ASIGNACIONESVISITAPORRESERVA asignacionVisitaPorReservaSql = new ASIGNACIONESVISITAPORRESERVA
                            {
                                Id_AsignacionVisita = asignacionSql.Id_AsignacionVisita,
                                Id_Reserva = reservaSql.Id_Reserva
                            };
                            db.ASIGNACIONESVISITAPORRESERVA.Add(asignacionVisitaPorReservaSql);
                            db.SaveChanges();
                        }

                        // ------------------------------------------------------------------------- 5) Insertar ExposicionPorReserva
                        foreach (Exposicion exposicion in reserva.getExposiciones())
                        {
                            EXPOSICIONESPORRESERVA exposicionPorReservaSql = new EXPOSICIONESPORRESERVA
                            {
                                Id_Reserva = reservaSql.Id_Reserva,
                                Id_Exposicion = exposicion.getId()
                            };
                            db.EXPOSICIONESPORRESERVA.Add(exposicionPorReservaSql);
                            db.SaveChanges();
                        }

                        // ------------------------------------------------------------------------- 6) Insertar CambioEstadoPorReserva
                        CAMBIOSESTADOSPORRESERVA cambioEstadoPorReservaSql = new CAMBIOSESTADOSPORRESERVA
                        {
                            Id_Reserva = reservaSql.Id_Reserva,
                            Id_CambioEstado = cambioEstadoSql.Id_CambioEstado
                        };

                        db.CAMBIOSESTADOSPORRESERVA.Add(cambioEstadoPorReservaSql);
                        db.SaveChanges();

                        dbTransaction.Commit();
                    }
                    catch (Exception ex0) // Si hubo un error
                    {
                        dbTransaction.Rollback();
                        Exception ex1 = new Exception("Error en la capa de persistencia");
                        throw ex1;
                    }
                }
            }
        }

        /*
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
        }*/

        /*
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
        }*/

        /*
        private static void insertarExposicionPorReserva(EXPOSICIONESPORRESERVA exposicionPorReservaSql)
        {
            using (PPAIEntities db = new PPAIEntities())
            {
                db.EXPOSICIONESPORRESERVA.Add(exposicionPorReservaSql);
                db.SaveChanges();
            }
        }*/

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