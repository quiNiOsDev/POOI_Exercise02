namespace Laboratorio02
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(220, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPRESA IVOVIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destinatario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarifa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toneladas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flete:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(226, 91);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(233, 20);
            this.txtDestinatario.TabIndex = 6;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(226, 167);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(233, 20);
            this.txtTarifa.TabIndex = 8;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(226, 207);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(233, 20);
            this.txtToneladas.TabIndex = 9;
            // 
            // txtFlete
            // 
            this.txtFlete.Enabled = false;
            this.txtFlete.Location = new System.Drawing.Point(226, 242);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(233, 20);
            this.txtFlete.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Location = new System.Drawing.Point(175, 311);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(186, 40);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cboDestino
            // 
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Items.AddRange(new object[] {
            "Arequipa",
            "Ilo",
            "Tacna",
            "Piura",
            "Tumbes",
            "Cajamarca",
            "Trujillo",
            "Chimbote"});
            this.cboDestino.Location = new System.Drawing.Point(226, 128);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(233, 21);
            this.cboDestino.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.txtToneladas);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cboDestino;
    }
}

