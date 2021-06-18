using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_chido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnemergency_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();//ayuda a ocultar el formulario 
                Form2 FormularioPrincipal = new Form2();
                FormularioPrincipal.Show();

 

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
