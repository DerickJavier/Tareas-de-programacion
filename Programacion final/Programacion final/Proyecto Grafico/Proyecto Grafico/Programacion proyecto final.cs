using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proyecto_Grafico
{
    public partial class Form1 : Form
    {
        private readonly string _rutaArchivoXml = "archivo.xml";
        private readonly DataTable _tablaUsuarios = new DataTable();

        public Form1()
        {
            InitializeComponent();
            InicializarTablaUsuarios();
        }

        private void InicializarTablaUsuarios()
        {
            _tablaUsuarios.Columns.Add("Nombre");
            _tablaUsuarios.Columns.Add("Apellido");
            _tablaUsuarios.Columns.Add("dirección");
            _tablaUsuarios.Columns.Add("Email");
            _tablaUsuarios.Columns.Add("Telefono");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text;
            _tablaUsuarios.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_rutaArchivoXml);
            XmlNodeList usuarios = xmlDoc.GetElementsByTagName("usuario");

            foreach (XmlNode usuario in usuarios)
            {
                string nombre = usuario.Attributes["nombre"].Value.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");
                string apellido = usuario.Attributes["apellido"].Value.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");
                string direccion = usuario.Attributes["direccion"].Value.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");
                string email = usuario.Attributes["email"].Value.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");
                string telefono = usuario.SelectSingleNode("telefono").InnerText.Normalize(NormalizationForm.FormD).ToLower().Replace(" ", "");

                if (nombre.Contains(valorBusqueda) || apellido.Contains(valorBusqueda) || email.Contains(valorBusqueda) || telefono.Contains(valorBusqueda))
                {
                    _tablaUsuarios.Rows.Add(nombre, apellido, direccion, email, telefono);
                }
            }
            dgvResultados.DataSource = _tablaUsuarios;

            if (_tablaUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados para la busqueda");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            BtnBuscar_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
