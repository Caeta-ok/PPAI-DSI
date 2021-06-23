using PPAI_DSI.Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PPAI_DSI.Negocio;
using System.Collections.Generic;

namespace PPAI_DSI
{
    public partial class Form1 : Form
    {
        GestorReserva formularioReserva = new GestorReserva();
        string nombreExp;
        string horaInicioExposicion;
        string horaFinalExposicion;
        //string nombreGuiaSeleccionado;
        //string apellidoGuiaSeleccionado;
        List<Empleado> listaGuiasSeleccionados = new List<Empleado>();
        int duracionReserva;

        public Form1()
        {
            InitializeComponent();
        }

        private void habilitarVentana()
        {
            this.btn_registrar_reserva.Visible = false;
            this.group_registrar_reserva.Visible = true;
        }

        private void opcionRegReservaVisitaGuiada(object sender, EventArgs e)
        {
            habilitarVentana();
            //calcularDuracionReserva();
        }

        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (PPAIEntities db = new PPAIEntities())
            {
                var lista = db.ESCUELAS.ToList();
                DataTable item = new DataTable();
                item.Columns.Add("Id");
                item.Columns.Add("Nombre");
                int i = 0;
                foreach (var l in lista)
                {
                    item.Rows.Add();
                    item.Rows[i]["Id"] = l.Id_Escuela;
                    item.Rows[i]["Nombre"] = l.Nombre;
                    i++;
                }
                cmb_escuelas.DataSource = item;
                cmb_escuelas.DisplayMember = "Nombre";
                cmb_escuelas.ValueMember = "Id";
            }
        }

        private void cmb_escuelas_Enter(object sender, EventArgs e)
        {
            if (cmb_escuelas.Text != "")
            {
                txtVisitantes.Enabled = true;
            }
        }

        private void cmb_escuelas_TextChanged(object sender, EventArgs e)
        {
            txtVisitantes.Text = "";
            cmbTipoVisita.Text = null;
            cmbTipoVisita.Enabled = false;
            grid_sedes.Enabled = false;
            grid_exposiciones.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void txtVisitantes_Enter(object sender, EventArgs e)
        {
            if (txtVisitantes.Text != "" && txtVisitantes.Text != null)
            {
                grid_sedes.Enabled = true;
                using (PPAIEntities db = new PPAIEntities())
                {
                    var lista = (from sede in db.SEDES.ToList()
                                 join exp in db.EXPOSICIONES on sede.Id_Exposicion equals exp.Id_Exposicion
                                 where sede.CantidadMaximaVisitantes >= int.Parse(txtVisitantes.Text)
                                 select new
                                 {
                                     sede.Nombre,
                                     sede.CantidadMaximaVisitantes,
                                     sede.CantidadMaximaPorGuia,
                                     Exposicion = exp.Nombre
                                 }).ToList();
                    grid_sedes.DataSource = lista;
                }
            }
            else
            {
                cmbTipoVisita.Text = null;
                cmbTipoVisita.Enabled = false;
                grid_sedes.Enabled = false;
            }
        }

        private void dgv1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtVisitantes.Enabled = false;
            cmbTipoVisita.Enabled = true;
            using (PPAIEntities db = new PPAIEntities())
            {
                var lista = db.TIPOSVISITA.ToList();
                DataTable item = new DataTable();
                item.Columns.Add("Id");
                item.Columns.Add("Nombre");
                int i = 0;
                foreach (var l in lista)
                {
                    item.Rows.Add();
                    item.Rows[i]["Id"] = l.Id_TipoVisita;
                    item.Rows[i]["Nombre"] = l.Nombre;
                    i++;
                }
                cmbTipoVisita.DataSource = item;
                cmbTipoVisita.DisplayMember = "Nombre";
                cmbTipoVisita.ValueMember = "Id";
            }
        }

        private void cmbTipoVisita_Enter(object sender, EventArgs e)
        {
            grid_exposiciones.Enabled = true;
            using (PPAIEntities db = new PPAIEntities())
            {
                var lista = (from exp in db.EXPOSICIONES.ToList()
                             join pub in db.PUBLICOSDESTINO on exp.Id_PublicoDestino equals pub.Id_PublicoDestino
                             where exp.FechaFin > System.DateTime.Now
                             where exp.Id_TipoExposicion == 2
                             select new
                             {
                                 exp.Nombre,
                                 exp.HoraApertura,
                                 exp.HoraCierre,
                                 Publico = pub.Nombre
                             }).ToList();
                grid_exposiciones.DataSource = lista;
            }
        }

