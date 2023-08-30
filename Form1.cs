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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //obtener datos
            Ivovic ivovic = new Ivovic();
            ivovic.destinatario=txtDestinatario.Text;
            ivovic.destino=cboDestino.Text;
            ivovic.toneladas=Double.Parse(txtToneladas.Text);
            ivovic.tarifa=int.Parse(txtTarifa.Text);

            //asignar datos
            txtFlete.Text= ivovic.calcularFlete().ToString();
            

        }
    }
}
