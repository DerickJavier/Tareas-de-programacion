using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_se_datos_1._2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Persona());
        }

        public class Custumer
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }

        }
    }
}
