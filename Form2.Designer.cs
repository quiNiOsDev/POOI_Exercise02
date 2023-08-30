namespace Laboratorio02
{
    partial class Form2
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
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cboDestino.Location = new System.Drawing.Point(261, 140);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(233, 21);
            this.cboDestino.TabIndex = 24;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalcular.Location = new System.Drawing.Point(208, 375);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(186, 40);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtFlete
            // 
            this.txtFlete.Enabled = false;
            this.txtFlete.Location = new System.Drawing.Point(261, 254);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(233, 20);
            this.txtFlete.TabIndex = 22;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Location = new System.Drawing.Point(261, 177);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(233, 20);
            this.txtToneladas.TabIndex = 21;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Enabled = false;
            this.txtTarifa.Location = new System.Drawing.Point(261, 219);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(233, 20);
            this.txtTarifa.TabIndex = 20;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(261, 103);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(233, 20);
            this.txtDestinatario.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Flete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Toneladas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tarifa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Destinatario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(255, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "EMPRESA LEONIDAS";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(261, 323);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(233, 20);
            this.txtMonto.TabIndex = 28;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Enabled = false;
            this.txtSeguro.Location = new System.Drawing.Point(261, 288);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(233, 20);
            this.txtSeguro.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Monto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(96, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Seguro:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtSeguro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}