using PPAI_DSI.Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PPAI_DSI
{
    public partial class Form1 : Form
    {
        Ng_FormularioReserva formularioReserva = new Ng_FormularioReserva();
        string nombreExp;
        string horaI;
        string horaF;

        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_hora.Text = "Formato '00:00' 24horas";
            txt_hora.ForeColor = Color.DarkGray;
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
            dgv1.Enabled = false;
            dgv2.Enabled = false;
            dateTimePicker1.Enabled = false;
            txt_hora.Enabled = false;
        }

        private void txtVisitantes_Enter(object sender, EventArgs e)
        {
            if (txtVisitantes.Text != "" && txtVisitantes.Text != null)
            {
                dgv1.Enabled = true;
                using (PPAIEntities db = new PPAIEntities())
                {
                    var lista = (from emp in db.SEDES.ToList()
                                 join Exp in db.EXPOSICIONES on emp.Id_Exposicion equals Exp.Id_Exposicion
                                 where emp.CantidadMaximaVisitantes >= int.Parse(txtVisitantes.Text)
                                 select new
                                 {
                                     emp.Nombre,
                                     emp.CantidadMaximaVisitantes,
                                     emp.CantidadMaximaPorGuia,
                                     Exposicion = Exp.Nombre
                                 }).ToList();
                    dgv1.DataSource = lista;
                }
            }
            else
            {
                cmbTipoVisita.Text = null;
                cmbTipoVisita.Enabled = false;
                dgv1.Enabled = false;
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
            dgv2.Enabled = true;
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
                dgv2.DataSource = lista;
            }
        }

        private void dgv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv1.Enabled = false;
            cmbTipoVisita.Enabled = false;
            nombreExp = dgv2.CurrentRow.Cells[0].Value.ToString();
            horaI = dgv2.CurrentRow.Cells[1].Value.ToString();
            horaF = dgv2.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgv2.Enabled = false;
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
                    txt_hora.Enabled = true;
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

        private void txt_hora_Enter(object sender, EventArgs e)
        {
            txt_hora.Text = null;
            txt_hora.ForeColor = Color.Black;
        }

        private void txt_hora_Leave(object sender, EventArgs e)
        {
            if (txt_hora.Text == "")
            {
                txt_hora.Text = "Formato '00:00' 24horas";
                txt_hora.ForeColor = Color.DarkGray;
            }
        }

        private void txt_hora_TextChanged(object sender, EventArgs e)
        {
            if (txt_hora.ForeColor == Color.Black)
            {
                if (DateTime.Parse(horaI) <= DateTime.Parse(txt_hora.Text))
                {
                    if (DateTime.Parse(horaF) > DateTime.Parse(txt_hora.Text))
                    {

                    }
                    else
                    {
                        MessageBox.Show("En ese horario ya cerro la exposicion, la seleccionada cierra a las: " + horaF, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("En ese horario todabia no abrio la exposicion, la seleccionada abre a las: " + horaI, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
