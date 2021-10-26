using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI.Formularios
{
    public partial class FormEscritorio : Form
    {
        private IconButton btnAcrual;
        private Panel btnBordeIzq;
        private Form hijoActual;
        FormLogIn init = new FormLogIn();
        public FormEscritorio()
        {
            InitializeComponent();
            btnBordeIzq = new Panel();
            btnBordeIzq.Size = new Size(5, 50);
            panelMenu.Controls.Add(btnBordeIzq);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            init.ShowDialog();            
        }
        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txt_hora.Text = DateTime.Now.ToString("HH:mm:ss");
            txt_fecha.Text = DateTime.Now.ToString("dddd, d 'de' MMMM", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(251, 224, 156);
            public static Color color4 = Color.FromArgb(198, 198, 198);
            public static Color color5 = Color.FromArgb(253, 203, 110);
            public static Color color6 = Color.FromArgb(236, 240, 241);
            public static Color color7 = Color.FromArgb(32, 43, 54);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                btnAcrual = (IconButton)senderBtn;
                btnAcrual.BackColor = RGBColors.color6;
                btnAcrual.ForeColor = RGBColors.color7;
                btnAcrual.TextAlign = ContentAlignment.MiddleCenter;
                btnAcrual.IconColor = RGBColors.color7;
                btnAcrual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnAcrual.ImageAlign = ContentAlignment.MiddleRight;
                btnBordeIzq.BackColor = color;
                btnBordeIzq.Location = new Point(0, btnAcrual.Location.Y);
                btnBordeIzq.Visible = true;
                btnBordeIzq.BringToFront();
                icn_actual.IconChar = btnAcrual.IconChar;
                icn_actual.IconColor = RGBColors.color7;
            }
        }
        private void DisableButton()
        {
            if (btnAcrual != null)
            {
                btnAcrual.BackColor = RGBColors.color7;
                btnAcrual.ForeColor = RGBColors.color6;
                btnAcrual.TextAlign = ContentAlignment.MiddleLeft;
                btnAcrual.IconColor = RGBColors.color6;
                btnAcrual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAcrual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (hijoActual != null)
            {
                hijoActual.Close();
            }
            hijoActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            l_icnActual.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            btnBordeIzq.Visible = false;
            icn_actual.IconChar = IconChar.Home;
            icn_actual.IconColor = RGBColors.color3;
            l_icnActual.Text = "Escritorio";
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            if (hijoActual != null)
            {
                hijoActual.Close();
            }
            Reset();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new Frm_Dashboard());
        }
        private void btn_abm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new Frm_Abm());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_fac_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new Frm_Factura());
        }

        private void btn_nuevaObra_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new Frm_AbmGasto());
        }

        private void btn_NuevaReserva_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new PantallaAdmReserva());
            OpenChildForm(new PantallaAdmReserva());
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            FormLogIn frm_Login = new FormLogIn();
            ActivateButton(sender, RGBColors.color5);
            frm_Login.ShowDialog();
        }
    }
}
