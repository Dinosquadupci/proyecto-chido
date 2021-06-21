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



            //casilla 1 - 4 Navi, 5-8 Joshua, 9-12 Victor 
            if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck1.Checked)
            {
                MessageBox.Show("Tienes código verde, " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 40 - 50 min");
            }
            else if (chdiab.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && chdiab.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && chale.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chhiper.Checked && chale.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chale.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chale.Checked && ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (ck1.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }


            //casilla 2
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck2.Checked)
            {
                MessageBox.Show("Tienes código verde, " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 40 - 50 min");
            }
            else if (chdiab.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && chdiab.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && chale.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chhiper.Checked && chale.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chale.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chale.Checked && ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (ck2.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }


            //casilla 3
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck3.Checked)
            {
                MessageBox.Show("Tienes código verde, " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 40 - 50 min");
            }
            else if (chdiab.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && chdiab.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && chale.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chhiper.Checked && chale.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chale.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chale.Checked && ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (ck3.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }

            //casilla 4
            
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck4.Checked)
            {
                MessageBox.Show("Tienes código verde, " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 40 - 50 min");
            }
            else if (chdiab.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chale.Checked && chdiab.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chdiab.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chdiab.Checked && chale.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chhiper.Checked && chale.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chhiper.Checked && chale.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (chasm.Checked && chale.Checked && ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");
            }
            else if (ck4.Checked)
            {
                MessageBox.Show("No es una urgencia, acuda a su médico familiar");

            }
            //Case 5
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chasm.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chale.Checked && ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chasm.Checked && chale.Checked && ck5.Checked)

            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (ck5.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }

            //casilla 6

            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chasm.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chdiab.Checked && chhiper.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chale.Checked && ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chasm.Checked && chale.Checked && ck6.Checked)

            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (ck6.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }

            //casilla 7

            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chasm.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chdiab.Checked && chhiper.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chale.Checked && ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chasm.Checked && chale.Checked && ck7.Checked)

            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (ck7.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }

            //casilla 8

            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chasm.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }


            else if (chdiab.Checked && chhiper.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chhiper.Checked && chale.Checked && ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (chasm.Checked && chale.Checked && ck8.Checked)

            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }



            else if (ck8.Checked)
            {
                MessageBox.Show("Tienes código amarillo " + nombre1 + ", tú edad es: " + edad + " y tú tiempo de espera es de: 20 min");
            }

            //casilla 9
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && chale.Checked && ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (ck9.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }



            //casilla 10
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && chale.Checked && ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (ck10.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }


            //casilla 11

            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && chale.Checked && ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (ck11.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }

            //casilla 12

            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chasm.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chhiper.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chdiab.Checked && chasm.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chasm.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chhiper.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (chasm.Checked && chale.Checked && ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
            }
            else if (ck12.Checked)
            {
                MessageBox.Show(" Tienes código rojo " + nombre1 + ", Edad: " + edad + " y tú tiempo de espera es de: 5 min ");
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
