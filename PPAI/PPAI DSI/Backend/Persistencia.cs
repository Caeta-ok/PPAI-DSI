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
    }
}
