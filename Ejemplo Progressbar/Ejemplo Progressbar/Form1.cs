using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejemplo_Progressbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object ProgressBar1 { get; private set; }
        public object Then { get; private set; }
        public object End { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start()
            label1.Visible= false;
        }

        private string GetV()
        {
            return label2.Text = progressBar1.Value & (" % ");
        }

        private void timer1_Tick(object sender, EventArgs e, string v)
        {
            ProgressBar1.Increment(1)
            if ProgressBar1.value = 100 Then
                    label1.Visible = true
                End 




        }

        private object GetProgressBar1()
        {
            return ProgressBar1;
        }

        private void button2_Click(object sender, EventArgs e, object progressBar1)
        {
            timer1.Stop()
           object value = progressBar1.value;

        }
    }
}
