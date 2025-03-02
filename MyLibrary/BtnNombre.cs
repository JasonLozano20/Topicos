using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class BtnNombre: UserControl
    {
        public BtnNombre()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jason Lozano Loaiza", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
