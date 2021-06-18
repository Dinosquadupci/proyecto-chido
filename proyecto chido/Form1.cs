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
        public static string listsPatient;
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
            Patientlist kiko  = new Patientlist();
           /* // kiko.Nombrepaciente = textBox1.Text;
            //nombre.Edadpaciente = Convert.ToInt32(textBox3.Text);
            nombre.Apellidopaciente = textBox2.Text;
            nombre.NSS = textBox4.Text;
            nombre.Sangretype = textBox5.Text;
            nombre.Sintomaspaciente = textBox6.Text;
            nombre.Enfermedadpaciente = chdiab.Checked || chasm.Checked || chhiper.Checked || chale.Checked;
            
            nombre.TriajePaciente = ck1.Checked || ck2.Checked || ck3.Checked || ck4.Checked || ck5.Checked || ck6.Checked || ck7.Checked || ck8.Checked || ck9.Checked || ck10.Checked || ck11.Checked || ck12.Checked;
            */
            switch (casos)
            {
                //casilla 1
                case 1:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;
          
                case 2:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                case 3:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                case 4:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                case 5:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 6:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                case 7:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                case 8:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 9:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                case 10:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 11:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 12:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 13:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 14:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck1.Checked = true;
                    break;

                case 15:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck1.Checked = true;
                    break;

                //casilla 2

                case 16:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 17:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                case 18:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                case 19:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                case 20:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 21:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                case 22:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                case 23:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 24:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                case 25:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 26:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 27:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 28:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 29:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck2.Checked = true;
                    break;

                case 30:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck2.Checked = true;
                    break;

                //casilla 3

                case 31:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 32:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                case 33:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                case 34:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                case 35:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 36:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                case 37:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                case 38:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 39:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                case 40:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 41:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 42:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 43:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 44:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck3.Checked = true;
                    break;

                case 45:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck3.Checked = true;
                    break;

                //casilla 4

                case 46:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 47:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                case 48:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                case 49:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                case 50:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 51:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                case 52:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                case 53:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 54:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                case 55:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 56:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 57:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 58:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 59:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck4.Checked = true;
                    break;

                case 60:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck4.Checked = true;
                    break;

                //casilla 5

                case 61:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 62:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                case 63:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                case 64:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                case 65:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 66:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                case 67:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                case 68:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 69:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                case 70:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 71:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 72:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 73:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 74:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck5.Checked = true;
                    break;

                case 75:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck5.Checked = true;
                    break;

                //casilla 6

                case 76:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 77:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                case 78:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                case 79:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                case 80:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 81:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                case 82:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                case 83:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 84:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                case 85:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 86:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 87:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 88:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 89:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck6.Checked = true;
                    break;

                case 90:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck6.Checked = true;
                    break;

                    //casilla 7

                    //casilla 8

                    //casilla 9

                    //casilla 10

                    //casilla 11

                    //casilla 12


            }
            // Patientlists.Add(nombre);
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
