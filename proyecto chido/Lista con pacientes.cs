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
        List<Patientlist> Patientlists = new List<Patientlist>();
        public Lista_con_pacientes()
        {
            InitializeComponent();
        }

        private void listpatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            //Limpiamos el list
           listpatient.Items.Clear();
            foreach (Patientlist nombre in Patientlists)
            {
                ListViewItem item = new ListViewItem();
                item = listpatient.Items.Add(nombre.Nombrepaciente);
                item.SubItems.Add(nombre.Apellidopaciente);
                item.SubItems.Add(nombre.NSS);
                item.SubItems.Add(nombre.Edadpaciente.ToString());
                item.SubItems.Add(nombre.Sangretype);
                item.SubItems.Add(nombre.Sintomaspaciente);
                item.SubItems.Add(nombre.Enfermedadpaciente.ToString());
                item.SubItems.Add(nombre.TriajePaciente.ToString());
            }
        }

    }

}


