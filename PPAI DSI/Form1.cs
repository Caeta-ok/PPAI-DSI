using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_DSI.Clases;

namespace PPAI_DSI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Ejecutar cadena de consultas en la base de datos
            // SqlQuery: Retorna datos
            // ExecuteSqlCommadn: No retorna nada
            using (PPAIEntities db = new PPAIEntities())
            {
                // Se necesita armar una clase (Empleado) que tenga los campos de la tabla que se devuelve
                List<Empleado> lista = db.Database.SqlQuery<Empleado>("select * from EMPLEADOS").ToList();
                
                //db.Database.ExecuteSqlCommand("insert into ....");
                grid0.DataSource = lista;
            }

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
}
