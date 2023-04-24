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

namespace Base_de_datos_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Apellido;
        private string Telefono;

        public string Cedula { get; private set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(@"c:\tenp\MyData.db"))
            {
                var col = db.GetCollection<Form1>("personas");

                Form1 persona1 = new Form1();

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
