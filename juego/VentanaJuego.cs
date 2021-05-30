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
    public partial class VentanaJuego : Form
    {
        public int hpp = 3,sha;

        private Personajes imagenes = new Personajes();

        private int r = new Random().Next(0, 101);
        private string respaldopersonaje;
        public VentanaJuego()
        {
            InitializeComponent();
            
            HP();
            //pla.Image = Image.FromFile(imagenes.DireccionImagenes);
            //pla.Image = Image.FromFile(@"ima\juga.png");
            player.Image = Image.FromFile(imagenes.archivosimagenes[0]);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            imagenes.Enemigo = 10;
            respaldopersonaje = imagenes.AdministradorEnemigos();
            enemi.Image = Image.FromFile(respaldopersonaje);
            enemi.SizeMode = PictureBoxSizeMode.Zoom;
            int r = new Random().Next(0, 101);
            textoRespuesta.Text = "" + r;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

       
        
        private void HP()
        {
            switch (hpp)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(imagenes.archivosimagenes[19]);
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sha == 1)
            {
                enemi.Image = Image.FromFile(@"ima\bruja.png");
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                player.Image = Image.FromFile(@"ima\juga.png");
                player.SizeMode = PictureBoxSizeMode.Zoom;
            }

            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hpp = 3;
            
            HP();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

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

        private void ocho_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "8";
        }


        private void cero_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "0";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            textoRespuesta.Text += "9";
        }

        private void BotonenviarRespuesta_Click(object sender, EventArgs e)
        {
            int res = int.Parse(textoRespuesta.Text);
            cal_res(res);
            if (textoRespuesta.Text==r.ToString())
            {
                enemi.Image=Image.FromFile();
             
            }
            else
            {
                hpp--;
                HP();
                player.Image = Image.FromFile(imagenes.archivosimagenes[10]);
            }

        }
        private void cal_res(int respuestarecibida)
        {
            if (respuestarecibida == int.Parse(textoRespuesta.Text))
            {
                enemi.Image = Image.FromFile(imagenes.archivosimagenes[imagenes.Enemigo + 1]);
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
                sha = 1;
                timer1.Start();
            }
            else
            {
                hpp--;
                HP();
                player.Image = Image.FromFile(imagenes.archivosimagenes[10]);
                player.SizeMode = PictureBoxSizeMode.Zoom;
                sha = 0;
                timer1.Start();
            }
            textoRespuesta.Text = "";

            textoRespuesta.Text = r.ToString();
        }
    }
}
