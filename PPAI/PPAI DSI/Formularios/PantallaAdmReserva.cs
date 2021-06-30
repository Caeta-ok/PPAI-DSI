using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_DSI.Negocio;

namespace PPAI_DSI.Formularios
{
    public partial class PantallaAdmReserva : Form
    {
        public PantallaAdmReserva()
        {
            InitializeComponent();
            habilitarVentana();
        }

        private void opcionRegReservaVisitaGuiada(object sender, EventArgs e)
        {
            habilitarVentana();
            GestorReserva.iniciarSesion();
            GestorReserva.nuevaReserva();
            mostrarEscuelas(GestorReserva.getListaEscuelas());
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
            GestorReserva.iniciarSesion();
            GestorReserva.nuevaReserva();
            mostrarEscuelas(GestorReserva.getListaEscuelas());
            solicitarSeleccionEscuela();
        }

        public void mostrarEscuelas(List<Escuela> listaEscuelas)
        {
            DataTable items = new DataTable();
            items.Columns.Add("Id_Escuela");
            items.Columns.Add("Nombre");

            int i = 0;
            foreach(Escuela esc in listaEscuelas)
            {
                items.Rows.Add();
                items.Rows[i]["Id_Escuela"] = esc.getId();
                items.Rows[i]["Nombre"] = esc.getNombre();
                i++;
            }
            cmb_escuelas.DataSource = items;
            cmb_escuelas.DisplayMember = "Nombre";
            cmb_escuelas.ValueMember = "Id_Escuela";
            
        }

        private void solicitarSeleccionEscuela(bool estado = true)
        {
            if(estado)
            {
                cmb_escuelas.SelectedIndexChanged += tomarSeleccionEscuela;
            }
            else
            {
                cmb_escuelas.SelectedIndexChanged -= tomarSeleccionEscuela;
            }

        }

        private void solicitarCantidadVisitantes(bool estado = true)
        {
            if(estado)
            {
                txt_cantidad_alumnos.Enabled = true;
            }
            else
            {
                txt_cantidad_alumnos.Enabled = false;
            }
        }

        private void tomarSeleccionEscuela(object sender, EventArgs e)
        {
            solicitarCantidadVisitantes(false);
            GestorReserva.tomarSeleccionEscuela(cmb_escuelas.SelectedIndex);
            solicitarCantidadVisitantes();
        }

        private void tomarNumeroVisitantes(object sender, EventArgs e)
        {
            solicitarSeleccionSede(false);
            grid_sedes.Enabled = true;
            // Faltan validar que sea solo una cadena de numeros enteros
            if(txt_cantidad_alumnos.Text != "")
            {
                int numeroVisitantes = int.Parse(txt_cantidad_alumnos.Text);
                GestorReserva.tomarNumeroVisitantes(numeroVisitantes);
                mostrarSedes(GestorReserva.getSedes());
            }
            solicitarSeleccionSede();
        }

