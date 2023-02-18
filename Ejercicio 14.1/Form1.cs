using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ltsFrutas.Items.Add("Banana");
            ltsFrutas.Items.Add("Durazno");
        }

        private void btnAdiccionar_Click(object sender, EventArgs e)
        {
            ltsFrutas.Items.Add(textFruta.Text);
            textFruta.Text = string.Empty;
        }

        private void ltsFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltsFrutas.SelectedIndex!=-1)
            lblFruta.Text = (string)ltsFrutas.Items[ltsFrutas.SelectedIndex];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = ltsFrutas.SelectedIndex;
            if (indice!=-1)
            {
                ltsFrutas.Items.RemoveAt(indice);
            }
        }
    }
}
