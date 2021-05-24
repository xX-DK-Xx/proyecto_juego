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
        public int hpp = 3;
        public int sha;
        public VentanaJuego()
        {
            InitializeComponent();
            HP();
            pla.Image = Image.FromFile(@"ima\juga.png");
            pla.SizeMode = PictureBoxSizeMode.Zoom;
            ene.Image = Image.FromFile(@"ima\bruja.png");
            ene.SizeMode = PictureBoxSizeMode.Zoom;
            int r = new Random().Next(0, 11);
            texto.Text = "" + r;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Respuesta_Click(object sender, EventArgs e)
        {
            int res = int.Parse(tex.Text);
            cal_res(res);
        }
        private void cal_res(int respuestarecibida)
        {
            if (respuestarecibida == int.Parse(texto.Text))
            {
                ene.Image = Image.FromFile(@"ima\bruja_ani.gif");
                ene.SizeMode = PictureBoxSizeMode.Zoom;
                sha = 1;
                timer1.Start();
            }
            else
            {
                hpp = hpp - 1;
                HP();
                pla.Image = Image.FromFile(@"ima\juga_daño.png");
                pla.SizeMode = PictureBoxSizeMode.Zoom;
                sha = 0;
                timer1.Start();
            }
            int r = new Random().Next(0, 11);
            texto.Text = "" + r;
        }
        private void HP()
        {
            switch (hpp)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"ima\co2.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\co2.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\co2.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"ima\co.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\co2.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\co2.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"ima\co.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\co.gif");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\co2.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"ima\co.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\co.gif");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\co.gif");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sha == 1)
            {
                ene.Image = Image.FromFile(@"ima\bruja.png");
                ene.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pla.Image = Image.FromFile(@"ima\juga.png");
                pla.SizeMode = PictureBoxSizeMode.Zoom;
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

        
    }
}
