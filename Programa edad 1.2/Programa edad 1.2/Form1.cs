using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_edad_1._2
{
    public partial class Form1 : Form
    {
        DateTime fechaNaciemiento;
        DateTime fechaActual; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_TextChanged(object sender, EventArgs e)
        {
            fechaActual = DateTime.Today;
            fechaNaciemiento = dateTimePicker1.Value;

            int result = fechaActual.Year - fechaNaciemiento.Year;
            lblResultado.Text = result.ToString();

        }
    }
}
