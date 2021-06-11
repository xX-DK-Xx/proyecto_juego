using System;
using System.IO;
using System.Drawing;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego
{
    public partial class Ventana_JefesES : Form
    {
        
        private bool CambioImagen;//Determina que personaje cambiara de imagen para poder 
        //volver a la normalidads

        //private bool cambiosEcenario;
        private Personajes imagenes = new Personajes();
        private PictureBox[] corazones;
        private Problemas_Y_Control mateproblem = new Problemas_Y_Control();
        

        public Ventana_JefesES(byte eleccionJefe,byte contacorazones,byte contadorvisibles,string direccionfondo)
        {
            imagenes.CorazonesPlayer = contacorazones;
            imagenes.Contadorenemigo = eleccionJefe;
            imagenes.contadorvisibles = contadorvisibles;
            imagenes.direccionEse = direccionfondo;
            if (imagenes.contadorvisibles<=3) { imagenes.seccion3arriba = true; }
            InitializeComponent();
            corazones = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            this.BackgroundImage = Image.FromFile(imagenes.direccionEse);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones,imagenes.seccion3arriba);
            imagenes.MuestraCorazones(corazones);
            
            mateproblem.AdministradorElementos(imagenes.Contadorenemigo,panel2,textoRespuesta,TextboxRespuestaDenominador);
            mateproblem.GeneradorProblemas(MuestraProblemas);

            player.Image = Image.FromFile(imagenes.Archivosimagenes[0]);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            imagenes.AdministradorJefes(eleccionJefe, enemi);

            enemi.SizeMode = PictureBoxSizeMode.Zoom;

            textoRespuesta.Text = mateproblem.RespuestaCorrecta.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CambioImagen == true)
            {
                /*si la variable "Cambio Imagen" es verdadera, entonces cambiara la imagen 
                 * del enemigo                 
                 */
                if (imagenes.Contadorenemigo!=10) {
                    DerrotaJefe();
                    enemi.Image = Image.FromFile(imagenes.ImagenesJefes[imagenes.posicionJefe]);

                }
                else
                {

                }

            }
            else
            {
                /*
                 Si la variable es falsa, entonces cambiara la imagen del jugador
                 */
                player.Image = Image.FromFile(imagenes.Archivosimagenes[0]);
                player.SizeMode = PictureBoxSizeMode.Zoom;
            }

            timer1.Stop();

        }
        private void uno_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(uno, AnimacionBotones);
            textoRespuesta.Text += "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(dos, AnimacionBotones);
            textoRespuesta.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(tres, AnimacionBotones);
            textoRespuesta.Text += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(cuatro, AnimacionBotones);
            textoRespuesta.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(cinco, AnimacionBotones);
            textoRespuesta.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(seis, AnimacionBotones);
            textoRespuesta.Text += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(siete, AnimacionBotones);
            textoRespuesta.Text += "7";
        }

        private void Ocho_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(ocho, AnimacionBotones);
            textoRespuesta.Text += "8";
        }
        private void Cero_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(cero, AnimacionBotones);
            textoRespuesta.Text += "0";
        }

        private void Nueve_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(nuebe, AnimacionBotones);
            textoRespuesta.Text += "9";
        }
        private void punto_Click(object sender, EventArgs e)
        {
            mateproblem.Animacionboton(punto, AnimacionBotones);
            textoRespuesta.Text += ".";
        }

        private void BotonenviarRespuesta_Click(object sender, EventArgs e)
        {
            try {
                double res = double.Parse(textoRespuesta.Text);
                Cal_res(res);
            }
            catch (FormatException) {
                MessageBox.Show("Ingresaste una cantidad que no es correcta");
            }
            catch (OverflowException) {
                MessageBox.Show("La cantidad que introduciste es muuuyyy grande\nVuelve a ingresar otra cantidad");
                textoRespuesta.Text = "";
            }

        }
        private void Cal_res(double respuestarecibida)
        {
            if (respuestarecibida == mateproblem.RespuestaCorrecta)
            {
                DerrotaJefe();
                
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
                imagenes.DañoEnemigo++;
                timer1.Start();
                CambioImagen = true;
            }
            else
            {
                imagenes.CorazonesPlayer-=2;
                imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones,imagenes.seccion3arriba);

                player.Image = Image.FromFile(@"ima\image2.png");
                player.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = false;
                timer1.Start();
            }
            textoRespuesta.Text = "";
            mateproblem.GeneradorProblemas(MuestraProblemas);
            textoRespuesta.Text = mateproblem.RespuestaCorrecta.ToString();
        }

        private void BotonCura_Click(object sender, EventArgs e)
        {
            imagenes.CorazonesPlayer = 3;
            imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones,imagenes.seccion3arriba);

        }

        private void FinAnimacion_Tick(object sender, EventArgs e)
        {
            mateproblem.botoncambioImagen.BackgroundImage = Image.FromFile(@"ima/image31.png");
            AnimacionBotones.Stop();
        }
        private void DerrotaJefe(){
            if (imagenes.DañoEnemigo == 2)
            {
                Transicionventana.Start();
                enemi.Image = Image.FromFile(imagenes.ImagenesJefes[imagenes.posicionJefe + 2]);
                imagenes.contadorvisibles++;
                imagenes.CorazonesPlayer = imagenes.contadorvisibles;
                imagenes.Contadorenemigo++;
                if (imagenes.Contadorenemigo == 10)
                {
                    panel1.Visible = false;
                    BackgroundImage = null;
                    BackColor = Color.Black;
                    Transicionventana.Start();
                    
                }
                else {
                    Cambioventana();
                }
                
            }
            else {
                enemi.Image = Image.FromFile(imagenes.ImagenesJefes[imagenes.posicionJefe + 1]);
            }
        }
        private void Cambioventana()
        {
            panel1.Visible = false;
            imagenes.direccionEse = @"Escenarios\image21.png";
            this.BackgroundImage = null;
            this.BackColor = Color.Black;

        }

        private void CambioVen_Tick(object sender, EventArgs e)
        {
            Transicionventana.Stop();
            if (imagenes.Contadorenemigo!=10) {
                VentanaJuego enemigo = new VentanaJuego(imagenes.CorazonesPlayer, imagenes.Contadorenemigo, imagenes.contadorvisibles, imagenes.direccionEse);
                enemigo.Show();
                this.Hide();
            }
            else {
                BackColor = Color.White;
                panel1.Visible=true;
                BackgroundImage = Image.FromFile(@"Escenarios\image.20.png");
            }
        }
    }
}
//