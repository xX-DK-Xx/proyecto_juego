using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    public partial class Ventana_Jefes : Form
    {
        //hola
        //hola
        //Este es mi hola
        //Axel
        private bool CambioImagen;//Determina que personaje cambiara de imagen para poder 
        //volver a la normalidads

        //private bool cambiosEcenario;
        private Personajes imagenes = new Personajes();
       
        
        private int r = new Random().Next(0, 101);

        public Ventana_Jefes (byte eleccionJefe)
        {

            InitializeComponent();
            imagenes.CorazonesPlayer = 3;
            HP();

            player.Image = Image.FromFile(imagenes.archivosimagenes[0]);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            switch (eleccionJefe)
            {
                case 3:
                    enemi.Image = Image.FromFile(imagenes.archivosimagenes[4]);
                    break;
                case 6:
                    enemi.Image = Image.FromFile(imagenes.archivosimagenes[11]);
                    break;
                case 9:
                    enemi.Image = Image.FromFile(imagenes.archivosimagenes[15]);
                    break;
                    case 10:
                    MessageBox.Show("Esta es una prueba xdxd");
                    break;

            }
            enemi.SizeMode = PictureBoxSizeMode.Zoom;

            textoRespuesta.Text = r.ToString();
        }

        private void HP()
        {
            switch (imagenes.CorazonesPlayer)
            {
                case 0:
                    PanelCorazones.Visible = false;
                    pictureBox1.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;
                case 1:
                    PanelCorazones.Visible = false;
                    pictureBox1.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;
                case 2:
                    PanelCorazones.Visible = false;
                    pictureBox1.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;
                case 3:
                    PanelCorazones.Visible = false;
                    pictureBox1.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CambioImagen == true)
            {
                /*si la variable "Cambio Imagen" es verdadera, entonces cambiara la imagen 
                 * del enemigo                 
                 */
            }
            else
            {
                /*
                 Si la variable es falsa, entonces cambiara la imagen del jugador
                 */
                player.Image = Image.FromFile(imagenes.archivosimagenes[0]);
                player.SizeMode = PictureBoxSizeMode.Zoom;
            }

            timer1.Stop();

        }
        private void uno_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "7";
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "8";
        }


        private void Cero_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "0";
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "9";
        }

        private void BotonenviarRespuesta_Click(object sender, EventArgs e)
        {

            int res = int.Parse(textoRespuesta.Text);
            Cal_res(res);

        }
        private void Cal_res(int respuestarecibida)
        {
            if (respuestarecibida == r)
            {
                enemi.Image = Image.FromFile(imagenes.archivosimagenes[imagenes.Enemigo + 1]);
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = true;
               
                timer1.Start();
            }
            else
            {
                imagenes.CorazonesPlayer--;
                HP();
                player.Image = Image.FromFile(imagenes.archivosimagenes[10]);
                player.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = false;
                timer1.Start();
            }
            textoRespuesta.Text = "";

            textoRespuesta.Text = new Random().Next(0, 101).ToString();
        }

        private void BotonCura_Click(object sender, EventArgs e)
        {
            imagenes.CorazonesPlayer = 3;
            HP();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ventana_Jefes_Load(object sender, EventArgs e)
        {

        }
    }
}
