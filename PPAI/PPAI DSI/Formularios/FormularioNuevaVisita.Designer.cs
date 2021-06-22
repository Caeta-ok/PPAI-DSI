namespace PPAI_DSI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVisitantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_sedes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_escuelas = new System.Windows.Forms.ComboBox();
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_exposiciones = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_registrar_reserva = new System.Windows.Forms.Button();
            this.group_registrar_reserva = new System.Windows.Forms.GroupBox();
            this.lbl_duracion_reserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sedes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_exposiciones)).BeginInit();
            this.group_registrar_reserva.SuspendLayout();
            this.SuspendLayout();
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
            // txtVisitantes
            // 
            this.txtVisitantes.Enabled = false;
            this.txtVisitantes.Location = new System.Drawing.Point(20, 92);
            this.txtVisitantes.Name = "txtVisitantes";
            this.txtVisitantes.Size = new System.Drawing.Size(47, 20);
            this.txtVisitantes.TabIndex = 29;
            this.txtVisitantes.TextChanged += new System.EventHandler(this.txtVisitantes_Enter);
            this.txtVisitantes.Enter += new System.EventHandler(this.txtVisitantes_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ingrese la cantidad de visitantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sedes";
            // 
            // grid_sedes
            // 
            this.grid_sedes.AllowUserToAddRows = false;
            this.grid_sedes.AllowUserToDeleteRows = false;
            this.grid_sedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_sedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sedes.Location = new System.Drawing.Point(20, 147);
            this.grid_sedes.Name = "grid_sedes";
            this.grid_sedes.ReadOnly = true;
            this.grid_sedes.Size = new System.Drawing.Size(556, 130);
            this.grid_sedes.TabIndex = 31;
            this.grid_sedes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipos de visita";
            // 
            // cmb_escuelas
            // 
            this.cmb_escuelas.FormattingEnabled = true;
            this.cmb_escuelas.Location = new System.Drawing.Point(20, 43);
            this.cmb_escuelas.Name = "cmb_escuelas";
            this.cmb_escuelas.Size = new System.Drawing.Size(121, 21);
            this.cmb_escuelas.TabIndex = 41;
            this.cmb_escuelas.TextChanged += new System.EventHandler(this.cmb_escuelas_TextChanged);
            this.cmb_escuelas.Enter += new System.EventHandler(this.cmb_escuelas_Enter);
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Location = new System.Drawing.Point(20, 302);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVisita.TabIndex = 42;
            this.cmbTipoVisita.Enter += new System.EventHandler(this.cmbTipoVisita_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Exposiciones";
            // 
            // grid_exposiciones
            // 
            this.grid_exposiciones.AllowUserToAddRows = false;
            this.grid_exposiciones.AllowUserToDeleteRows = false;
            this.grid_exposiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_exposiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_exposiciones.Location = new System.Drawing.Point(20, 354);
            this.grid_exposiciones.Name = "grid_exposiciones";
            this.grid_exposiciones.ReadOnly = true;
            this.grid_exposiciones.Size = new System.Drawing.Size(556, 96);
            this.grid_exposiciones.TabIndex = 43;
            this.grid_exposiciones.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 482);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(20, 537);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(121, 20);
            this.txt_hora.TabIndex = 47;
            this.txt_hora.TextChanged += new System.EventHandler(this.txt_hora_TextChanged);
            this.txt_hora.Enter += new System.EventHandler(this.txt_hora_Enter);
            this.txt_hora.Leave += new System.EventHandler(this.txt_hora_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de reserva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Hora de reserva";
            // 
            // btn_registrar_reserva
            // 
            this.btn_registrar_reserva.Location = new System.Drawing.Point(12, 23);
            this.btn_registrar_reserva.Name = "btn_registrar_reserva";
            this.btn_registrar_reserva.Size = new System.Drawing.Size(185, 23);
            this.btn_registrar_reserva.TabIndex = 50;
            this.btn_registrar_reserva.Text = "Registrar Reserva de Visita Guiada";
            this.btn_registrar_reserva.UseVisualStyleBackColor = true;
            this.btn_registrar_reserva.Click += new System.EventHandler(this.opcionRegReservaVisitaGuiada);
            // 
            // group_registrar_reserva
            // 
            this.group_registrar_reserva.Controls.Add(this.lbl_duracion_reserva);
            this.group_registrar_reserva.Controls.Add(this.cmb_escuelas);
            this.group_registrar_reserva.Controls.Add(this.label1);
            this.group_registrar_reserva.Controls.Add(this.label6);
            this.group_registrar_reserva.Controls.Add(this.txtVisitantes);
            this.group_registrar_reserva.Controls.Add(this.label4);
            this.group_registrar_reserva.Controls.Add(this.txt_hora);
            this.group_registrar_reserva.Controls.Add(this.label3);
            this.group_registrar_reserva.Controls.Add(this.dateTimePicker1);
            this.group_registrar_reserva.Controls.Add(this.grid_sedes);
            this.group_registrar_reserva.Controls.Add(this.label5);
            this.group_registrar_reserva.Controls.Add(this.label2);
            this.group_registrar_reserva.Controls.Add(this.cmbTipoVisita);
            this.group_registrar_reserva.Controls.Add(this.grid_exposiciones);
            this.group_registrar_reserva.Controls.Add(this.label7);
            this.group_registrar_reserva.Location = new System.Drawing.Point(12, 62);
            this.group_registrar_reserva.Name = "group_registrar_reserva";
            this.group_registrar_reserva.Size = new System.Drawing.Size(616, 587);
            this.group_registrar_reserva.TabIndex = 51;
            this.group_registrar_reserva.TabStop = false;
            this.group_registrar_reserva.Text = "Registrar Reserva";
            this.group_registrar_reserva.Visible = false;
            // 
            // lbl_duracion_reserva
            // 
            this.lbl_duracion_reserva.AutoSize = true;
            this.lbl_duracion_reserva.Location = new System.Drawing.Point(245, 488);
            this.lbl_duracion_reserva.Name = "lbl_duracion_reserva";
            this.lbl_duracion_reserva.Size = new System.Drawing.Size(114, 13);
            this.lbl_duracion_reserva.TabIndex = 50;
            this.lbl_duracion_reserva.Text = "Duración de Reserva: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 765);
            this.Controls.Add(this.group_registrar_reserva);
            this.Controls.Add(this.btn_registrar_reserva);
            this.Name = "Form1";
            this.Text = "Ventana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sedes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_exposiciones)).EndInit();
            this.group_registrar_reserva.ResumeLayout(false);
            this.group_registrar_reserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisitantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid_sedes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_escuelas;
        private System.Windows.Forms.ComboBox cmbTipoVisita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_exposiciones;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_registrar_reserva;
        private System.Windows.Forms.GroupBox group_registrar_reserva;
        private System.Windows.Forms.Label lbl_duracion_reserva;
    }
}

