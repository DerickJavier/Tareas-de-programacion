using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Loteria_1._0
{
    public partial class Form1 : Form
    {
        Random NumeroAleatoreo = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnJuega_Click(object sender, EventArgs e)
        {
            int primera;
            int Segunda;
            int Tercera;
            int Numero;

            Numero =  Convert.ToInt32(txtNumero.Text);
            primera = NumeroAleatoreo.Next(0,99);
            Segunda = NumeroAleatoreo.Next(0,99);
            Tercera = NumeroAleatoreo.Next(0, 99);

            txtPrimera.Text = primera.ToString();
            txtSegunda.Text = Segunda.ToString();
            txtTercera.Text = Tercera.ToString();

            if (Numero == primera)
            {
                lblResultado.Text = "Te sacaste en Primera";
            }
            else if (Numero == Segunda)
            {
                lblResultado.Text = "Te sacaste en Segunda";
            }
            else if (Numero == Tercera)
            {
                lblResultado.Text = "Te sacaste en Tercera";
            }
            else
            {
                lblResultado.Text = "Te Guallaste intentalo otra vez.";
            }
        }
    }
}
