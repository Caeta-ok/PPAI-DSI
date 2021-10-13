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
            habilitarVentana();
        }

        private void opcionRegReservaVisitaGuiada(object sender, EventArgs e)
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
            solicitarFechaReserva(false);
            solicitarHoraReserva(false);
            solicitarSeleccionGuia(false);
            solicitarSeleccionExposicion(false);
            gestorReserva.iniciarSesion();
            gestorReserva.nuevaReserva();
            mostrarEscuelas();
            solicitarSeleccionEscuela();
        }

        //Muestra las escuelas
        public void mostrarEscuelas()
        {
            cmb_escuelas.DataSource = gestorReserva.buscarEscuelas();
            cmb_escuelas.DisplayMember = "Nombre";
        }

        //Habilita combo de selección de escuela.
        private void solicitarSeleccionEscuela(bool estado = true)
        {
            if (estado)
            {
                cmb_escuelas.SelectedIndexChanged += tomarSeleccionEscuela;
            }
            else
            {
                cmb_escuelas.SelectedIndexChanged -= tomarSeleccionEscuela;
            }
        }

        //Habilita el ingreso de la cantidad de visitantes en el txtbox.
        private void solicitarCantidadVisitantes(bool estado = true)
        {
            if (estado)
            {
                cmb_cantidad_alumnos.Enabled = true;
            }
            else
            {
                cmb_cantidad_alumnos.Enabled = false;
            }
        }

        //Envia al gestor el objeto escuela seleccionado y habilita el ingreso de la cantidad de visitantes
        private void tomarSeleccionEscuela(object sender, EventArgs e)
        {
            var _escuelaSeleccionada = (Escuela)cmb_escuelas.SelectedItem;
            gestorReserva.tomarSeleccionEscuela(_escuelaSeleccionada);
            solicitarCantidadVisitantes();
        }

        //Envia al gestor el numero de visitantes ingresado y muestra y habilita la seleccion de sedes
        private void tomarNumeroVisitantes(object sender, EventArgs e)
        {
            //solicitarSeleccionSede(false);
            grid_sedes.Enabled = true;
            if (cmb_cantidad_alumnos.Text != "")
            {
                if(System.Text.RegularExpressions.Regex.IsMatch(cmb_cantidad_alumnos.Text, "[^0-9]") == false)
                {
                    int numeroVisitantes = int.Parse(cmb_cantidad_alumnos.Text);
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
            grid_sedes.DataSource = source;
        }

        //Habilita seleccion de la grilla de Sede
        private void solicitarSeleccionSede(bool estado = true)
        {
            if (estado)
            {
                grid_sedes.Columns["Id"].Visible = false;
                grid_sedes.CellClick += tomarSeleccionSede;
            }
            else
            {
                grid_sedes.CellClick -= tomarSeleccionSede;
            }
        }

        //Envia objeto sede seleccionado al gestor y solicita al gestor las visitas asociadas al mismo
        private void tomarSeleccionSede(object sender, DataGridViewCellEventArgs e)
        {
            // La sede de carlos paz tiene una exposicion temporal
            grid_exposiciones.Rows.Clear();
            //solicitarSeleccionTipoVisita(false);
            cmb_cantidad_alumnos.Enabled = false;
            cmb_tipo_visita.Enabled = true;
            Sede sedeSeleccionada = grid_sedes.SelectedRows[0].DataBoundItem as Sede;
            gestorReserva.tomarSeleccionSede(sedeSeleccionada);
            mostrarTiposVisita();
            solicitarSeleccionTipoVisita();
        }

        //Carga el combo de Tipo de Visitas
        private void mostrarTiposVisita()
        {
            cmb_tipo_visita.DataSource = gestorReserva.buscarTipoVisita();
            cmb_tipo_visita.DisplayMember = "Nombre";
        }

        //Habilita seleccion de TipoVisita
        private void solicitarSeleccionTipoVisita(bool estado = true)
        {
            if (estado)
            {
                cmb_tipo_visita.SelectedIndexChanged += tomarSeleccionTipoVisita;
            }
            else
            {
                cmb_tipo_visita.SelectedIndexChanged -= tomarSeleccionTipoVisita;
            }
        }

        //Envia el Tipo de Visita seleccionada al gestor
        private void tomarSeleccionTipoVisita(object sender, EventArgs e)
        {
            var tipoVisitaSeleccionada = (TipoVisita)cmb_tipo_visita.SelectedItem;
            gestorReserva.tomarSeleccionTipoVisita(tipoVisitaSeleccionada);
            mostrarExposiciones();
        }

        //Muestra las exposiciones depuradas
        private void mostrarExposiciones()
        {
            //solicitarSeleccionExposicion(false);
            var datos = new BindingSource();
            datos.DataSource = gestorReserva.buscarExposicionesTemporales();
            grid_exposiciones.DataSource = datos;
            grid_exposiciones.Columns["Id"].Visible = false;
            grid_exposiciones.Columns["FechaInicio"].Visible = false;
            grid_exposiciones.Columns["FechaInicioReplanificada"].Visible = false;
            grid_exposiciones.Columns["FechaFin"].Visible = false;
            grid_exposiciones.Columns["FechaFinReplanificada"].Visible = false;
            grid_exposiciones.Columns["Empleado"].Visible = false;
            grid_exposiciones.Columns["TipoExposicion"].Visible = false;
            grid_exposiciones.Columns["PublicoDestino"].Visible = false;
            solicitarSeleccionExposicion();
        }

        //Habilita la seleccion de exposicion
        private void solicitarSeleccionExposicion(bool estado = true)
        {
            if (estado)
            {
                grid_exposiciones.CellClick += tomarSeleccionExposicion;
            }
            else
            {
                grid_exposiciones.CellClick -= tomarSeleccionExposicion;
            }
        }

        //Envia las exposiciones seleccionadas al gestor y habilita la seleccion de fecha de reserva
        private void tomarSeleccionExposicion(object sender, DataGridViewCellEventArgs e)
        {
            //solicitarFechaReserva(false);
            cmb_tipo_visita.Enabled = false;
            List<Exposicion> exposicionSeleccionada = new List<Exposicion>();

            foreach (DataGridViewRow row in grid_exposiciones.SelectedRows)
            {
                exposicionSeleccionada.Add(grid_exposiciones.SelectedRows[0].DataBoundItem as Exposicion);
            }
            gestorReserva.tomarSeleccionExposicion(exposicionSeleccionada);
            solicitarFechaReserva();
        }

        //Habilita la seleccion de Fecha de reserva
        private void solicitarFechaReserva(bool estado = true)
        {
            if (estado)
            {
                dt_fecha_reserva.Enabled = true;
            }
            else
            {
                dt_fecha_reserva.Enabled = false;
            }
        }

        //Habilita la seleccion de Hora de reserva
        private void solicitarHoraReserva(bool estado = true)
        {
            if (estado)
            {
                dt_hora_reserva.Enabled = true;
            }
            else
            {
                dt_hora_reserva.Enabled = false;
            }
        }

        //Envia al gestor la fecha seleccionada
        private void tomarFechaReserva(object sender, EventArgs e)
        {
            // Faltan más validaciones
            //solicitarHoraReserva(false);
            DateTime fechaSeleccionada = dt_fecha_reserva.Value;
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
            DateTime horaReserva = dt_hora_reserva.Value;
            gestorReserva.tomarHoraReserva(horaReserva);
            grid_exposiciones.Enabled = false;
            grid_guias_disponibles.Enabled = true;
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
            grid_guias_disponibles.DataSource = null;
            grid_guias_disponibles.Rows.Clear();
            int i = 0;

            foreach (Empleado empleado in listaGuiasDisponibles)
            {
                grid_guias_disponibles.Rows.Add();
                grid_guias_disponibles.Rows[i].Cells["Id_Guia"].Value = empleado.Id;
                grid_guias_disponibles.Rows[i].Cells["NombreEmpleado"].Value = empleado.Nombre;
                grid_guias_disponibles.Rows[i].Cells["ApellidoEmpleado"].Value = empleado.Apellido;
                grid_guias_disponibles.Rows[i].Cells["Email"].Value = empleado.Email;
                grid_guias_disponibles.Rows[i].Cells["NroTelefono"].Value = empleado.NroTelefono;
                grid_guias_disponibles.Rows[i].Cells["HoraEntrada"].Value = empleado.HorarioTrabajo.HoraEntrada.ToString("HH:mm:ss");
                grid_guias_disponibles.Rows[i].Cells["HoraSalida"].Value = empleado.HorarioTrabajo.HoraSalida.ToString("HH:mm:ss");
                i++;
            }
            if (grid_guias_disponibles.Rows.Count == 0)
            {
                MessageBox.Show("No hay guias disponibles para la fecha: " + dt_fecha_reserva.Text + " y el horario: " + dt_hora_reserva.Text + ", porfavor seleccione nuevamente", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_ejecutar_registro_reserva.Enabled = false;
            }
        }

        //Habilita la seleccion de guias
        private void solicitarSeleccionGuia(bool estado = true)
        {
            if (estado)
            {
                grid_guias_disponibles.CellClick += tomarSeleccionGuia;
            }
            else
            {
                grid_guias_disponibles.CellClick -= tomarSeleccionGuia;
            }
        }

        //Envia los guias seleccionados al gestor ((X) Devolver objetos guias) y habilita el boton de registrar visita
        private void tomarSeleccionGuia(object sender, DataGridViewCellEventArgs e)
        {
            List<int> idGuiasSeleccionados = new List<int>();
            for (int i = 0; i < grid_guias_disponibles.Rows.Count; i++)
            {
                if (grid_guias_disponibles.Rows[i].Selected)
                {
                    idGuiasSeleccionados.Add(int.Parse(grid_guias_disponibles[0, i].Value.ToString()));
                }
            }
            gestorReserva.tomarSeleccionGuias(idGuiasSeleccionados);
            btn_ejecutar_registro_reserva.Enabled = true;
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
            cmb_escuelas.Enabled = true;
            cmb_cantidad_alumnos.Text = "";
            cmb_cantidad_alumnos.Enabled = false;
            grid_sedes.Rows.Clear();
            grid_sedes.Enabled = false;
            cmb_tipo_visita.Text = "";
            cmb_tipo_visita.Enabled = false;
            grid_exposiciones.Rows.Clear();
            grid_exposiciones.Enabled = false;
            dt_fecha_reserva.Enabled = false;
            dt_hora_reserva.Enabled = false;
            grid_guias_disponibles.Rows.Clear();
            grid_guias_disponibles.Enabled = false;
            lbl_duracion.Text = "";
            btn_ejecutar_registro_reserva.Enabled = false;
            lbl_guias_necesarios.Text = "";
        }
    }
}
