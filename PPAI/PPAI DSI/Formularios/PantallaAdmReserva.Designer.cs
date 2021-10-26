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
            this.labelGuiasNecesarios = new System.Windows.Forms.Label();
            this.lbl_duracion = new System.Windows.Forms.Label();
            this.botonEjecutarRegistroReserva = new System.Windows.Forms.Button();
            this.lbl_guias_disponibles = new System.Windows.Forms.Label();
            this.grillaGuiasDisponibles = new System.Windows.Forms.DataGridView();
            this.Id_Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtHoraReserva = new System.Windows.Forms.DateTimePicker();
            this.labelDuracionReserva = new System.Windows.Forms.Label();
            this.comboEscuelas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxCantidadAlumnos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cantidad_alumnos = new System.Windows.Forms.Label();
            this.dtPickerFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.grillaSedes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTiposVisita = new System.Windows.Forms.ComboBox();
            this.grillaExposiciones = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.group_registrar_reserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaGuiasDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaExposiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // group_registrar_reserva
            // 
            this.group_registrar_reserva.Controls.Add(this.lbl_guias_necesarios);
            this.group_registrar_reserva.Controls.Add(this.labelGuiasNecesarios);
            this.group_registrar_reserva.Controls.Add(this.lbl_duracion);
            this.group_registrar_reserva.Controls.Add(this.botonEjecutarRegistroReserva);
            this.group_registrar_reserva.Controls.Add(this.lbl_guias_disponibles);
            this.group_registrar_reserva.Controls.Add(this.grillaGuiasDisponibles);
            this.group_registrar_reserva.Controls.Add(this.dtHoraReserva);
            this.group_registrar_reserva.Controls.Add(this.labelDuracionReserva);
            this.group_registrar_reserva.Controls.Add(this.comboEscuelas);
            this.group_registrar_reserva.Controls.Add(this.label1);
            this.group_registrar_reserva.Controls.Add(this.label6);
            this.group_registrar_reserva.Controls.Add(this.textboxCantidadAlumnos);
            this.group_registrar_reserva.Controls.Add(this.label4);
            this.group_registrar_reserva.Controls.Add(this.txt_cantidad_alumnos);
            this.group_registrar_reserva.Controls.Add(this.dtPickerFechaReserva);
            this.group_registrar_reserva.Controls.Add(this.grillaSedes);
            this.group_registrar_reserva.Controls.Add(this.label5);
            this.group_registrar_reserva.Controls.Add(this.label2);
            this.group_registrar_reserva.Controls.Add(this.comboTiposVisita);
            this.group_registrar_reserva.Controls.Add(this.grillaExposiciones);
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
            // labelGuiasNecesarios
            // 
            this.labelGuiasNecesarios.AutoSize = true;
            this.labelGuiasNecesarios.Location = new System.Drawing.Point(641, 332);
            this.labelGuiasNecesarios.Name = "labelGuiasNecesarios";
            this.labelGuiasNecesarios.Size = new System.Drawing.Size(96, 13);
            this.labelGuiasNecesarios.TabIndex = 56;
            this.labelGuiasNecesarios.Text = "Guias Necesarios: ";
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
            // botonEjecutarRegistroReserva
            // 
            this.botonEjecutarRegistroReserva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonEjecutarRegistroReserva.Enabled = false;
            this.botonEjecutarRegistroReserva.Location = new System.Drawing.Point(1042, 688);
            this.botonEjecutarRegistroReserva.Name = "botonEjecutarRegistroReserva";
            this.botonEjecutarRegistroReserva.Size = new System.Drawing.Size(111, 23);
            this.botonEjecutarRegistroReserva.TabIndex = 54;
            this.botonEjecutarRegistroReserva.Text = "Registrar Reserva";
            this.botonEjecutarRegistroReserva.UseVisualStyleBackColor = true;
            this.botonEjecutarRegistroReserva.Click += new System.EventHandler(this.registrarReserva);
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
            // grillaGuiasDisponibles
            // 
            this.grillaGuiasDisponibles.AllowUserToAddRows = false;
            this.grillaGuiasDisponibles.AllowUserToDeleteRows = false;
            this.grillaGuiasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaGuiasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaGuiasDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Guia,
            this.NombreEmpleado,
            this.ApellidoEmpleado,
            this.Email,
            this.NroTelefono,
            this.HoraEntrada,
            this.HoraSalida});
            this.grillaGuiasDisponibles.Enabled = false;
            this.grillaGuiasDisponibles.Location = new System.Drawing.Point(302, 399);
            this.grillaGuiasDisponibles.Name = "grillaGuiasDisponibles";
            this.grillaGuiasDisponibles.ReadOnly = true;
            this.grillaGuiasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaGuiasDisponibles.Size = new System.Drawing.Size(556, 120);
            this.grillaGuiasDisponibles.TabIndex = 52;
            this.grillaGuiasDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionGuia);
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
            // dtHoraReserva
            // 
            this.dtHoraReserva.CustomFormat = "HH:mm:ss";
            this.dtHoraReserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraReserva.Location = new System.Drawing.Point(594, 279);
            this.dtHoraReserva.Name = "dtHoraReserva";
            this.dtHoraReserva.ShowUpDown = true;
            this.dtHoraReserva.Size = new System.Drawing.Size(109, 20);
            this.dtHoraReserva.TabIndex = 51;
            this.dtHoraReserva.ValueChanged += new System.EventHandler(this.tomarHoraReserva);
            // 
            // labelDuracionReserva
            // 
            this.labelDuracionReserva.AutoSize = true;
            this.labelDuracionReserva.Location = new System.Drawing.Point(373, 332);
            this.labelDuracionReserva.Name = "labelDuracionReserva";
            this.labelDuracionReserva.Size = new System.Drawing.Size(114, 13);
            this.labelDuracionReserva.TabIndex = 50;
            this.labelDuracionReserva.Text = "Duración de Reserva: ";
            // 
            // comboEscuelas
            // 
            this.comboEscuelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEscuelas.FormattingEnabled = true;
            this.comboEscuelas.Location = new System.Drawing.Point(20, 43);
            this.comboEscuelas.Name = "comboEscuelas";
            this.comboEscuelas.Size = new System.Drawing.Size(121, 21);
            this.comboEscuelas.TabIndex = 41;
            this.comboEscuelas.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionEscuela);
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
            // textboxCantidadAlumnos
            // 
            this.textboxCantidadAlumnos.Enabled = false;
            this.textboxCantidadAlumnos.Location = new System.Drawing.Point(229, 44);
            this.textboxCantidadAlumnos.Name = "textboxCantidadAlumnos";
            this.textboxCantidadAlumnos.Size = new System.Drawing.Size(47, 20);
            this.textboxCantidadAlumnos.TabIndex = 29;
            this.textboxCantidadAlumnos.TextChanged += new System.EventHandler(this.tomarNumeroVisitantes);
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
            // dtPickerFechaReserva
            // 
            this.dtPickerFechaReserva.Location = new System.Drawing.Point(376, 279);
            this.dtPickerFechaReserva.Name = "dtPickerFechaReserva";
            this.dtPickerFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFechaReserva.TabIndex = 46;
            this.dtPickerFechaReserva.ValueChanged += new System.EventHandler(this.tomarFechaReserva);
            // 
            // grillaSedes
            // 
            this.grillaSedes.AllowUserToAddRows = false;
            this.grillaSedes.AllowUserToDeleteRows = false;
            this.grillaSedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaSedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSedes.Enabled = false;
            this.grillaSedes.Location = new System.Drawing.Point(20, 90);
            this.grillaSedes.MultiSelect = false;
            this.grillaSedes.Name = "grillaSedes";
            this.grillaSedes.ReadOnly = true;
            this.grillaSedes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaSedes.Size = new System.Drawing.Size(556, 130);
            this.grillaSedes.TabIndex = 31;
            this.grillaSedes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionSede);
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
            // comboTiposVisita
            // 
            this.comboTiposVisita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTiposVisita.Enabled = false;
            this.comboTiposVisita.FormattingEnabled = true;
            this.comboTiposVisita.Location = new System.Drawing.Point(594, 47);
            this.comboTiposVisita.Name = "comboTiposVisita";
            this.comboTiposVisita.Size = new System.Drawing.Size(121, 21);
            this.comboTiposVisita.TabIndex = 42;
            this.comboTiposVisita.SelectedIndexChanged += new System.EventHandler(this.tomarSeleccionTipoVisita);
            // 
            // grillaExposiciones
            // 
            this.grillaExposiciones.AllowUserToAddRows = false;
            this.grillaExposiciones.AllowUserToDeleteRows = false;
            this.grillaExposiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaExposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaExposiciones.Location = new System.Drawing.Point(594, 93);
            this.grillaExposiciones.Name = "grillaExposiciones";
            this.grillaExposiciones.ReadOnly = true;
            this.grillaExposiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaExposiciones.Size = new System.Drawing.Size(556, 127);
            this.grillaExposiciones.TabIndex = 43;
            this.grillaExposiciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionExposicion);
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
            ((System.ComponentModel.ISupportInitialize)(this.grillaGuiasDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaExposiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_registrar_reserva;
        private System.Windows.Forms.Button botonEjecutarRegistroReserva;
        private System.Windows.Forms.Label lbl_guias_disponibles;
        private System.Windows.Forms.DataGridView grillaGuiasDisponibles;
        private System.Windows.Forms.DateTimePicker dtHoraReserva;
        private System.Windows.Forms.Label labelDuracionReserva;
        private System.Windows.Forms.ComboBox comboEscuelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxCantidadAlumnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_cantidad_alumnos;
        private System.Windows.Forms.DateTimePicker dtPickerFechaReserva;
        private System.Windows.Forms.DataGridView grillaSedes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTiposVisita;
        private System.Windows.Forms.DataGridView grillaExposiciones;
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
        private System.Windows.Forms.Label labelGuiasNecesarios;
    }
}