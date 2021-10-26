using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PPAI_DSI.Negocio;

namespace PPAI_DSI.Formularios
{
    public partial class PantallaAdmReserva : Form
    {
        private GestorReserva gestorReserva = new GestorReserva();

        public PantallaAdmReserva()
        {
            InitializeComponent();
            //habilitarVentana();
            this.opcionRegReservaVisitaGuiada();
        }

        public void opcionRegReservaVisitaGuiada()
        {
            habilitarVentana();
            gestorReserva.iniciarSesion();
            gestorReserva.nuevaReserva();
            mostrarEscuelas();
            solicitarSeleccionEscuela();
        }

        private void habilitarVentana()
        {
            solicitarCantidadVisitantes(false);
            solicitarSeleccionEscuela(false);
            solicitarSeleccionSede(false);
            solicitarSeleccionTipoVisita(false);
            solicitarFechaReserva(false);
            solicitarHoraReserva(false);
            solicitarSeleccionGuia(false);
            solicitarSeleccionExposicion(false);
            //gestorReserva.iniciarSesion();
            //gestorReserva.nuevaReserva();
            //mostrarEscuelas();
            //solicitarSeleccionEscuela();
        }

        //Muestra las escuelas
        public void mostrarEscuelas()
        {
            comboEscuelas.DataSource = gestorReserva.buscarEscuelas();
            comboEscuelas.DisplayMember = "Nombre";
        }

        //Habilita combo de selección de escuela.
        private void solicitarSeleccionEscuela(bool estado = true)
        {
            if (estado)
            {
                comboEscuelas.SelectedIndexChanged += tomarSeleccionEscuela;
            }
            else
            {
                comboEscuelas.SelectedIndexChanged -= tomarSeleccionEscuela;
            }
        }

        //Habilita el ingreso de la cantidad de visitantes en el txtbox.
        private void solicitarCantidadVisitantes(bool estado = true)
        {
            if (estado)
            {
                textboxCantidadAlumnos.Enabled = true;
            }
            else
            {
                textboxCantidadAlumnos.Enabled = false;
            }
        }

        //Envia al gestor el objeto escuela seleccionado y habilita el ingreso de la cantidad de visitantes
        private void tomarSeleccionEscuela(object sender, EventArgs e)
        {
            var _escuelaSeleccionada = (Escuela)comboEscuelas.SelectedItem;
            gestorReserva.tomarSeleccionEscuela(_escuelaSeleccionada);
            solicitarCantidadVisitantes();
        }

