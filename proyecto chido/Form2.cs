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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();//ayuda a ocultar el formulario 
                Form1 FormularioPrincipal = new Form1();
                FormularioPrincipal.Show();



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
