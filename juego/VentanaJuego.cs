using System;
using System.Drawing;
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
        public string mensaje;

        public Font mifuente = new Font("Dogica", 13.0f, FontStyle.Regular);
        private string respaldopersonaje;
        
        Problemas_Y_Control problemMatematicas = new Problemas_Y_Control();
        private PictureBox[] corazones;
        public VentanaJuego(byte corazonesinicio,byte contadorenemis,byte contadorvisibles,string direccionFondo)
        {
            InitializeComponent();
            //Inicio del juego
            panel2Problemas.BackColor = Color.FromArgb(150,166,166,166);
            imagenes.contadorvisibles = contadorvisibles;
            imagenes.CorazonesPlayer = corazonesinicio;
            imagenes.Contadorenemigo = contadorenemis;
            imagenes.direccionEse = direccionFondo;
            if (imagenes.contadorvisibles<=3) { imagenes.seccion3arriba = true; }
            corazones = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            Musica.settings.volume = 15;
            Musica.URL = @"so\loss.wav";
            this.BackgroundImage = Image.FromFile(direccionFondo);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            problemMatematicas.AdministradorElementos(imagenes.Contadorenemigo, panel2, textoRespuesta, TextboxRespuestaDenominador);

            if (problemMatematicas.Fracciones==true)
            {
                SeleccionNumDem.Enabled = true;
                problemMatematicas.GeneradorProblefracciones(NumPan1,DenPan1,NumPan2,DenPan1,NumPan3,DenPan3,panel3Fraccion1, panel4Fraccion5, panel5Fraccion3,MuestraProblemas,labelPrimeroperador,labelSegundooperador);
                textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
                TextboxRespuestaDenominador.Text = problemMatematicas.RespuestaDenominador.ToString();
            }
            else {
                
                labelPrimeroperador.Visible = false;
                labelSegundooperador.Visible = false;
                problemMatematicas.GeneradorProblemas(MuestraProblemas);
                textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
            }
                        
            imagenes.MuestraCorazones(corazones);
            imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6,PanelCorazones,imagenes.seccion3arriba);
            //HP();

            player.Image = Image.FromFile(imagenes.Archivosimagenes[0]);
            player.SizeMode = PictureBoxSizeMode.Zoom;

            respaldopersonaje = imagenes.AdministradorEnemigos();
            enemi.Image = Image.FromFile(respaldopersonaje);
            enemi.SizeMode = PictureBoxSizeMode.Zoom;

            
            time_music.Start();
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
                player.Image = Image.FromFile(imagenes.Archivosimagenes[0]);
                player.SizeMode = PictureBoxSizeMode.Zoom;

            }

            timer1.Stop();

            //Llamamiento de los jefes
            if (imagenes.Contadorenemigo% 3 == 0 && imagenes.Contadorenemigo!= 0)
            {
                Musica.Ctlcontrols.stop();
                time_music.Stop();
                OverM.Ctlcontrols.stop();
                MF2.Stop();
                Ventana_JefesES clasjefes = new Ventana_JefesES(imagenes.Contadorenemigo,imagenes.CorazonesPlayer,imagenes.contadorvisibles,imagenes.direccionEse);
                this.Hide();
                clasjefes.Show();
            }
            //Verifica que los corazones del jugador no sean 0
            if (imagenes.CorazonesPlayer == 0) {
                time_music.Stop();
                Musica.Ctlcontrols.stop();
                mensaje = "Game Over, has perdido";
                trackBar1.Visible = false;
                OverM.settings.volume = 15;
                OverM.URL = @"so\over.wav";
                MF2.Start();
                panelBotones.Visible = false;
                panel1.Visible = false;
                this.BackColor = Color.Black;
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult respuesta;
                
                respuesta = MessageBox.Show("¿Quieres volver a jugar?", mensaje, botones);
                if (respuesta == DialogResult.Yes)
                {
                    trackBar1.Show();
                    OverM.Ctlcontrols.stop();
                    Musica.settings.volume = 15;
                    Musica.URL = @"so\loss.wav";
                    time_music.Start();
                    imagenes.Contadorenemigo= 0;
                    panelBotones.Visible = true;
                    panel1.Visible = true;
                    imagenes.CorazonesPlayer = 3;
                    imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones,imagenes.seccion3arriba);
                    this.BackColor = Color.White;
                }
                else
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    this.Close();
                    menu.Show();
                }
            }
        }
        private void uno_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(uno, Animacionbotones);
            textoRespuesta.Text += "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(dos, Animacionbotones);
            textoRespuesta.Text += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(tres, Animacionbotones);
            textoRespuesta.Text += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(cuatro, Animacionbotones);
            textoRespuesta.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(cinco, Animacionbotones);
            textoRespuesta.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(seis, Animacionbotones);
            textoRespuesta.Text += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(siete, Animacionbotones);
            textoRespuesta.Text += "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(ocho, Animacionbotones);
            textoRespuesta.Text += "8";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(cero, Animacionbotones);
            textoRespuesta.Text += "0";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(nuebe, Animacionbotones);
            textoRespuesta.Text += "9";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            problemMatematicas.Animacionboton(punto,Animacionbotones);
            textoRespuesta.Text += "9";
        }

        private void BotonenviarRespuesta_Click(object sender, EventArgs e)
        {
            if (problemMatematicas.Fracciones == true) {
                try
                {
                    double res = double.Parse(textoRespuesta.Text);
                    double denominador = double.Parse(TextboxRespuestaDenominador.Text);
                    cal_res(res,denominador);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Introduciste una cantidad no aceptada");
                    textoRespuesta.Text = "";
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Ingresa un número correcto");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("La cantidad que introduciste es muuuyyy grande\nVuelve a ingresar otra cantidad");
                    textoRespuesta.Text = "";
                }
            }
            else
            {
                try
                {
                    double res = double.Parse(textoRespuesta.Text);
                    cal_res(res);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Introduciste una cantidad no aceptada");
                    textoRespuesta.Text = "";
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Ingresa un número correcto");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("La cantidad que introduciste es muuuyyy grande\nVuelve a ingresar otra cantidad");
                    textoRespuesta.Text = "";
                }
            }
        }
        private void cal_res(double respuestarecibida)
        {
            if (respuestarecibida == problemMatematicas.RespuestaCorrecta)
            {
                enemi.Image = Image.FromFile(imagenes.Archivosimagenes[imagenes.Enemigo + 1]);
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = true;
                imagenes.Contadorenemigo++;
                SoundPlayer sd = new SoundPlayer(@"so\exp1.wav");
                sd.Play();
                timer1.Start();
            }
            else
            {
                imagenes.CorazonesPlayer--;
                imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones,imagenes.seccion3arriba);
                //HP();
                player.Image = Image.FromFile(@"ima\image2.png");
                player.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = false;
                SoundPlayer sd1 = new SoundPlayer(@"so\hit2.wav");
                sd1.Play();
                timer1.Start();
            }
            textoRespuesta.Text = "";
            if (problemMatematicas.Fracciones == true)
            {
                problemMatematicas.GeneradorProblefracciones(NumPan1, DenPan1, NumPan2, DenPan1, NumPan3, DenPan3, panel3Fraccion1, panel5Fraccion3, panel4Fraccion5, MuestraProblemas, labelPrimeroperador, labelSegundooperador);
            }
            else {
                labelPrimeroperador.Visible = false;
                labelSegundooperador.Visible = false; 
                problemMatematicas.GeneradorProblemas(MuestraProblemas);
            }
            


            textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
        }

        private void cal_res(double respuestarecibida,double resupetadenominador)
        {
            if (respuestarecibida == problemMatematicas.RespuestaCorrecta)
            {
                enemi.Image = Image.FromFile(imagenes.Archivosimagenes[imagenes.Enemigo + 1]);
                enemi.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = true;
                imagenes.Contadorenemigo++;
                SoundPlayer sd = new SoundPlayer(@"so\exp1.wav");
                sd.Play();
                timer1.Start();
            }
            else
            {
                imagenes.CorazonesPlayer--;
                imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones, imagenes.seccion3arriba);
                //HP();
                player.Image = Image.FromFile(@"ima\image2.png");
                player.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = false;
                SoundPlayer sd1 = new SoundPlayer(@"so\hit2.wav");
                sd1.Play();
                timer1.Start();
            }
            textoRespuesta.Text = "";
            if (problemMatematicas.Fracciones == true)
            {
                problemMatematicas.GeneradorProblefracciones(NumPan1, DenPan1, NumPan2, DenPan1, NumPan3, DenPan3, panel3Fraccion1, panel5Fraccion3, panel4Fraccion5, MuestraProblemas, labelPrimeroperador, labelSegundooperador);
            }
            else
            {
                labelPrimeroperador.Visible = false;
                labelSegundooperador.Visible = false;
                problemMatematicas.GeneradorProblemas(MuestraProblemas);
            }



            textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
            TextboxRespuestaDenominador.Text = problemMatematicas.RespuestaDenominador.ToString();
        }

        private void BotonCura_Click(object sender, EventArgs e)
        {
            MF2.Stop();
            OverM.Ctlcontrols.stop();
            SoundPlayer hp = new SoundPlayer(@"so\up0.wav");
            hp.Play();
            imagenes.CorazonesPlayer = 3;
            imagenes.GeneradorCorazones(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, PanelCorazones,imagenes.seccion3arriba);
            
        }

        private void CambioEnemigo()
        {
            timer2.Start();
            this.BackgroundImage = null;
            this.BackColor = Color.Black;
            panel1.Visible = false;

            enemi.Image = Image.FromFile(imagenes.AdministradorEnemigos());

        }


        //Bucle de musica
        private void timer3_Tick(object sender, EventArgs e)
        {
            Musica.settings.volume = 15;
            Musica.URL = @"so\loss.wav";
            Musica.Ctlcontrols.play();
        }
       

        private void TransicionEnemigo_tick(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.BackgroundImage = Image.FromFile(imagenes.direccionEse);
            //this.BackgroundImage = Image.FromFile(@"")
            
            panel1.Visible = true;
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
            OverM.settings.volume = 15;
            OverM.URL = @"so\over.wav";
            OverM.Ctlcontrols.play();
        }

        private void FinAnimacion_tick(object sender, EventArgs e)
        {
            problemMatematicas.botoncambioImagen.BackgroundImage = Image.FromFile(@"ima\image31.png");
            Animacionbotones.Stop();
        }

        private void VentanaJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
