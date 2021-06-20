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
        public string listsPatient;
        public List<Patientlist>Patientlists = new List<Patientlist>();
        
        public Form1()
        {
            InitializeComponent();
            Txtbot.Text = "Hola soy Maxbay su médico de urgencias!";
            
            

    

        }
        int casos;


        private void Form1_Load(object sender, EventArgs e)
        {

            Lista_con_pacientes Formulariopatient = new Lista_con_pacientes();
            Formulariopatient.Show();
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

        public void btnsubir_Click(object sender, EventArgs e)
        {
            Patientlist nombre = new Patientlist();
            nombre.Nombrepaciente = textBox1.Text;
            nombre.Edadpaciente = Convert.ToInt32(textBox3.Text);
            nombre.Apellidopaciente = textBox2.Text;
            nombre.NSS = textBox4.Text;
            nombre.Sangretype = textBox5.Text;
            nombre.Sintomaspaciente = textBox6.Text;
            nombre.Enfermedadpaciente = chdiab.Checked || chasm.Checked || chhiper.Checked || chale.Checked;
            nombre.TriajePaciente = ck1.Checked || ck2.Checked || ck3.Checked || ck4.Checked || ck5.Checked || ck6.Checked || ck7.Checked || ck8.Checked || ck9.Checked || ck10.Checked || ck11.Checked || ck12.Checked;
            
            switch (casos)
            {
                case 1:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;
                //case 2:

           
                   





            }
            //Patientlists.Add(nombre);
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            chale.Checked = false;
            chasm.Checked = false;
            chdiab.Checked = false;
            chhiper.Checked = false;
            ck1.Checked = false;
            ck2.Checked = false;
            ck3.Checked = false;
            ck4.Checked = false;
            ck5.Checked = false;
            ck6.Checked = false;
            ck7.Checked = false;
            ck8.Checked = false;
            ck9.Checked = false;
            ck10.Checked = false;
            ck11.Checked = false;
            ck12.Checked = false;

        
        }

        private void Txtbot_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
