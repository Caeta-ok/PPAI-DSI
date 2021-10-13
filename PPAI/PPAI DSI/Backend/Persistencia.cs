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

        public static List<Estado> traerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaEstadosSql = db.ESTADOS;
                foreach(ESTADOS estadoSql in listaEstadosSql)
                {
                    Estado estado = new Estado(estadoSql);
                    listaEstados.Add(estado);
                }
            }
            return listaEstados;
        }

        public static List<Exposicion> traerExposiciones()
        {
            List<Exposicion> listaExposiciones = new List<Exposicion>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaExposicionesSql = db.EXPOSICIONES;
                foreach(EXPOSICIONES exposicionSql in listaExposicionesSql)
                {
                    Exposicion exposicion = traerExposicionPorId(exposicionSql.Id_Exposicion);
                    listaExposiciones.Add(exposicion);
                }
            }
            return listaExposiciones;
        }


        private static Escuela traerEscuelaPorId(int idEscuela)
        {
            Escuela escuela;
            using (PPAIEntities db = new PPAIEntities())
            {
                ESCUELAS escuelaSql = db.ESCUELAS.Find(idEscuela);
                escuela = new Escuela(escuelaSql);
            }
            return escuela;
        }

        private static PublicoDestino traerPublicoDestinoPorId(int idPublicoDestino)
        {
            PublicoDestino publicoDestino;
            using (PPAIEntities db = new PPAIEntities())
            {
                PUBLICOSDESTINO publicoDestinoSql = db.PUBLICOSDESTINO.Find(idPublicoDestino);
                publicoDestino = new PublicoDestino(publicoDestinoSql);
            }
            return publicoDestino;
        }

        private static List<Exposicion> traerExposicionesPorIdReserva(int idReserva)
        {
            List<Exposicion> listaExposiciones = new List<Exposicion>(); ;
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaExposicionesPorReservaSql = db.EXPOSICIONESPORRESERVA.Where(expoPorRes => (expoPorRes.Id_Reserva == idReserva));
                foreach (EXPOSICIONESPORRESERVA expoPorReservaSql in listaExposicionesPorReservaSql)
                {
                    var exposicionSql = db.EXPOSICIONES.Where(expo => (expo.Id_Exposicion == expoPorReservaSql.Id_Exposicion)).First();
                    PublicoDestino publicoDestino = traerPublicoDestinoPorId(exposicionSql.Id_PublicoDestino.Value);
                    Exposicion exposicion = new Exposicion(exposicionSql);
                    exposicion.PublicoDestino = publicoDestino;

                    var listaDetallesPorExposicionSql = db.DETALLESPOREXPOSICION.Where(dtePorExpo => (dtePorExpo.Id_Exposicion == exposicionSql.Id_Exposicion));
                    foreach (DETALLESPOREXPOSICION detallePorExpo in listaDetallesPorExposicionSql)
                    {
                        DetalleExposicion detalleExposicion = traerDetalleExposicionPorId(detallePorExpo.Id_DetalleExposicion.Value);
                        exposicion.conocerDetalleExposicion(detalleExposicion);
                    }
                    listaExposiciones.Add(exposicion);
                }
            }
            return listaExposiciones;
        }

        private static DetalleExposicion traerDetalleExposicionPorId(int idDetalleExposicion)
        {
            DetalleExposicion detalleExposicion;
            using (PPAIEntities db = new PPAIEntities())
            {
                DETALLESEXPOSICION detalleExposicionSql = db.DETALLESEXPOSICION.Find(idDetalleExposicion);
                detalleExposicion = new DetalleExposicion(detalleExposicionSql);
                Obra obra = traerObraPorId(detalleExposicionSql.Id_Obra.Value);
                detalleExposicion.Obra = obra;
            }
            return detalleExposicion;
        }

        private static Obra traerObraPorId(int idObra)
        {
            Obra obra;
            using (PPAIEntities db = new PPAIEntities())
            {
                OBRAS obraSql = db.OBRAS.Find(idObra);
                obra = new Obra(obraSql);
            }
            return obra;
        }

        private static AsignacionVisita traerAsignacionVisitaPorId(int idAsignacionVisita)
        {
            AsignacionVisita asignacionVisita;
            using (PPAIEntities db = new PPAIEntities())
            {
                ASIGNACIONESVISITA asignacionVisitaSql = db.ASIGNACIONESVISITA.Find(idAsignacionVisita);
                asignacionVisita = new AsignacionVisita(asignacionVisitaSql);

                Empleado guiaAsignado = traerEmpleadoPorId(asignacionVisitaSql.Id_Empleado.Value);
                asignacionVisita.Empleado = guiaAsignado;
            }
            return asignacionVisita;
        }

        private static List<AsignacionVisita> traerAsignacionesVisitasPorIdReserva(int idReserva)
        {
            List<AsignacionVisita> listaAsignacionesVisita = new List<AsignacionVisita>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaAsignacionesVisitaPorReservaSql = db.ASIGNACIONESVISITAPORRESERVA.Where(asignPorReserva => (asignPorReserva.Id_Reserva == idReserva));
                foreach(ASIGNACIONESVISITAPORRESERVA asignPorReserva in listaAsignacionesVisitaPorReservaSql)
                {
                    AsignacionVisita asignacionVisita = traerAsignacionVisitaPorId(asignPorReserva.Id_AsignacionVisita.Value);
                    listaAsignacionesVisita.Add(asignacionVisita);
                }
            }
            return listaAsignacionesVisita;
        }

        public static List<Reserva> traerReservas()
        {
            List<Reserva> listaReservas = new List<Reserva>();

            using (PPAIEntities db = new PPAIEntities())
            {
                var listaReservasSql = db.RESERVAS;
                foreach (var reservaSql in listaReservasSql)
                {
                    Reserva reserva = new Reserva(reservaSql);
                    Sede sede = traerSedePorId(reservaSql.Id_Sede.Value);
                    Empleado empleadoRegistrador = traerEmpleadoPorId(reservaSql.Id_Empleado.Value);
                    Escuela escuela = traerEscuelaPorId(reservaSql.Id_Escuela.Value);
                    List<Exposicion> listaExposiciones = traerExposicionesPorIdReserva(reservaSql.Id_Reserva);
                    List<CambioEstado> listaCambiosEstados = traerCambiosEstadoPorIdReserva(reservaSql.Id_Reserva);
                    List<AsignacionVisita> listaAsignacionesVisita = traerAsignacionesVisitasPorIdReserva(reservaSql.Id_Reserva);

                    reserva.Escuela = escuela;
                    reserva.Sede = sede;
                    reserva.EmpleadoRegistrador = empleadoRegistrador;

                    foreach (Exposicion exposicion in listaExposiciones)
                    {
                        reserva.conocerExposicion(exposicion);
                    }

                    foreach(CambioEstado cambioEstado in listaCambiosEstados)
                    {
                        reserva.conocerCambioEstado(cambioEstado);
                    }

                    foreach(AsignacionVisita asignacionVisita in listaAsignacionesVisita)
                    {
                        reserva.conocerAsignacionVisita(asignacionVisita);
                    }
                    listaReservas.Add(reserva);
                }
            }
            return listaReservas;
        }

        private static List<CambioEstado> traerCambiosEstadoPorIdReserva(int idReserva)
        {
            List<CambioEstado> listaCambioEstados = new List<CambioEstado>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaCambiosEstadosPorReserva = db.CAMBIOSESTADOSPORRESERVA.Where(cambioEstadoPorReserva => (cambioEstadoPorReserva.Id_Reserva == idReserva));
                foreach (CAMBIOSESTADOSPORRESERVA cambioEstadoPorReservaSql in listaCambiosEstadosPorReserva)
                {
                    CAMBIOSESTADOS cambioEstadoSql = db.CAMBIOSESTADOS.Find(cambioEstadoPorReservaSql.Id_CambioEstado);
                    ESTADOS estadoSql = db.ESTADOS.Find(cambioEstadoSql.Id_Estado);
                       
                    CambioEstado cambioEstado = new CambioEstado(cambioEstadoSql);
                    Estado estado = new Estado(estadoSql);
                    cambioEstado.Estado = estado;

                    listaCambioEstados.Add(cambioEstado);
                }
            }
            return listaCambioEstados;
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
            TipoExposicion tipoExposicion;
            PublicoDestino publicoDestino;
            using (PPAIEntities db = new PPAIEntities())
            {
                EXPOSICIONES expoSql = db.EXPOSICIONES.Find(Id_Exposicion);
                TIPOSEXPOSICION tipoExpoSql = db.TIPOSEXPOSICION.Find(expoSql.Id_TipoExposicion);
                PUBLICOSDESTINO publicDestinoSql = db.PUBLICOSDESTINO.Find(expoSql.Id_PublicoDestino);
                var listaDetallesPorExposicionSql = db.DETALLESPOREXPOSICION.Where(detalle => detalle.Id_Exposicion == expoSql.Id_Exposicion);

                tipoExposicion = new TipoExposicion(tipoExpoSql);
                publicoDestino = new PublicoDestino(publicDestinoSql);

                exposicion = new Exposicion(expoSql);
                exposicion.TipoExposicion = tipoExposicion;
                exposicion.PublicoDestino = publicoDestino;

                foreach (var detallePorExposicionSql in listaDetallesPorExposicionSql)
                {
                    DETALLESEXPOSICION detalleExposicionSql = db.DETALLESEXPOSICION.Find(detallePorExposicionSql.Id_DetalleExposicion);
                    DetalleExposicion detalleExposicion = new DetalleExposicion(detalleExposicionSql);

                    OBRAS obraSql = db.OBRAS.Find(detalleExposicionSql.Id_Obra);
                    Obra obra = new Obra(obraSql);
                    detalleExposicion.Obra = obra;
                    exposicion.conocerDetalleExposicion(detalleExposicion);
                }
                exposicion.TipoExposicion = tipoExposicion;
                exposicion.PublicoDestino = publicoDestino;
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
                        asignacionVisita.Empleado = empleado;
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
                    reserva.Sede = traerSedePorId(Id_Sede);
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
                empleado.HorarioTrabajo = new HorarioTrabajo(horarioTrabajoSql);
                empleado.Cargo = new Cargo(cargoSql);
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

                List<Exposicion> listaExposiciones = traerExposicionesPorIdSede(sedeSql.Id_Sede);
                sede.ListaExposiciones = listaExposiciones;
            }
            return sede;
        }

        private static List<Exposicion> traerExposicionesPorIdSede(int idSede)
        {
            List<Exposicion> listaExposiciones = new List<Exposicion>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaExposicionesPorSedeSql = db.EXPOSICIONESPORSEDE.Where(expoPorSede => (expoPorSede.Id_Sede == idSede));
                foreach(EXPOSICIONESPORSEDE expoPorSedeSql in listaExposicionesPorSedeSql)
                {
                    Exposicion exposicion = traerExposicionPorId(expoPorSedeSql.Id_Exposicion.Value);
                    listaExposiciones.Add(exposicion);
                }
            }
            return listaExposiciones;
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
                    Sede sedeDondeTrabaja = traerSedePorId(empleadoSql.Id_Sede.Value);

                    empleado.HorarioTrabajo = new HorarioTrabajo(horarioTrabajoSql);
                    empleado.Cargo = new Cargo(cargoSql);
                    empleado.SedeDondeTrabaja = sedeDondeTrabaja;
                    listaEmpleados.Add(empleado);
                }
            }
            return listaEmpleados;
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
                    asignacionVisita.Empleado = empleado;
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
                usuario.Empleado = empleado;
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
                                FechaInicio = asignacion.FechaInicio,
                                FechaFin = asignacion.FechaFin,
                                HoraInicio = TimeSpan.Parse(asignacion.HoraInicio.ToString("HH:mm:ss")),
                                HoraFin = TimeSpan.Parse(asignacion.HoraFin.ToString("HH:mm:ss")),
                                Id_Empleado = asignacion.Empleado.Id

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
                            FechaHoraInicio = cambioEstado.FechaHoraInicio,
                            Id_Estado = cambioEstado.Estado.Id
                        };
                        db.CAMBIOSESTADOS.Add(cambioEstadoSql);
                        db.SaveChanges();

                        // ------------------------------------------------------------------------- 3) Insertar Reserva
                        RESERVAS reservaSql = new RESERVAS
                        {
                            FechaHoraCreacion = reserva.FechaHoraCreacion,
                            FechaReserva = reserva.FechaReserva,
                            HoraReserva = TimeSpan.Parse(reserva.HoraReserva.ToString("HH:mm:ss")),
                            CantidadAlumnos = reserva.CantidadAlumnos,
                            Id_Sede = reserva.Sede.Id,
                            Id_Empleado = reserva.EmpleadoRegistrador.Id,
                            DuracionEstimada = reserva.DuracionEstimada,
                            NroReserva = reserva.NroReserva,
                            Id_Escuela = reserva.Escuela.Id
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
                                Id_Exposicion = exposicion.Id
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

        public static void insertarSesion(Sesion sesion)
        {
            using (PPAIEntities db = new PPAIEntities())
            {
                SESIONES sesionSql = new SESIONES();
                sesionSql.FechaHoraInicio = sesion.FechaHoraInicio;
                sesionSql.FechaHoraFin = sesion.FechaHoraFin;
                sesionSql.Id_Usuario = sesion.Usuario.Id;

                db.SESIONES.Add(sesionSql);
                db.SaveChanges();
            }
        }
    }
}