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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_escuelas = new System.Windows.Forms.ComboBox();
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Escuelas";
            // 
            // txtVisitantes
            // 
            this.txtVisitantes.Enabled = false;
            this.txtVisitantes.Location = new System.Drawing.Point(15, 74);
            this.txtVisitantes.Name = "txtVisitantes";
            this.txtVisitantes.Size = new System.Drawing.Size(47, 20);
            this.txtVisitantes.TabIndex = 29;
            this.txtVisitantes.TextChanged += new System.EventHandler(this.txtVisitantes_Enter);
            this.txtVisitantes.Enter += new System.EventHandler(this.txtVisitantes_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ingrese la cantidad de visitantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Sedes";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(15, 125);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(556, 130);
            this.dgv1.TabIndex = 31;
            this.dgv1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tipos de visita";
            // 
            // cmb_escuelas
            // 
            this.cmb_escuelas.FormattingEnabled = true;
            this.cmb_escuelas.Location = new System.Drawing.Point(15, 25);
            this.cmb_escuelas.Name = "cmb_escuelas";
            this.cmb_escuelas.Size = new System.Drawing.Size(121, 21);
            this.cmb_escuelas.TabIndex = 41;
            this.cmb_escuelas.TextChanged += new System.EventHandler(this.cmb_escuelas_TextChanged);
            this.cmb_escuelas.Enter += new System.EventHandler(this.cmb_escuelas_Enter);
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Location = new System.Drawing.Point(15, 290);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVisita.TabIndex = 42;
            this.cmbTipoVisita.Enter += new System.EventHandler(this.cmbTipoVisita_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Exposiciones";
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(15, 342);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.Size = new System.Drawing.Size(556, 96);
            this.dgv2.TabIndex = 43;
            this.dgv2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_RowHeaderMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 471);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(15, 526);
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
            this.label4.Location = new System.Drawing.Point(12, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de reserva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Hora de reserva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 675);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hora);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.cmbTipoVisita);
            this.Controls.Add(this.cmb_escuelas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVisitantes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ventana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVisitantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_escuelas;
        private System.Windows.Forms.ComboBox cmbTipoVisita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