        private void dgv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            grid_sedes.Enabled = false;
            cmbTipoVisita.Enabled = false;
            nombreExp = grid_exposiciones.CurrentRow.Cells[0].Value.ToString();
            horaInicioExposicion = grid_exposiciones.CurrentRow.Cells[1].Value.ToString();
            horaFinalExposicion = grid_exposiciones.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Cambia la fecha
            grid_exposiciones.Enabled = false;
            if (dateTimePicker1.Value > System.DateTime.Now)
            {
                DateTime fechaFin = DateTime.Now;
                using (PPAIEntities db = new PPAIEntities())
                {
                    var lista = (from exp in db.EXPOSICIONES.ToList()
                                 where exp.Nombre == nombreExp.Trim()
                                 select new
                                 {
                                     exp.FechaFin
                                 });
                    foreach (var l in lista)
                    {
                        fechaFin = DateTime.Parse(l.FechaFin.ToString());
                    }
                }
                if (dateTimePicker1.Value <= fechaFin)
                {
                    dateTimePicker2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("En la fecha ingresada la exposicion ya no va a estar disponible, su fecha de fin es: " + fechaFin.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una fecha mayor a la del dia actual", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
        private void calcularDuracionReserva()
        {
            duracionReserva = 0;
            using (PPAIEntities db = new PPAIEntities())
            {
                var lista = (from r in db.OBRASPOREXPOSICION.ToList()
                             join e in db.EXPOSICIONES on r.Id_Exposicion equals e.Id_Exposicion
                             join o in db.OBRAS on r.Id_Obra equals o.Id_Obra
                             where e.Nombre == nombreExp
                             //where e.Nombre == 'Clasica'
                             //select new { (o.DuracionExtendida) as duracion }).ToList();
                             select new
                             {
                                 o.DuracionExtendida
                             }).ToList();
                foreach(var d in lista)
                {
                    duracionReserva += int.Parse(d.DuracionExtendida.ToString());
                }
            }
        }

        private List<Empleado> buscarGuiasDisponiblesFechaReserva()
        {
            List<Empleado> listaFinal = new List<Empleado>();
            using (PPAIEntities db = new PPAIEntities())
            {
                var listaGuias = (from empleado in db.EMPLEADOS.ToList()
                             join cargo in db.CARGOS on empleado.Id_Cargo equals cargo.Id_Cargo
                             join horarioTrabajo in db.HORARIOSTRABAJOS on empleado.Id_HorarioTrabajo equals horarioTrabajo.Id_HorarioTrabajo
                             where cargo.Nombre == "Guía"
                             select new
                             {
                                 empleado.Id_Empleado,
                                 empleado.Nombre,
                                 empleado.Apellido,
                                 empleado.Email,
                                 horarioTrabajo.HoraEntrada,
                                 horarioTrabajo.HoraSalida,
                             }).ToList();

                var listaAsignaciones = db.ASIGNACIONESVISITA.ToList();
                List<int> IdGuia = new List<int>();

                foreach (var asign in listaAsignaciones)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == DateTime.Parse(asign.FechaInicio.ToString()).ToShortDateString())
                    {
                        if (validarGuiaDisponible(asign.HoraInicio.ToString(), asign.HoraFin.ToString()) == false)
                        {
                            IdGuia.Add(int.Parse(asign.Id_Empleado.ToString()));
                        }
                    }
                }

                foreach (var guia in listaGuias)
                {
                    if(IdGuia.Count > 0)
                    {
                        foreach (int id in IdGuia)
                        {
                            if (id != guia.Id_Empleado)
                            {
                                Empleado empleado = new Empleado();
                                //empleado.id = guia.Id_Empleado;
                                empleado.nombre = guia.Nombre;
                                empleado.apellido = guia.Apellido;
                                empleado.email = guia.Email;
                                //empleado.horaEntrada = DateTime.Parse(guia.HoraEntrada.ToString());
                                //empleado.horaSalida = DateTime.Parse(guia.HoraSalida.ToString());
                                listaFinal.Add(empleado);
                            }
                        }
                    }
                    else
                    {
                        Empleado empleado = new Empleado();
                        //empleado.id = guia.Id_Empleado;
                        empleado.nombre = guia.Nombre;
                        empleado.apellido = guia.Apellido;
                        empleado.email = guia.Email;
                        //empleado.horaEntrada = DateTime.Parse(guia.HoraEntrada.ToString());
                        //empleado.horaSalida = DateTime.Parse(guia.HoraSalida.ToString());
                        listaFinal.Add(empleado);
                    }
                }
            }
            return listaFinal;
        }

        private bool validarGuiaDisponible(string horaInicialGuia, string horaFinalGuia)
        {
            DateTime horaSeleccionada = DateTime.Parse(dateTimePicker2.Text);
            int horaSelEnMintuos = (horaSeleccionada.Hour * 60) + horaSeleccionada.Minute;
            int duracionTotal = horaSelEnMintuos + duracionReserva;

            //DateTime horaFinal = DateTime.Parse(horaFinalExposicion);
            //int horasEnMinutos = horaFinal.Hour * 60 + horaFinal.Minute;

            DateTime horaInicial = DateTime.Parse(horaInicialGuia);
            int horasInicialEnMinutos = horaInicial.Hour * 60 + horaInicial.Minute;

            DateTime horaFinal = DateTime.Parse(horaFinalGuia);
            int horasFinalEnMinutos = horaFinal.Hour * 60 + horaFinal.Minute;


            if (duracionTotal < horasInicialEnMinutos || horaSelEnMintuos > horasFinalEnMinutos)
            {
                //return false;
                return true;
            }
            return false;
        }

        private bool validarDuracion(string horaComparacion)
        {
            DateTime horaSeleccionada = DateTime.Parse(dateTimePicker2.Text);
            int horaSelEnMintuos = (horaSeleccionada.Hour * 60) + horaSeleccionada.Minute;
            int duracionTotal = horaSelEnMintuos + duracionReserva;

            //DateTime horaFinal = DateTime.Parse(horaFinalExposicion);
            //int horasEnMinutos = horaFinal.Hour * 60 + horaFinal.Minute;

            DateTime horaFinal = DateTime.Parse(horaComparacion);
            int horasFinalEnMinutos = horaFinal.Hour * 60 + horaFinal.Minute;

            if (duracionTotal > horasFinalEnMinutos)
            {
                return false;
            }
            return true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            lbl_duracion_reserva.Text = "Duración de Reserva: ";
            if (dateTimePicker2.Text == "")
            {
                lbl_duracion_reserva.Text = "Duración de Reserva: ";
            }
            if (DateTime.Parse(horaInicioExposicion) <= DateTime.Parse(dateTimePicker2.Text))
            {
                if (DateTime.Parse(horaFinalExposicion) > DateTime.Parse(dateTimePicker2.Text))
                {
                    calcularDuracionReserva();

                    if (validarDuracion(horaFinalExposicion))
                    {
                        lbl_duracion_reserva.Text += " " + duracionReserva.ToString() + " minutos";
                        List<Empleado> lista = buscarGuiasDisponiblesFechaReserva();
                        grid_guias_disponibles.DataSource = lista;
                    }
                    else
                    {
                        MessageBox.Show("En el horario ingresado no se puede realizar la reserva");
                    }
                }
                else
                {
                    MessageBox.Show("En ese horario ya cerro la exposicion, la seleccionada cierra a las: " + horaFinalExposicion, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("En ese horario todabia no abrio la exposicion, la seleccionada abre a las: " + horaInicioExposicion, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void grid_guias_disponibles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            listaGuiasSeleccionados.Clear();
            //nombreGuiaSeleccionado = grid_guias_disponibles.CurrentRow.Cells[1].Value.ToString();
            //apellidoGuiaSeleccionado = grid_guias_disponibles.CurrentRow.Cells[2].Value.ToString();
            for(int i = 0; i < grid_guias_disponibles.SelectedRows.Count; i++)
            {
                //if(grid_guias_disponibles.Rows[i].Index == grid_guias_disponibles.SelectedRows.get)
                foreach (int row in grid_guias_disponibles.SelectedRows)
                {
                    Empleado[] arrayEmpleados = { grid_guias_disponibles.Rows[0].Cells[0].Value };
                }

                        Empleado empleado = new Empleado();
                empleado.nombre = grid_guias_disponibles.Rows[i].Cells[0].Value.ToString();
                empleado.apellido = grid_guias_disponibles.CurrentRow.Cells[1].Value.ToString();
                empleado.email = grid_guias_disponibles.CurrentRow.Cells[2].Value.ToString();
                listaGuiasSeleccionados.Add(empleado);
            }

            //foreach (int row in grid_guias_disponibles.SelectedRows)
            //{
            //    Empleado empleado = new Empleado();
            //    empleado.nombre = grid_guias_disponibles[0, row].Value;


            //    empleado.nombre = grid_guias_disponibles.Rows[row][0].ToString();
            //    empleado.apellido = grid_guias_disponibles.CurrentRow.Cells[1].Value.ToString();
            //    empleado.email = grid_guias_disponibles.CurrentRow.Cells[2].Value.ToString();
            //    listaGuiasSeleccionados.Add(empleado);
            //}
            */
        }













        // Ejecutar cadena de consultas en la base de datos
        // SqlQuery: Retorna datos
        // ExecuteSqlCommadn: No retorna nada
        //using (PPAIEntities db = new PPAIEntities())
        //{
        // Se necesita armar una clase (Empleado) que tenga los campos de la tabla que se devuelve
        //  List<Empleado> lista = db.Database.SqlQuery<Empleado>("select * from EMPLEADOS").ToList();

        //db.Database.ExecuteSqlCommand("insert into ....");
        //dgv1.DataSource = lista;
        //}

        /*
        // Traer datos que no tiene llaves foráneas
        using (PPAIEntities db = new PPAIEntities())
        {
            var lista = db.ESCUELAS.ToList();
            grid0.DataSource = lista;
        }
        */

        /* 
        // Traer datos de la tabla EMPLEADOS descartando las llaves foráneas
        using (PPAIEntities db = new PPAIEntities())
        {
            var lista = (from emp in db.EMPLEADOS.ToList()
                         select new
                         {
                             emp.Nombre,
                             emp.Apellido,
                             emp.CodigoValidacion,
                             emp.Cuit,
                             emp.Dni,
                             emp.Domicilio,
                             emp.FechaIngreso,
                             emp.FechaNacimiento,
                             emp.Email,
                             emp.Sexo,
                             emp.NroTelefono
                         }).ToList();
            grid0.DataSource = lista;
        }
        */

        /*
        // Traer los datos de la tabla EMPLEADOS unido a las tablas CARGOS y HORARIOSTRABAJOS
        using (PPAIEntities db = new PPAIEntities())
        {
            var lista = (from empleado in db.EMPLEADOS.ToList()
                         join cargo in db.CARGOS on empleado.Id_Cargo equals cargo.Id_Cargo
                         join horarioTrabajo in db.HORARIOSTRABAJOS on empleado.Id_HorarioTrabajo equals horarioTrabajo.Id_HorarioTrabajo
                         select new
                         {
                             empleado.Nombre,
                             empleado.Apellido,
                             empleado.CodigoValidacion,
                             empleado.Cuit,
                             empleado.Dni,
                             empleado.Domicilio,
                             empleado.FechaIngreso,
                             empleado.FechaNacimiento,
                             empleado.Email,
                             empleado.Sexo,
                             empleado.NroTelefono,
                             NombreCargo = cargo.Nombre,
                             CargoDescripcion = cargo.Descripcion,
                             horarioTrabajo.HoraEntrada,
                             horarioTrabajo.HoraSalida
                         }).ToList();

            grid0.DataSource = lista;
        }*/

        /*
        //Ingresar nuevo dato
        using (PPAIEntities db = new PPAIEntities())
        {
            EMPLEADOS empleado = new EMPLEADOS();
            empleado.Nombre = "Mariano";
            empleado.Apellido = "Valdivia";
            empleado.CodigoValidacion = "487880";
            empleado.Cuit = 25388065558;
            empleado.Dni = 38806555;
            empleado.Domicilio = "Illia 500";
            empleado.FechaIngreso = DateTime.Parse("2010-05-23");
            empleado.FechaNacimiento = DateTime.Parse("1989-07-15");
            empleado.Email = "MarianoVal@gmail.com";
            empleado.Sexo = "Masculino";
            empleado.NroTelefono = 3516637856;
            empleado.Id_Cargo = 5;
            empleado.Id_HorarioTrabajo = 1;

            db.EMPLEADOS.Add(empleado);
            db.SaveChanges();
        }
        */

        /*
        //Editar un dato existente
        using (PPAIEntities db = new PPAIEntities())
        {
            //EMPLEADOS empleado = db.EMPLEADOS.Where(emp => emp.Nombre == "Mariano").First(); // Buscar por where
            //EMPLEADOS empleado = db.EMPLEADOS.Find(6); // Buscar por Id
            empleado.Nombre = "Manolo";
            db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        */

        /*
        //Borrar un dato mediante Id
        using (PPAIEntities db = new PPAIEntities())
        {
            EMPLEADOS empleado = db.EMPLEADOS.Find(6);
            db.EMPLEADOS.Remove(empleado);
            db.SaveChanges();
        }*/
    }
}
