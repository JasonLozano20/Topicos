using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace Componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ValidatorRFC validator = new ValidatorRFC();

        private void txtLetters_TextChanged(object sender, EventArgs e)
        {
            InputValidacion validacion = new InputValidacion();
            validacion.OnlyLetters(txtLetters.Text);
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            InputValidacion validacion = new InputValidacion();
            bool letters = validacion.OnlyLetters(txtLetters.Text);
            if (letters == true)
                MessageBox.Show("La caja de texto solo contiene letras");
            else
            {
                MessageBox.Show("Ingresaste caracteres no permitidos");
            }
            txtLetters.Text = "";
        }

        private void txtNumbers_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            InputValidacion validacion = new InputValidacion();
            bool numbers = validacion.OnlyNumbers(txtNumbers.Text);
            if (numbers == true)
                MessageBox.Show("La caja de texto solo contiene numeros");
            else
            {
                MessageBox.Show("Ingresaste caracteres no permitidos");
            }
            txtNumbers.Text = "";
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            validator.RFCValido(txtRFC.Text);
        }

        private void btnRFC_Click(object sender, EventArgs e)
        {
            bool validacion = validator.RFCValido(txtRFC.Text);
            if (validacion == true)
            {
                MessageBox.Show("El RFC: " + $"{txtRFC.Text}" + " es correcto", "Informacion",
                    MessageBoxButtons.OK);
                txtRFC.Text = validator.RFCCorregido(txtRFC.Text);
            }
            else
            {
                MessageBox.Show("El RFC no cumple con el formato oficial de Mexico");
            }
        }
    }
}
