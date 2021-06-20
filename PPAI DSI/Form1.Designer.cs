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
            this.btn_boton = new System.Windows.Forms.Button();
            this.combo = new System.Windows.Forms.ComboBox();
            this.grid0 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid0)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_boton
            // 
            this.btn_boton.Location = new System.Drawing.Point(184, 21);
            this.btn_boton.Name = "btn_boton";
            this.btn_boton.Size = new System.Drawing.Size(67, 24);
            this.btn_boton.TabIndex = 0;
            this.btn_boton.Text = "Boton";
            this.btn_boton.UseVisualStyleBackColor = true;
            // 
            // combo
            // 
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(31, 21);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(138, 21);
            this.combo.TabIndex = 7;
            // 
            // grid0
            // 
            this.grid0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid0.Location = new System.Drawing.Point(31, 63);
            this.grid0.Name = "grid0";
            this.grid0.Size = new System.Drawing.Size(920, 183);
            this.grid0.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 272);
            this.Controls.Add(this.grid0);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.btn_boton);
            this.Name = "Form1";
            this.Text = "Ventana";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_boton;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.DataGridView grid0;
    }
}

