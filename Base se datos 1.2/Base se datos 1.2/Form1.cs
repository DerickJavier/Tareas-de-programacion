using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_se_datos_1._2
{
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }

        public string Apellido { get; private set; }
        public string Telefono { get; private set; }
        public string Cedula { get; private set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            using (var db = new LiteDatabase(@"c:\Tenp\myData.db"))
            {
                var col = db.GetCollection<Persona>("personas");

                Persona persona1 = new Persona();

                persona1.Name = txtNombre.Text;
                persona1.Apellido = txtApellido.Text;
                persona1.Telefono = txtTelefono.Text;
                persona1.Cedula = txtCedula.Text;


                col.Insert(persona1);

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtTelefono.Text = "";
                txtCedula.Text = "";

            }

        }
    }
}