using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace juego
{
    public partial class VentanaJuego : Form
    {


        private bool CambioImagen;//Determina que personaje cambiara de imagen para poder 
        //volver a la normalidads

        //private bool cambiosEcenario;
        private Personajes imagenes = new Personajes();
        private string mensaje;
        private int numerador = new Random().Next(0, 101), denominador = new Random().Next(0, 101);
        private string respaldopersonaje;
        private byte contadorenemigos = 0;
        Problemas_Y_Control problemMatematicas = new Problemas_Y_Control();
        public VentanaJuego()
        {

            InitializeComponent();
            Musica.settings.volume = 15;
            Musica.URL = @"so\loss.wav";
            problemMatematicas.AdministradorElementos(contadorenemigos, panel1, textoRespuesta, TextboxRespuestaDenominador);
            problemMatematicas.GeneradorProblemas(MuestraProblemas, panel2Problemas);

            imagenes.CorazonesPlayer = 3;
            HP();

            player.Image = Image.FromFile(imagenes.archivosimagenes[0]);
            player.SizeMode = PictureBoxSizeMode.Zoom;

            respaldopersonaje = imagenes.AdministradorEnemigos();
            enemi.Image = Image.FromFile(respaldopersonaje);
            enemi.SizeMode = PictureBoxSizeMode.Zoom;

            textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
            time_music.Start();
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
                    pictureBox1.Image = Image.FromFile(@"ima\imagegif2.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;
                case 2:
                    PanelCorazones.Visible = false;
                    pictureBox1.Image = Image.FromFile(@"ima\imagegif2.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\imagegif2.gif");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima\image6.png");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;
                case 3:
                    PanelCorazones.Visible = false;
                    pictureBox1.Image = Image.FromFile(@"ima\imagegif2.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.Image = Image.FromFile(@"ima\imagegif2.gif");
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox3.Image = Image.FromFile(@"ima/imagegif2.gif");
                    pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                    PanelCorazones.Visible = true;
                    break;

            }
        }

        //Timer del daño 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CambioImagen == true)
            {
                //Daño enemigo
                /*si la variable "Cambio Imagen" es verdadera, entonces cambiara la imagen 
                 * del enemigo                 
                 */
                CambioEnemigo();

            }
            else
            {
                /*
                 * Daño personaje
                 Si la variable es falsa, entonces cambiara la imagen del jugador
                 */
                player.Image = Image.FromFile(imagenes.archivosimagenes[0]);
                player.SizeMode = PictureBoxSizeMode.Zoom;

            }

            timer1.Stop();
<<<<<<< HEAD
            //Llamamiento de los jefes
            if (contadorenemigos % 3 == 0 && contadorenemigos != 0 || contadorenemigos == 10) {
=======

            if (contadorenemigos % 3 == 0 && contadorenemigos != 0 || contadorenemigos == 10)
            {
                Musica.Ctlcontrols.stop();
                time_music.Stop();
                OverM.Ctlcontrols.stop();
                MF2.Stop();
>>>>>>> cb857bf4a9e1eae6b99aaf37e4b760404649cf81
                Ventana_Jefes clasjefes = new Ventana_Jefes(contadorenemigos);
                this.Hide();
                clasjefes.Show();
            }
            //Verifica que los corazones del jugador no sean 0
            if (imagenes.CorazonesPlayer == 0) {
                time_music.Stop();
                Musica.Ctlcontrols.stop();
                //Game over, juego acabado
                mensaje = "Game Over, has perdido";
                trackBar1.Visible = false;
                OverM.settings.volume = 20;
                OverM.URL = @"so\over.wav";
                MF2.Start();
                panelBotones.Visible = false;
                tableLayoutPanel1.Visible = false;
                this.BackColor = Color.Black;

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Quieres volver a jugar?", mensaje, botones);
                if (respuesta == DialogResult.Yes)
                {
                    trackBar1.Show();
                    OverM.Ctlcontrols.stop();
                    Musica.URL = @"so\loss.wav";
                    time_music.Start();
                    contadorenemigos = 0;
                    panelBotones.Visible = true;
                    tableLayoutPanel1.Visible = true;
                    imagenes.CorazonesPlayer = 3;
                    HP();
                    this.BackColor = Color.White;
                }
                else
                {
                    this.Close();
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                }
            }
        }

        //Funciones de los botones
        private void uno_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno,Animacionbotones);
            textoRespuesta.Text += "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno, Animacionbotones);
            textoRespuesta.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno, Animacionbotones);
            textoRespuesta.Text += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno, Animacionbotones);
            textoRespuesta.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno, Animacionbotones);
            textoRespuesta.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno,Animacionbotones);
            textoRespuesta.Text += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno,Animacionbotones);
            textoRespuesta.Text += "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno,Animacionbotones);
            textoRespuesta.Text += "8";
            
        }

        private void cero_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno,Animacionbotones);
            textoRespuesta.Text += "0";
        }

        private void nueve_Click(object sender, EventArgs e)
        {

            problemMatematicas.Animacionboton(uno, Animacionbotones);
            textoRespuesta.Text += "9";
            
            
        }

        private void BotonenviarRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                int res = int.Parse(textoRespuesta.Text);
                cal_res(res);
            }
            catch (FormatException)
            {
                MessageBox.Show("La cantidad que introduciste es muuuyyy grande\nVuelve a ingresar otra cantidad");
                textoRespuesta.Text = "";
            }
            catch (NullReferenceException) {
                MessageBox.Show("Ingresa un número correcto");
            }
        }
        private void cal_res(int respuestarecibida)
        {
            if (respuestarecibida == problemMatematicas.RespuestaCorrecta)
            {
                enemi.Image = Image.FromFile(imagenes.archivosimagenes[imagenes.Enemigo + 1]);
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = true;
                contadorenemigos++;
                SoundPlayer sd = new SoundPlayer(@"so\exp1.wav");
                sd.Play();
                timer1.Start();
            }
            else
            {
                imagenes.CorazonesPlayer--;
                HP();
                player.Image = Image.FromFile(@"ima\image2.png");
                player.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = false;
                SoundPlayer sd1 = new SoundPlayer(@"so\hit2.wav");
                sd1.Play();
                timer1.Start();
            }
            textoRespuesta.Text = "";
            problemMatematicas.GeneradorProblemas(MuestraProblemas, panel2Problemas);


            textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
        }

        private void BotonCura_Click(object sender, EventArgs e)
        {
            SoundPlayer hp = new SoundPlayer(@"so\up0.wav");
            hp.Play();
            imagenes.CorazonesPlayer = 3;
            HP();
        }

        private void CambioEnemigo()
        {
            timer2.Start();
            this.BackColor = Color.Black;
            panelBotones.Visible = false;
            tableLayoutPanel1.Visible = false;
            enemi.Image = Image.FromFile(imagenes.AdministradorEnemigos());

        }