        private void mostrarSedes(List<Sede> listaSedes)
        {
            grid_sedes.DataSource = null;
            grid_sedes.Rows.Clear();
            int i = 0;
            foreach(Sede s in listaSedes)
            {
                grid_sedes.Rows.Add();
                grid_sedes.Rows[i].Cells["Id_Sede"].Value = s.getId();
                grid_sedes.Rows[i].Cells["Nombre"].Value = s.getNombre();
                grid_sedes.Rows[i].Cells["CantidadMaximaVisitantesPorGuia"].Value = s.getCantidadMaximaPorGuia();
                grid_sedes.Rows[i].Cells["CantidadMaximaVisitantes"].Value = s.getCantidadMaixmaVisitantes();
                i++;
            }
            if (grid_sedes.Rows.Count == 0)
            {
                MessageBox.Show("No hay sedes disponibles para esa cantidad de visitantes", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarFormulario();
            }       
        }

        private void solicitarSeleccionSede(bool estado = true)
        {
            if(estado)
            {
                grid_sedes.CellClick += tomarSeleccionSede;
            }
            else
            {
                grid_sedes.CellClick -= tomarSeleccionSede;
            }

        }

        private void tomarSeleccionSede(object sender, DataGridViewCellEventArgs e)
        {
            // La sede de carlos paz tiene una exposicion temporal
            solicitarSeleccionTipoVisita(false);
            txt_cantidad_alumnos.Enabled = false;
            cmb_tipo_visita.Enabled = true;
            for(int i = 0; i < grid_sedes.Rows.Count; i++)
            {
                if (grid_sedes[0, i].Selected)
                {
                    GestorReserva.tomarSeleccionSede(int.Parse(grid_sedes[0, i].Value.ToString()));
                }
            }
            mostrarTiposVisita(GestorReserva.getTiposVisitas());
            solicitarSeleccionTipoVisita();
        }

        private void mostrarTiposVisita(List<TipoVisita> listaTiposVisita)
        {
            DataTable items = new DataTable();
            items.Columns.Add("Id_TipoVisita");
            items.Columns.Add("Nombre");
            int i = 0;
            foreach (TipoVisita tv in listaTiposVisita)
            {
                items.Rows.Add();
                items.Rows[i]["Id_TipoVisita"] = tv.getId();
                items.Rows[i]["Nombre"] = tv.getNombre();
                i++;
            }
            cmb_tipo_visita.DataSource = items;
            cmb_tipo_visita.DisplayMember = "Nombre";
            cmb_tipo_visita.ValueMember = "Id_TipoVisita";
        }

        private void solicitarSeleccionTipoVisita(bool estado = true)
        {
            // Se vuelve a recargar (bug)
            if(estado)
            {
                cmb_tipo_visita.SelectedIndexChanged += tomarSeleccionTipoVisita;
            }
            else
            {
                cmb_tipo_visita.SelectedIndexChanged -= tomarSeleccionTipoVisita;
            }

        }

        private void tomarSeleccionTipoVisita(object sender, EventArgs e)
        {
            // Validar que se seleccione solo por exposicion (lo pide el caso de uso)
            grid_sedes.Enabled = false;
            GestorReserva.tomarSeleccionTipoVisita(cmb_tipo_visita.SelectedIndex);
            if (cmb_tipo_visita.Text == "Por exposicion")
            {
                mostrarExposiciones(GestorReserva.getExposicionesTemporales());
                grid_exposiciones.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por el momento no estan habilitadas las visitas completas, seleccione por exposicion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
        }

        private void mostrarExposiciones(List<Exposicion> listaExposiciones)
        {
            int i = 0;
            grid_exposiciones.DataSource = null;
            grid_exposiciones.Rows.Clear();

            foreach(Exposicion expo in listaExposiciones)
            {
                grid_exposiciones.Rows.Add();
                grid_exposiciones.Rows[i].Cells["Id_Exposicion"].Value = expo.getId();
                grid_exposiciones.Rows[i].Cells["NombreExpo"].Value = expo.getNombre();
                grid_exposiciones.Rows[i].Cells["FechaInicio"].Value = expo.getFechaInicio().ToShortDateString();
                grid_exposiciones.Rows[i].Cells["FechaFin"].Value = expo.getFechaFin().ToShortDateString();
                grid_exposiciones.Rows[i].Cells["HoraApertura"].Value = expo.getHoraApertura().ToString("HH:mm:ss");
                grid_exposiciones.Rows[i].Cells["HoraCierre"].Value = expo.getHoraCierre().ToString("HH:mm:ss");
                grid_exposiciones.Rows[i].Cells["PublicoDestino"].Value = expo.getPublicoDestino().getNombre();
                i++;
            }
            if (grid_exposiciones.Rows.Count == 0)
            {
                MessageBox.Show("No hay exposiciones " + cmb_tipo_visita.Text + " disponibles para esa sede, ingrese nuevamente la caantidad de alumnos y seleccione otra sede", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmb_tipo_visita.Text = "";
                cmb_tipo_visita.Enabled = false;
                txt_cantidad_alumnos.Text = "";
                txt_cantidad_alumnos.Enabled = true;
                grid_sedes.Enabled = false;
                grid_sedes.Rows.Clear();
                grid_exposiciones.Enabled = false;
                btn_ejecutar_registro_reserva.Enabled = false;
            }
        }

        private void solicitarSeleccionExposicion(bool estado = true)
        {
            if(estado)
            {
                grid_exposiciones.CellClick += tomarSeleccionExposicion;
            }
            else
            {
                grid_exposiciones.CellClick -= tomarSeleccionExposicion;
            }
        }

        private void tomarSeleccionExposicion(object sender, DataGridViewCellEventArgs e)
        {
            solicitarFechaReserva(false);
            cmb_tipo_visita.Enabled = false;
            List<int> listaIdExposiciones = new List<int>();
            for(int i = 0; i < grid_exposiciones.Rows.Count; i++)
            {
                if(grid_exposiciones.Rows[i].Selected)
                {
                    listaIdExposiciones.Add(int.Parse(grid_exposiciones[0, i].Value.ToString()));
                }
            }
            GestorReserva.tomarSeleccionExposicion(listaIdExposiciones);
            solicitarFechaReserva();
        }

        private void solicitarFechaReserva(bool estado = true)
        {
            if(estado)
            {
                dt_fecha_reserva.Enabled = true;
            }
            else
            {
                dt_fecha_reserva.Enabled = false;
            }
        }

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

        private void tomarFechaReserva(object sender, EventArgs e)
        {
            // Faltan más validaciones
            solicitarHoraReserva(false);
            if(dt_fecha_reserva.Value > DateTime.Now)
            {
                GestorReserva.tomarFechaReserva(dt_fecha_reserva.Value);
                solicitarHoraReserva();
            }
            else
            {
                MessageBox.Show("La fecha ingresada es inválida");
            }
        }

        private void tomarHoraReserva(object sender, EventArgs e)
        {
            GestorReserva.tomarHoraReserva(dt_hora_reserva.Value);
            grid_exposiciones.Enabled = false;
            grid_guias_disponibles.Enabled = true;
            lbl_duracion.Text = GestorReserva.getDuracionEstimada() + " minutos";
            if(GestorReserva.validarCapacidadVisitantes())
            {
                GestorReserva.buscarGuiasDispFechaReserva();
                mostrarGuiasDisponibles(GestorReserva.getGuiasDisponibles());
                solicitarSeleccionGuia();
            }
            else
            {
                MessageBox.Show("Se sobrepasa la capacidad de visitantes");
            }
        }

        private void mostrarGuiasDisponibles(List<Empleado> listaGuiasDisponibles)
        {
            grid_guias_disponibles.DataSource = null;
            grid_guias_disponibles.Rows.Clear();
            int i = 0;
            foreach(Empleado empleado in listaGuiasDisponibles)
            {
                grid_guias_disponibles.Rows.Add();
                grid_guias_disponibles.Rows[i].Cells["Id_Guia"].Value = empleado.getId();
                grid_guias_disponibles.Rows[i].Cells["NombreEmpleado"].Value = empleado.getNombre();
                grid_guias_disponibles.Rows[i].Cells["ApellidoEmpleado"].Value = empleado.getApellido();
                grid_guias_disponibles.Rows[i].Cells["Email"].Value = empleado.getEmail();
                grid_guias_disponibles.Rows[i].Cells["NroTelefono"].Value = empleado.getNroTelefono();
                grid_guias_disponibles.Rows[i].Cells["HoraEntrada"].Value = empleado.getHorarioTrabajo().getHoraEntrada().ToString("HH:mm:ss");
                grid_guias_disponibles.Rows[i].Cells["HoraSalida"].Value = empleado.getHorarioTrabajo().getHoraSalida().ToString("HH:mm:ss");
                i++;
            }
            if (grid_guias_disponibles.Rows.Count == 0)
            {
                MessageBox.Show("No hay guias disponibles para la fecha: " + dt_fecha_reserva.Text + " y el horario: " + dt_hora_reserva.Text + ", porfavor seleccione nuevamente","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_ejecutar_registro_reserva.Enabled = false;
            }
        }

        private void solicitarSeleccionGuia(bool estado = true)
        {
            if(estado)
            {
                grid_guias_disponibles.CellClick += tomarSeleccionGuia;
            }
            else
            {
                grid_guias_disponibles.CellClick -= tomarSeleccionGuia;
            }
        }

        private void tomarSeleccionGuia(object sender, DataGridViewCellEventArgs e)
        {
            List<int> idGuiasSeleccionados = new List<int>();
            for (int i = 0; i < grid_guias_disponibles.Rows.Count; i++)
            {
                if(grid_guias_disponibles.Rows[i].Selected)
                {
                    idGuiasSeleccionados.Add(int.Parse(grid_guias_disponibles[0, i].Value.ToString()));
                }
            }
            GestorReserva.tomarSeleccionGuias(idGuiasSeleccionados);
            btn_ejecutar_registro_reserva.Enabled = true;
        }

        private void registrarReserva(object sender, EventArgs e)
        {
            GestorReserva.registrarReserva();
            MessageBox.Show("¡Reserva registrada!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            cmb_escuelas.Enabled = true;
            txt_cantidad_alumnos.Text = "";
            txt_cantidad_alumnos.Enabled = false;
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
            lbl_duracion_reserva.Text = "Duracion de Reserva: ";
            btn_ejecutar_registro_reserva.Enabled = false;
        }
    }
}
