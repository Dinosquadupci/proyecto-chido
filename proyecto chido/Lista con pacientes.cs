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

        private void listpatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            //Limpiamos el list
            Inventario.Items.Clear();
            foreach (Inventario nombre in ListaInventario)
            {
                ListViewItem item = new ListViewItem();
                item = Inventario.Items.Add(nombre.NombreEquipo);
                item.SubItems.Add(nombre.EquipoMed);
                item.SubItems.Add(nombre.MarcaEquipo);
                item.SubItems.Add(nombre.Numeroserie.ToString());
                item.SubItems.Add(nombre.EstadoEquipo);
            }
        }
    }
}
