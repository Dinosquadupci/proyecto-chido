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
          //Patientlist nombre = new Patientlist();
            


            ListViewItem item = new ListViewItem(Patientlist.Nombrepaciente);
            item.SubItems.Add(Patientlist.Apellidopaciente);
            item.SubItems.Add(Patientlist.Edadpaciente.ToString()) ;
            item.SubItems.Add(Patientlist.NSS);
            item.SubItems.Add(Patientlist.Sangretype);
            item.SubItems.Add(Patientlist.Sintomaspaciente);
            item.SubItems.Add(Patientlist.Enfermedadpaciente.ToString());
            item.SubItems.Add(Patientlist.TriajePaciente.ToString());
            listpatient.Items.Add(item);
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listpatient.Items.Clear();
        }
    }

}


