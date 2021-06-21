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
        public static string Patientlists1;
        public   List<Patientlist>Patientlists = new List<Patientlist>();
        public Lista_con_pacientes Formulariopatient = new Lista_con_pacientes();
        public Form1()
        {
            InitializeComponent();
            Txtbot.Text = "Hola soy Maxbay su médico de urgencias!";

            
            Formulariopatient.Show();
            



        }
        public string nombre1 = "";
        public string edad = "";

        int casos;
        //int triaje = 0;


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

                Formulariopatient.Hide();
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
            nombre1 = textBox1.Text;
            edad = textBox3.Text;

            Patientlist.Nombrepaciente = textBox1.Text;
            Patientlist.Apellidopaciente = textBox2.Text;
            try
            {
                Patientlist.Edadpaciente = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception error)

            {
                MessageBox.Show(error.Message);
            }
            Patientlist.Sangretype = textBox5.Text;
            Patientlist.NSS = textBox4.Text;
            Patientlist.Sintomaspaciente = textBox6.Text;
            Patientlist.Enfermedadpaciente = chdiab.Checked || chasm.Checked || chhiper.Checked || chale.Checked;
            Patientlist.TriajePaciente = ck1.Checked || ck2.Checked || ck3.Checked || ck4.Checked || ck5.Checked || ck6.Checked || ck7.Checked || ck8.Checked || ck9.Checked || ck10.Checked || ck11.Checked || ck12.Checked;


        
                //casilla 1 - 4 Navi, 4-8 Joshua, 9-12 Victor 
             if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked  && ck1.Checked )
            {
                MessageBox.Show("Tienes código verde, " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 40 - 50 min");
            }



            

                  
             /*
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

                case 91:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 92:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                case 93:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                case 94:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                case 95:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 96:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                case 97:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                case 98:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 99:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                case 100:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 101:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 102:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 103:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 104:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck7.Checked = true;
                    break;

                case 105:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck7.Checked = true;
                    break;

                //casilla 8

                case 106:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 107:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                case 108:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                case 109:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                case 110:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 111:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                case 112:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                case 113:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 114:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                case 115:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 116:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 117:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 118:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 119:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck8.Checked = true;
                    break;

                case 120:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck8.Checked = true;
                    break;

                //casilla 9

                case 121:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 122:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                case 123:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                case 124:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                case 125:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 126:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                case 127:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                case 128:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 129:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                case 130:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 131:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 132:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 133:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 134:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck9.Checked = true;
                    break;

                case 135:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck9.Checked = true;
                    break;

                //casilla 10

                case 136:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 137:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                case 138:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                case 139:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                case 140:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 141:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                case 142:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                case 143:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 144:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                case 145:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 146:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 147:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 148:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 149:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck10.Checked = true;
                    break;

                case 150:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck10.Checked = true;
                    break;

                //casilla 11

                case 151:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 152:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                case 153:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                case 154:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                case 155:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 156:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                case 157:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                case 158:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 159:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                case 160:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 161:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 162:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 163:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 164:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck11.Checked = true;
                    break;

                case 165:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck11.Checked = true;
                    break;

                //casilla 12

                case 166:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 167:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

                case 168:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

                case 169:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

                case 170:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 171:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

                case 172:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

                case 173:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 174:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

                case 175:
                    chdiab.Checked = true;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 176:
                    chdiab.Checked = true;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 177:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 178:
                    chdiab.Checked = false;
                    chhiper.Checked = true;
                    chasm.Checked = false;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 179:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = true;
                    chale.Checked = true;
                    ck12.Checked = true;
                    break;

                case 180:
                    chdiab.Checked = false;
                    chhiper.Checked = false;
                    chasm.Checked = false;
                    chale.Checked = false;
                    ck12.Checked = true;
                    break;

            }
            
            //EJEMPLO DEL TRIAJE 
            /* if (casos= 1)

             {

                 MessageBox.Show("Tienes código verde " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 40 - 50 min");

             } 
             if (case 1 = true)

          {

              MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");

          } */

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