        //Envia al gestor el numero de visitantes ingresado y muestra y habilita la seleccion de sedes
        private void tomarNumeroVisitantes(object sender, EventArgs e)
        {
            solicitarSeleccionSede(false); // Es necesario para no añadir nuevas llamadas al evento CellClick de la grilla
                                           // Cada vez que se digita un número en la cantidad de visitantes se ejecuta este método
                                           // Si no estuviera solicitarSeleccionSede(false) se añadiría una llamada al evento
                                           // CellClick por cada click generando fallas por multiples llamadas
            grillaSedes.Enabled = true;
            if (textboxCantidadAlumnos.Text != "")
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(textboxCantidadAlumnos.Text, "[^0-9]") == false)
                {
                    int numeroVisitantes = int.Parse(textboxCantidadAlumnos.Text);
                    gestorReserva.tomarNumeroVisitantes(numeroVisitantes);
                    mostrarSedes();
                    solicitarSeleccionSede();
                }
                else
                {
                    MessageBox.Show("La cantidad de alumnos ingresada es inválida");
                }
            }
        }

        //Muestra las sedes existentes
        private void mostrarSedes()
        {
            var source = new BindingSource();
            source.DataSource = gestorReserva.buscarSedes();
            grillaSedes.DataSource = source;
        }

        //Habilita seleccion de la grilla de Sede
        private void solicitarSeleccionSede(bool estado = true)
        {
            if (estado)
            {
                grillaSedes.Columns["Id"].Visible = false;
                grillaSedes.CellClick += tomarSeleccionSede;
            }
            else
            {
                grillaSedes.CellClick -= tomarSeleccionSede;
            }
        }

        //Envia objeto sede seleccionado al gestor y solicita al gestor las visitas asociadas al mismo
        private void tomarSeleccionSede(object sender, DataGridViewCellEventArgs e)
        {
            // La sede de carlos paz tiene una exposicion temporal
            grillaExposiciones.Rows.Clear();
            //solicitarSeleccionTipoVisita(false);
            textboxCantidadAlumnos.Enabled = false;
            //comboTiposVisita.Enabled = true;
            Sede sedeSeleccionada = grillaSedes.SelectedRows[0].DataBoundItem as Sede;
            gestorReserva.tomarSeleccionSede(sedeSeleccionada);
            mostrarTiposVisita();
            solicitarSeleccionTipoVisita();
        }

        //Carga el combo de Tipo de Visitas
        private void mostrarTiposVisita()
        {
            comboTiposVisita.DataSource = gestorReserva.buscarTipoVisita();
            comboTiposVisita.DisplayMember = "Nombre";
        }

        //Habilita seleccion de TipoVisita
        private void solicitarSeleccionTipoVisita(bool estado = true)
        {
            if (estado)
            {
                comboTiposVisita.SelectedIndexChanged += tomarSeleccionTipoVisita;
                comboTiposVisita.Enabled = true;
            }
            else
            {
                comboTiposVisita.SelectedIndexChanged -= tomarSeleccionTipoVisita;
            }

        }

        //Envia el Tipo de Visita seleccionada al gestor
        private void tomarSeleccionTipoVisita(object sender, EventArgs e)
        {
            var tipoVisitaSeleccionada = (TipoVisita)comboTiposVisita.SelectedItem;
            gestorReserva.tomarSeleccionTipoVisita(tipoVisitaSeleccionada);
            mostrarExposiciones();
        }

        //Muestra las exposiciones depuradas
        private void mostrarExposiciones()
        {
            //solicitarSeleccionExposicion(false);
            var datos = new BindingSource();
            datos.DataSource = gestorReserva.buscarExposicionesTemporales();
            grillaExposiciones.DataSource = datos;
            grillaExposiciones.Columns["Id"].Visible = false;
            grillaExposiciones.Columns["FechaInicio"].Visible = false;
            grillaExposiciones.Columns["FechaInicioReplanificada"].Visible = false;
            grillaExposiciones.Columns["FechaFin"].Visible = false;
            grillaExposiciones.Columns["FechaFinReplanificada"].Visible = false;
            grillaExposiciones.Columns["Empleado"].Visible = false;
            grillaExposiciones.Columns["TipoExposicion"].Visible = false;
            grillaExposiciones.Columns["PublicoDestino"].Visible = false;
            solicitarSeleccionExposicion();
        }

        //Habilita la seleccion de exposicion
        private void solicitarSeleccionExposicion(bool estado = true)
        {
            if (estado)
            {
                grillaExposiciones.CellClick += tomarSeleccionExposicion;
            }
            else
            {
                grillaExposiciones.CellClick -= tomarSeleccionExposicion;
            }
        }

        //Envia las exposiciones seleccionadas al gestor y habilita la seleccion de fecha de reserva
        private void tomarSeleccionExposicion(object sender, DataGridViewCellEventArgs e)
        {
            //solicitarFechaReserva(false);
            comboTiposVisita.Enabled = false;
            List<Exposicion> exposicionSeleccionada = new List<Exposicion>();

            foreach (DataGridViewRow row in grillaExposiciones.SelectedRows)
            {
                exposicionSeleccionada.Add(grillaExposiciones.SelectedRows[0].DataBoundItem as Exposicion);
            }
            gestorReserva.tomarSeleccionExposicion(exposicionSeleccionada);
            solicitarFechaReserva();
        }

        //Habilita la seleccion de Fecha de reserva
        private void solicitarFechaReserva(bool estado = true)
        {
            if (estado)
            {
                dtPickerFechaReserva.Enabled = true;
            }
            else
            {
                dtPickerFechaReserva.Enabled = false;
            }
        }

        //Habilita la seleccion de Hora de reserva
        private void solicitarHoraReserva(bool estado = true)
        {
            if (estado)
            {
                dtHoraReserva.Enabled = true;
            }
            else
            {
                dtHoraReserva.Enabled = false;
            }
        }

        //Envia al gestor la fecha seleccionada
        private void tomarFechaReserva(object sender, EventArgs e)
        {
            // Faltan más validaciones
            //solicitarHoraReserva(false);
            DateTime fechaSeleccionada = dtPickerFechaReserva.Value;
            if (fechaSeleccionada > DateTime.Now)
            {
                gestorReserva.tomarFechaReserva(fechaSeleccionada);
                solicitarHoraReserva();
            }
            else
            {
                MessageBox.Show("La fecha ingresada es inválida");
            }
        }

        //Envia la hora seleccionada al gestor ((X) gestor delega las validaciones a las clases)
        private void tomarHoraReserva(object sender, EventArgs e)
        {
            DateTime horaReserva = dtHoraReserva.Value;
            gestorReserva.tomarHoraReserva(horaReserva);
            grillaExposiciones.Enabled = false;
            grillaGuiasDisponibles.Enabled = true;
            this.mostrarDuracionEstimada();
            //lbl_duracion.Text = gestorReserva.getDuracionEstimada() + " minutos";
            if (gestorReserva.validarCapacidadVisitantes())
            {
                gestorReserva.buscarGuiasDispFechaReserva();
                lbl_guias_necesarios.Text = gestorReserva.getGuiasNecesarios().ToString();
                mostrarGuiasDisponibles();
                solicitarSeleccionGuia();
            }
            else
            {
                MessageBox.Show("Se sobrepasa la capacidad de visitantes");
            }
        }

        private void mostrarDuracionEstimada()
        {
            lbl_duracion.Text = gestorReserva.getDuracionEstimada() + " minutos";
        }

        //Muestra los guias disponibles ((X) Validar en el gestor y las clases correspondientes)
        private void mostrarGuiasDisponibles()
        {
            List<Empleado> listaGuiasDisponibles = gestorReserva.getGuiasDisponibles();
            grillaGuiasDisponibles.DataSource = null;
            grillaGuiasDisponibles.Rows.Clear();
            int i = 0;

            foreach (Empleado empleado in listaGuiasDisponibles)
            {
                grillaGuiasDisponibles.Rows.Add();
                grillaGuiasDisponibles.Rows[i].Cells["Id_Guia"].Value = empleado.Id;
                grillaGuiasDisponibles.Rows[i].Cells["NombreEmpleado"].Value = empleado.Nombre;
                grillaGuiasDisponibles.Rows[i].Cells["ApellidoEmpleado"].Value = empleado.Apellido;
                grillaGuiasDisponibles.Rows[i].Cells["Email"].Value = empleado.Email;
                grillaGuiasDisponibles.Rows[i].Cells["NroTelefono"].Value = empleado.NroTelefono;
                grillaGuiasDisponibles.Rows[i].Cells["HoraEntrada"].Value = empleado.HorarioTrabajo.HoraEntrada.ToString("HH:mm:ss");
                grillaGuiasDisponibles.Rows[i].Cells["HoraSalida"].Value = empleado.HorarioTrabajo.HoraSalida.ToString("HH:mm:ss");
                i++;
            }
            if (grillaGuiasDisponibles.Rows.Count == 0)
            {
                MessageBox.Show("No hay guias disponibles para la fecha: " + dtPickerFechaReserva.Text + " y el horario: " + dtHoraReserva.Text + ", porfavor seleccione nuevamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                botonEjecutarRegistroReserva.Enabled = false;
            }
        }

        //Habilita la seleccion de guias
        private void solicitarSeleccionGuia(bool estado = true)
        {
            if (estado)
            {
                grillaGuiasDisponibles.CellClick += tomarSeleccionGuia;
            }
            else
            {
                grillaGuiasDisponibles.CellClick -= tomarSeleccionGuia;
            }
        }

        //Envia los guias seleccionados al gestor ((X) Devolver objetos guias) y habilita el boton de registrar visita
        private void tomarSeleccionGuia(object sender, DataGridViewCellEventArgs e)
        {
            List<int> idGuiasSeleccionados = new List<int>();
            for (int i = 0; i < grillaGuiasDisponibles.Rows.Count; i++)
            {
                if (grillaGuiasDisponibles.Rows[i].Selected)
                {
                    idGuiasSeleccionados.Add(int.Parse(grillaGuiasDisponibles[0, i].Value.ToString()));
                }
            }
            gestorReserva.tomarSeleccionGuias(idGuiasSeleccionados);
            botonEjecutarRegistroReserva.Enabled = true;
        }

        //Registra la reserva ((X) Mostrar previa de la reserva antes de cerrar)
        private void registrarReserva(object sender, EventArgs e)
        {
            gestorReserva.registrarReserva();
            MessageBox.Show("¡Reserva registrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpiarFormulario();
        }

        //Limpia el formulario para una nueva reserva.
        private void limpiarFormulario()
        {
            comboEscuelas.Enabled = true;
            textboxCantidadAlumnos.Text = "";
            textboxCantidadAlumnos.Enabled = false;
            grillaSedes.Rows.Clear();
            grillaSedes.Enabled = false;
            comboTiposVisita.Text = "";
            comboTiposVisita.Enabled = false;
            grillaExposiciones.Rows.Clear();
            grillaExposiciones.Enabled = false;
            dtPickerFechaReserva.Enabled = false;
            dtHoraReserva.Enabled = false;
            grillaGuiasDisponibles.Rows.Clear();
            grillaGuiasDisponibles.Enabled = false;
            lbl_duracion.Text = "";
            botonEjecutarRegistroReserva.Enabled = false;
            lbl_guias_necesarios.Text = "";
        }
    }
}
