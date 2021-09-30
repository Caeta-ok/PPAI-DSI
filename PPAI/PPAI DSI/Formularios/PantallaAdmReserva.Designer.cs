namespace PPAI_DSI.Formularios
{
    partial class PantallaAdmReserva
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
            this.group_registrar_reserva = new System.Windows.Forms.GroupBox();
            this.lbl_guias_necesarios = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.btn_ejecutar_registro_reserva = new System.Windows.Forms.Button();
            this.lbl_guias_disponibles = new System.Windows.Forms.Label();
            this.grid_guias_disponibles = new System.Windows.Forms.DataGridView();
            this.Id_Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_hora_reserva = new System.Windows.Forms.DateTimePicker();
            this.lbl_duracion_reserva = new System.Windows.Forms.Label();
            this.cmb_escuelas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_cantidad_alumnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad_alumnos = new System.Windows.Forms.Label();
            this.dt_fecha_reserva = new System.Windows.Forms.DateTimePicker();
            this.grid_sedes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_tipo_visita = new System.Windows.Forms.ComboBox();
            this.grid_exposiciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.group_registrar_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_guias_disponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_exposiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // group_registrar_reserva
            // 
            this.group_registrar_reserva.Controls.Add(this.lbl_guias_necesarios);
            this.group_registrar_reserva.Controls.Add(this.label9);
            this.group_registrar_reserva.Controls.Add(this.lbl_duracion);
            this.group_registrar_reserva.Controls.Add(this.btn_ejecutar_registro_reserva);
            this.group_registrar_reserva.Controls.Add(this.lbl_guias_disponibles);
            this.group_registrar_reserva.Controls.Add(this.grid_guias_disponibles);
            this.group_registrar_reserva.Controls.Add(this.dt_hora_reserva);
            this.group_registrar_reserva.Controls.Add(this.lbl_duracion_reserva);
            this.group_registrar_reserva.Controls.Add(this.cmb_escuelas);
            this.group_registrar_reserva.Controls.Add(this.label1);
            this.group_registrar_reserva.Controls.Add(this.label6);
            this.group_registrar_reserva.Controls.Add(this.cmb_cantidad_alumnos);
            this.group_registrar_reserva.Controls.Add(this.label4);
            this.group_registrar_reserva.Controls.Add(this.txt_cantidad_alumnos);
            this.group_registrar_reserva.Controls.Add(this.dt_fecha_reserva);
            this.group_registrar_reserva.Controls.Add(this.grid_sedes);
            this.group_registrar_reserva.Controls.Add(this.label5);
            this.group_registrar_reserva.Controls.Add(this.label2);
            this.group_registrar_reserva.Controls.Add(this.cmb_tipo_visita);
            this.group_registrar_reserva.Controls.Add(this.grid_exposiciones);
            this.group_registrar_reserva.Controls.Add(this.label7);
            this.group_registrar_reserva.Location = new System.Drawing.Point(12, 12);
            this.group_registrar_reserva.Name = "group_registrar_reserva";
            this.group_registrar_reserva.Size = new System.Drawing.Size(1159, 717);
            this.group_registrar_reserva.TabIndex = 53;
            this.group_registrar_reserva.TabStop = false;
            this.group_registrar_reserva.Text = "Registrar Reserva";
            // 
            // lbl_guias_necesarios
            // 
            this.lbl_guias_necesarios.AutoSize = true;
            this.lbl_guias_necesarios.Location = new System.Drawing.Point(761, 332);
            this.lbl_guias_necesarios.Name = "lbl_guias_necesarios";
            this.lbl_guias_necesarios.Size = new System.Drawing.Size(10, 13);
            this.lbl_guias_necesarios.TabIndex = 57;
            this.lbl_guias_necesarios.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Guias Necesarios: ";
            // 
            // lbl_duracion
            // 
            this.lbl_duracion.AutoSize = true;
            this.lbl_duracion.Location = new System.Drawing.Point(493, 332);
            this.lbl_duracion.Name = "lbl_duracion";
            this.lbl_duracion.Size = new System.Drawing.Size(10, 13);
            this.lbl_duracion.TabIndex = 55;
            this.lbl_duracion.Text = " ";
            // 
            // btn_ejecutar_registro_reserva
            // 
            this.btn_ejecutar_registro_reserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ejecutar_registro_reserva.Enabled = false;
            this.btn_ejecutar_registro_reserva.Location = new System.Drawing.Point(1042, 688);
            this.btn_ejecutar_registro_reserva.Name = "btn_ejecutar_registro_reserva";
            this.btn_ejecutar_registro_reserva.Size = new System.Drawing.Size(111, 23);
            this.btn_ejecutar_registro_reserva.TabIndex = 54;
            this.btn_ejecutar_registro_reserva.Text = "Registrar Reserva";
            this.btn_ejecutar_registro_reserva.UseVisualStyleBackColor = true;
            this.btn_ejecutar_registro_reserva.Click += new System.EventHandler(this.registrarReserva);
            // 
            // lbl_guias_disponibles
            // 
            this.lbl_guias_disponibles.AutoSize = true;
            this.lbl_guias_disponibles.Location = new System.Drawing.Point(299, 383);
            this.lbl_guias_disponibles.Name = "lbl_guias_disponibles";
            this.lbl_guias_disponibles.Size = new System.Drawing.Size(89, 13);
            this.lbl_guias_disponibles.TabIndex = 53;
            this.lbl_guias_disponibles.Text = "Guias disponibles";
            // 
            // grid_guias_disponibles
            // 
            this.grid_guias_disponibles.AllowUserToAddRows = false;
            this.grid_guias_disponibles.AllowUserToDeleteRows = false;
            this.grid_guias_disponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_guias_disponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_guias_disponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Guia,
            this.NombreEmpleado,
            this.ApellidoEmpleado,
            this.Email,
            this.NroTelefono,
            this.HoraEntrada,
            this.HoraSalida});
            this.grid_guias_disponibles.Enabled = false;
            this.grid_guias_disponibles.Location = new System.Drawing.Point(302, 399);
            this.grid_guias_disponibles.Name = "grid_guias_disponibles";
            this.grid_guias_disponibles.ReadOnly = true;
            this.grid_guias_disponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_guias_disponibles.Size = new System.Drawing.Size(556, 120);
            this.grid_guias_disponibles.TabIndex = 52;
            this.grid_guias_disponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionGuia);
            // 
            // Id_Guia
            // 
            this.Id_Guia.HeaderText = "Id_Guia";
            this.Id_Guia.Name = "Id_Guia";
            this.Id_Guia.ReadOnly = true;
            this.Id_Guia.Visible = false;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "Nombre";
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.ReadOnly = true;
            // 
            // ApellidoEmpleado
            // 
            this.ApellidoEmpleado.HeaderText = "Apellido";
            this.ApellidoEmpleado.Name = "ApellidoEmpleado";
            this.ApellidoEmpleado.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // NroTelefono
            // 
            this.NroTelefono.HeaderText = "NroTelefono";
            this.NroTelefono.Name = "NroTelefono";
            this.NroTelefono.ReadOnly = true;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.HeaderText = "Hora de entrada";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            // 
            // HoraSalida
            // 
            this.HoraSalida.HeaderText = "Hora de salida";
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.ReadOnly = true;
            // 
            // dt_hora_reserva
            // 
            this.dt_hora_reserva.CustomFormat = "HH:mm:ss";
            this.dt_hora_reserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_hora_reserva.Location = new System.Drawing.Point(594, 279);
            this.dt_hora_reserva.Name = "dt_hora_reserva";
            this.dt_hora_reserva.ShowUpDown = true;
            this.dt_hora_reserva.Size = new System.Drawing.Size(109, 20);
            this.dt_hora_reserva.TabIndex = 51;
            this.dt_hora_reserva.ValueChanged += new System.EventHandler(this.tomarHoraReserva);
            // 
            // lbl_duracion_reserva
            // 
            this.lbl_duracion_reserva.AutoSize = true;
            this.lbl_duracion_reserva.Location = new System.Drawing.Point(373, 332);
            this.lbl_duracion_reserva.Name = "lbl_duracion_reserva";
            this.lbl_duracion_reserva.Size = new System.Drawing.Size(114, 13);
            this.lbl_duracion_reserva.TabIndex = 50;
            this.lbl_duracion_reserva.Text = "Duración de Reserva: ";
            // 
            // cmb_escuelas
            // 
            this.cmb_escuelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_escuelas.FormattingEnabled = true;
            this.cmb_escuelas.Location = new System.Drawing.Point(20, 43);
            this.cmb_escuelas.Name = "cmb_escuelas";
            this.cmb_escuelas.Size = new System.Drawing.Size(121, 21);
            this.cmb_escuelas.TabIndex = 41;
            this.cmb_escuelas.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionEscuela);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Escuelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Hora de reserva";
            // 
            // cmb_cantidad_alumnos
            // 
            this.cmb_cantidad_alumnos.Enabled = false;
            this.cmb_cantidad_alumnos.Location = new System.Drawing.Point(229, 44);
            this.cmb_cantidad_alumnos.Name = "cmb_cantidad_alumnos";
            this.cmb_cantidad_alumnos.Size = new System.Drawing.Size(47, 20);
            this.cmb_cantidad_alumnos.TabIndex = 29;
            this.cmb_cantidad_alumnos.TextChanged += new System.EventHandler(this.tomarNumeroVisitantes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de reserva";
            // 
            // txt_cantidad_alumnos
            // 
            this.txt_cantidad_alumnos.AutoSize = true;
            this.txt_cantidad_alumnos.Location = new System.Drawing.Point(226, 27);
            this.txt_cantidad_alumnos.Name = "txt_cantidad_alumnos";
            this.txt_cantidad_alumnos.Size = new System.Drawing.Size(159, 13);
            this.txt_cantidad_alumnos.TabIndex = 30;
            this.txt_cantidad_alumnos.Text = "Ingrese la cantidad de visitantes";
            // 
            // dt_fecha_reserva
            // 
            this.dt_fecha_reserva.Location = new System.Drawing.Point(376, 279);
            this.dt_fecha_reserva.Name = "dt_fecha_reserva";
            this.dt_fecha_reserva.Size = new System.Drawing.Size(200, 20);
            this.dt_fecha_reserva.TabIndex = 46;
            this.dt_fecha_reserva.ValueChanged += new System.EventHandler(this.tomarFechaReserva);
            // 
            // grid_sedes
            // 
            this.grid_sedes.AllowUserToAddRows = false;
            this.grid_sedes.AllowUserToDeleteRows = false;
            this.grid_sedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sedes.Enabled = false;
            this.grid_sedes.Location = new System.Drawing.Point(20, 90);
            this.grid_sedes.MultiSelect = false;
            this.grid_sedes.Name = "grid_sedes";
            this.grid_sedes.ReadOnly = true;
            this.grid_sedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_sedes.Size = new System.Drawing.Size(556, 130);
            this.grid_sedes.TabIndex = 31;
            this.grid_sedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionSede);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sedes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Exposiciones";
            // 
            // cmb_tipo_visita
            // 
            this.cmb_tipo_visita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_visita.Enabled = false;
            this.cmb_tipo_visita.FormattingEnabled = true;
            this.cmb_tipo_visita.Location = new System.Drawing.Point(594, 47);
            this.cmb_tipo_visita.Name = "cmb_tipo_visita";
            this.cmb_tipo_visita.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo_visita.TabIndex = 42;
            this.cmb_tipo_visita.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionTipoVisita);
            // 
            // grid_exposiciones
            // 
            this.grid_exposiciones.AllowUserToAddRows = false;
            this.grid_exposiciones.AllowUserToDeleteRows = false;
            this.grid_exposiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_exposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_exposiciones.Location = new System.Drawing.Point(594, 93);
            this.grid_exposiciones.Name = "grid_exposiciones";
            this.grid_exposiciones.ReadOnly = true;
            this.grid_exposiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_exposiciones.Size = new System.Drawing.Size(556, 127);
            this.grid_exposiciones.TabIndex = 43;
            this.grid_exposiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionExposicion);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(591, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipos de visita";
            // 
            // PantallaAdmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 731);
            this.Controls.Add(this.group_registrar_reserva);
            this.Name = "PantallaAdmReserva";
            this.Text = "PantallaAdmReserva";
            this.group_registrar_reserva.ResumeLayout(false);
            this.group_registrar_reserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_guias_disponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_exposiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_registrar_reserva;
        private System.Windows.Forms.Button btn_ejecutar_registro_reserva;
        private System.Windows.Forms.Label lbl_guias_disponibles;
        private System.Windows.Forms.DataGridView grid_guias_disponibles;
        private System.Windows.Forms.DateTimePicker dt_hora_reserva;
        private System.Windows.Forms.Label lbl_duracion_reserva;
        private System.Windows.Forms.ComboBox cmb_escuelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cmb_cantidad_alumnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_cantidad_alumnos;
        private System.Windows.Forms.DateTimePicker dt_fecha_reserva;
        private System.Windows.Forms.DataGridView grid_sedes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_tipo_visita;
        private System.Windows.Forms.DataGridView grid_exposiciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Guia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
        private System.Windows.Forms.Label lbl_guias_necesarios;
        private System.Windows.Forms.Label label9;
    }
}