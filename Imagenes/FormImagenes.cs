using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagenes
{
    public partial class FormImagenes : Form
    {

        private FlowLayoutPanel flowLayoutPanel;
        //Ruta donde se encuentra la carpeta con las imagenes
        private string imageFolderPath = @"C:\Documentos\4to semestre\Topicos avanzados de programacion\juegos";
        public FormImagenes()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Configuración de la ventana para mostrar las imagenes
            this.Text = "Galería de Juegos";
            this.Size = new Size(600, 400);

            // Crear un FlowLayoutPanel para organizar las imagenes horizontalmente
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = false;
            this.Controls.Add(flowLayoutPanel);

            //Se llama el metodo para cargar las imagenes relacionada a la carpeta 
            CargarImagenes();
        }
        private void CargarImagenes()
        {
            
            //Si existe la carpeta obtiene los archivos .jpg

            if (Directory.Exists(imageFolderPath))
            {
                string[] imageFiles = Directory.GetFiles(imageFolderPath, "*.jpg");

                foreach (string imageFile in imageFiles)
                {
                    //Para cada imagen se crea un PictureBoox con un tamaño de 100 pixeles
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    pictureBox.Image = Image.FromFile(imageFile);
                    //Configuramos el cursos para que cambie cuando pasa por alguna imagen 
                    pictureBox.Cursor = Cursors.Hand;
                    //Se asocia un click para mostrar la imagen completa
                    pictureBox.Click += (s, ev) => ShowFullSizeImage(imageFile);

                    flowLayoutPanel.Controls.Add(pictureBox);
                }
            }
            else
            {
                //En caso de que la carpeta no exista arroja un mensaje 
                MessageBox.Show("La carpeta 'juegos' no existe en: " + imageFolderPath);
            }
        }

        private void ShowFullSizeImage(string imagePath)
        {
            // Crear una nueva ventana para mostrar la imagen en tamaño completo
            System.Windows.Forms.Form imageViewer = new System.Windows.Forms.Form();
            imageViewer.Text = "Imagen Completa";
            imageViewer.Size = new Size(800, 600);

            PictureBox fullSizePictureBox = new PictureBox();
            fullSizePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            fullSizePictureBox.Dock = DockStyle.Fill;
            fullSizePictureBox.Image = Image.FromFile(imagePath);

            imageViewer.Controls.Add(fullSizePictureBox);
            imageViewer.ShowDialog();
        }
    }
}
    