<<<<<<< HEAD
       
=======
        private void Iluminacion_MouseHover1(object sender, EventArgs e)
        {
            uno.BackColor = Color.WhiteSmoke;
        }
        private void Musica_Enter(object sender, EventArgs e)
        {

        }

>>>>>>> cb857bf4a9e1eae6b99aaf37e4b760404649cf81
        private void timer3_Tick(object sender, EventArgs e)
        {
            //Bucle de musica
            Musica.URL = @"so\loss.wav";
            Musica.Ctlcontrols.play();
            Musica.settings.volume = 20;
        }
<<<<<<< HEAD
       
=======
        private void Ilumicacion_MouseLeave1(object sender, EventArgs e)
        {
            uno.BackColor = Color.Transparent;
        }
>>>>>>> cb857bf4a9e1eae6b99aaf37e4b760404649cf81

        private void TransicionEnemigo_tick(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            //this.BackgroundImage = Image.FromFile(@"")
            panelBotones.Visible = true;
            tableLayoutPanel1.Visible = true;
            timer2.Stop();

        }

        //Asigna el volumen a la trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Musica.settings.volume = trackBar1.Value;
        }


        //Bucle de musica Game Over
        public void MF2_Tick(object sender, EventArgs e)
        {
            OverM.settings.volume = 20;
            OverM.URL = @"so\over.wav";
            OverM.Ctlcontrols.play();
        }

<<<<<<< HEAD
        private void FinAnimacion_tick(object sender, EventArgs e)
        {
            problemMatematicas.botoncambioImagen.BackgroundImage = Image.FromFile(@"ima\image31.png");
            Animacionbotones.Stop();
        }

        public void ini()
        {
            //Baja el volumen inicial
            Musica.settings.volume = 20;
        }
       

=======
>>>>>>> cb857bf4a9e1eae6b99aaf37e4b760404649cf81
    }
}
