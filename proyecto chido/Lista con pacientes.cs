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
    public partial class Lista_con_pacientes : Form
    {
        
        public Lista_con_pacientes()
        {
            InitializeComponent();
        }

        public void listpatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BtnAct_Click(object sender, EventArgs e)
        {
            Patientlist datos = new Patientlist();
            //Limpiamos el list
           listpatient.Items.Clear();
            //foreach (Patientlist nombre in datos)
            //{
                ListViewItem item = new ListViewItem();
                item = listpatient.Items.Add(Patientlist.Nombrepaciente);
                item = listpatient.Items.Add(Patientlist.Apellidopaciente);
                item = listpatient.Items.Add(Patientlist.Edadpaciente.ToString()) ;
                item = listpatient.Items.Add(Patientlist.NSS);
                item = listpatient.Items.Add(Patientlist.Apellidopaciente);

            /*
                item.SubItems.Add(nombre.Apellidopaciente);
                item.SubItems.Add(nombre.NSS);
                item.SubItems.Add(nombre.Edadpaciente.ToString());
                item.SubItems.Add(nombre.Sangretype);
                item.SubItems.Add(nombre.Sintomaspaciente);
                item.SubItems.Add(nombre.Enfermedadpaciente.ToString());
                item.SubItems.Add(nombre.TriajePaciente.ToString());
            */
            //}
        }

    }

}


