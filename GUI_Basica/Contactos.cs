using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topicos
{
    public partial class Contactos : Form
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text==""|| txtCorreo.Text=="" || txtNumero.Text=="")
                MessageBox.Show("Debes de completar todos los campos", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            
            String contacto = $"Nombre: {txtNombre.Text} - Telefono: {txtNumero.Text} - Correo: {txtCorreo.Text}";
            listContactos.Items.Add(contacto);

            txtNombre.Clear();
            txtNumero.Clear();
            txtCorreo.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(listContactos.SelectedIndex>=0)
            {
                listContactos.Items.RemoveAt(listContactos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debes seleccionar un contacto para eliminar", "Error", 
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El programa realiza una gestion de contactos\n" +
                "Elaborado por: Jason Abisai Lozano Loaiza\n"+ "Topicos Avanzados de programacion"
                ,"Acerca de",
                MessageBoxButtons.OK);
        }

        private void jToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listContactos.Items.Clear();
        }

        private void Contactos_Load(object sender, EventArgs e)
        {

        }
    }
}
