using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class BtnColor : UserControl
    {
        public BtnColor()
        {
            InitializeComponent();
            
        }

        private void btnColors_MouseEnter(object sender, EventArgs e)
        {
            btnColors.BackColor = Color.Red;
        }

        private void btnColors_MouseLeave(object sender, EventArgs e)
        {
            btnColors.BackColor = SystemColors.Control;
        }

        private void btnColors_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                DialogResult resultado = MessageBox.Show("¿Estas seguro que quieres continuar?", 
                "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    MessageBox.Show("has confirmado", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
