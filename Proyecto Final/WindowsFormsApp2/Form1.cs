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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly string _rutaArchivoXml = "achivo.xml";
        private readonly string _tablaUsuario = new DataTable();
        public Form1()
        {
            InitializeComponent();
            InicializarTabla();
        }

        
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
