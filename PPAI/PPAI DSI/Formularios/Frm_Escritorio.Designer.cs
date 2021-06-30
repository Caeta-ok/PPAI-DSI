namespace nw.Formularios
{
    partial class Frm_Escritorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escritorio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_cerrar = new FontAwesome.Sharp.IconButton();
            this.btn_reportes = new FontAwesome.Sharp.IconButton();
            this.btn_cXp = new FontAwesome.Sharp.IconButton();
            this.btn_fac = new FontAwesome.Sharp.IconButton();
            this.btn_gasto = new FontAwesome.Sharp.IconButton();
            this.btn_op = new FontAwesome.Sharp.IconButton();
            this.btn_abm = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_salir = new FontAwesome.Sharp.IconPictureBox();
            this.btn_min = new FontAwesome.Sharp.IconPictureBox();
            this.btn_max = new FontAwesome.Sharp.IconPictureBox();
            this.l_icnActual = new System.Windows.Forms.Label();
            this.icn_actual = new FontAwesome.Sharp.IconPictureBox();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.txt_hora = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_actual)).BeginInit();
            this.panelEscritorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btn_cerrar);
            this.panelMenu.Controls.Add(this.btn_reportes);
            this.panelMenu.Controls.Add(this.btn_cXp);
            this.panelMenu.Controls.Add(this.btn_fac);
            this.panelMenu.Controls.Add(this.btn_gasto);
            this.panelMenu.Controls.Add(this.btn_op);
            this.panelMenu.Controls.Add(this.btn_abm);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 413);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_cerrar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_cerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_cerrar.IconSize = 30;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(0, 363);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_cerrar.Rotation = 0D;
            this.btn_cerrar.Size = new System.Drawing.Size(188, 50);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "Cerrar sesion";
            this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_reportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_reportes.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            this.btn_reportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_reportes.IconSize = 30;
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(0, 400);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_reportes.Rotation = 0D;
            this.btn_reportes.Size = new System.Drawing.Size(188, 50);
            this.btn_reportes.TabIndex = 7;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // btn_cXp
            // 
            this.btn_cXp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cXp.FlatAppearance.BorderSize = 0;
            this.btn_cXp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cXp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_cXp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_cXp.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btn_cXp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_cXp.IconSize = 30;
            this.btn_cXp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cXp.Location = new System.Drawing.Point(0, 350);
            this.btn_cXp.Name = "btn_cXp";
            this.btn_cXp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_cXp.Rotation = 0D;
            this.btn_cXp.Size = new System.Drawing.Size(188, 50);
            this.btn_cXp.TabIndex = 6;
            this.btn_cXp.Text = "Cliente por propiedad";
            this.btn_cXp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cXp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cXp.UseVisualStyleBackColor = true;
            this.btn_cXp.Click += new System.EventHandler(this.btn_cXp_Click);
            // 
            // btn_fac
            // 
            this.btn_fac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fac.FlatAppearance.BorderSize = 0;
            this.btn_fac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fac.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_fac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_fac.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btn_fac.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_fac.IconSize = 30;
            this.btn_fac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fac.Location = new System.Drawing.Point(0, 300);
            this.btn_fac.Name = "btn_fac";
            this.btn_fac.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_fac.Rotation = 0D;
            this.btn_fac.Size = new System.Drawing.Size(188, 50);
            this.btn_fac.TabIndex = 5;
            this.btn_fac.Text = "Factura";
            this.btn_fac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fac.UseVisualStyleBackColor = true;
            this.btn_fac.Click += new System.EventHandler(this.btn_fac_Click);
            // 
            // btn_gasto
            // 
            this.btn_gasto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_gasto.FlatAppearance.BorderSize = 0;
            this.btn_gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gasto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_gasto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_gasto.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btn_gasto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_gasto.IconSize = 30;
            this.btn_gasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gasto.Location = new System.Drawing.Point(0, 250);
            this.btn_gasto.Name = "btn_gasto";
            this.btn_gasto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_gasto.Rotation = 0D;
            this.btn_gasto.Size = new System.Drawing.Size(188, 50);
            this.btn_gasto.TabIndex = 4;
            this.btn_gasto.Text = "Gasto";
            this.btn_gasto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_gasto.UseVisualStyleBackColor = true;
            this.btn_gasto.Click += new System.EventHandler(this.btn_gasto_Click);
            // 
            // btn_op
            // 
            this.btn_op.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_op.FlatAppearance.BorderSize = 0;
            this.btn_op.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_op.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_op.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_op.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btn_op.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_op.IconSize = 30;
            this.btn_op.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_op.Location = new System.Drawing.Point(0, 200);
            this.btn_op.Name = "btn_op";
            this.btn_op.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_op.Rotation = 0D;
            this.btn_op.Size = new System.Drawing.Size(188, 50);
            this.btn_op.TabIndex = 3;
            this.btn_op.Text = "Operacion";
            this.btn_op.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_op.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_op.UseVisualStyleBackColor = true;
            this.btn_op.Click += new System.EventHandler(this.btn_op_Click);
            // 
            // btn_abm
            // 
            this.btn_abm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_abm.FlatAppearance.BorderSize = 0;
            this.btn_abm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_abm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_abm.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btn_abm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_abm.IconSize = 30;
            this.btn_abm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abm.Location = new System.Drawing.Point(0, 150);
            this.btn_abm.Name = "btn_abm";
            this.btn_abm.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_abm.Rotation = 0D;
            this.btn_abm.Size = new System.Drawing.Size(188, 50);
            this.btn_abm.TabIndex = 2;
            this.btn_abm.Text = "ABM";
            this.btn_abm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abm.UseVisualStyleBackColor = true;
            this.btn_abm.Click += new System.EventHandler(this.btn_abm_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDashboard.IconSize = 30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(188, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Escritorio";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(44, 29);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(96, 47);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 1;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.panelTitleBar.Controls.Add(this.btn_salir);
            this.panelTitleBar.Controls.Add(this.btn_min);
            this.panelTitleBar.Controls.Add(this.btn_max);
            this.panelTitleBar.Controls.Add(this.l_icnActual);
            this.panelTitleBar.Controls.Add(this.icn_actual);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(188, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(595, 29);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_salir.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_salir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_salir.IconSize = 21;
            this.btn_salir.Location = new System.Drawing.Point(570, 3);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(22, 21);
            this.btn_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_salir.TabIndex = 1;
            this.btn_salir.TabStop = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.btn_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_min.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_min.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_min.IconSize = 18;
            this.btn_min.Location = new System.Drawing.Point(518, 3);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(18, 21);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min.TabIndex = 3;
            this.btn_min.TabStop = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.btn_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_max.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_max.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_max.IconSize = 21;
            this.btn_max.Location = new System.Drawing.Point(542, 3);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(22, 21);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_max.TabIndex = 0;
            this.btn_max.TabStop = false;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // l_icnActual
            // 
            this.l_icnActual.AutoSize = true;
            this.l_icnActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.l_icnActual.Location = new System.Drawing.Point(50, 24);
            this.l_icnActual.Name = "l_icnActual";
            this.l_icnActual.Size = new System.Drawing.Size(50, 13);
            this.l_icnActual.TabIndex = 2;
            this.l_icnActual.Text = "Escritorio";
            this.l_icnActual.Visible = false;
            // 
            // icn_actual
            // 
            this.icn_actual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.icn_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.icn_actual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icn_actual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.icn_actual.IconSize = 29;
            this.icn_actual.Location = new System.Drawing.Point(15, 12);
            this.icn_actual.Name = "icn_actual";
            this.icn_actual.Size = new System.Drawing.Size(29, 29);
            this.icn_actual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icn_actual.TabIndex = 0;
            this.icn_actual.TabStop = false;
            this.icn_actual.Visible = false;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.SystemColors.Control;
            this.panelEscritorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEscritorio.BackgroundImage")));
            this.panelEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelEscritorio.Controls.Add(this.txt_hora);
            this.panelEscritorio.Controls.Add(this.txt_fecha);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(188, 29);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(595, 384);
            this.panelEscritorio.TabIndex = 2;
            // 
            // txt_hora
            // 
            this.txt_hora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_hora.AutoSize = true;
            this.txt_hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txt_hora.Location = new System.Drawing.Point(248, 317);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(69, 29);
            this.txt_hora.TabIndex = 2;
            this.txt_hora.Text = "Hora";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txt_fecha.AutoSize = true;
            this.txt_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.txt_fecha.Location = new System.Drawing.Point(155, 279);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(257, 29);
            this.txt_fecha.TabIndex = 1;
            this.txt_fecha.Text = "Fecha del dia de hoy";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Frm_Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(783, 413);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop";
            this.Load += new System.EventHandler(this.Frm_Escritorio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icn_actual)).EndInit();
            this.panelEscritorio.ResumeLayout(false);
            this.panelEscritorio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btn_home;
        private FontAwesome.Sharp.IconButton btn_abm;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label l_icnActual;
        private FontAwesome.Sharp.IconPictureBox icn_actual;
        private System.Windows.Forms.Panel panelEscritorio;
        private FontAwesome.Sharp.IconPictureBox btn_salir;
        private FontAwesome.Sharp.IconPictureBox btn_min;
        private FontAwesome.Sharp.IconPictureBox btn_max;
        private System.Windows.Forms.Label txt_fecha;
        private System.Windows.Forms.Label txt_hora;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btn_fac;
        private FontAwesome.Sharp.IconButton btn_gasto;
        private FontAwesome.Sharp.IconButton btn_op;
        private FontAwesome.Sharp.IconButton btn_cXp;
        private FontAwesome.Sharp.IconButton btn_reportes;
        private FontAwesome.Sharp.IconButton btn_cerrar;
    }
}