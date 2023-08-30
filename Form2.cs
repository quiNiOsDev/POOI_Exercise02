using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio02
{
    public  partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Leonidas leonidas = new Leonidas()
            {
                destinatario=txtDestinatario.Text,
                destino=cboDestino.Text,
                toneladas=Double.Parse(txtToneladas.Text)
            };

            txtTarifa.Text= leonidas.calcularTarifario().ToString();
            txtFlete.Text = leonidas.calcularFlete().ToString();
            txtSeguro.Text = leonidas.calcularSeguro().ToString();
            txtMonto.Text=leonidas.calcularMonto().ToString();  
            
        }
    }
}
