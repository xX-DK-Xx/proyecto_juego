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
        
        private bool CambioImagen;//Determina que personaje cambiara de imagen para poder 
        //volver a la normalidads

        //private bool cambiosEcenario;
        private Personajes imagenes = new Personajes();
        private string mensaje;
        private int numerador = new Random().Next(0, 101),denominador=new Random().Next(0,101);
        private string respaldopersonaje;
        private byte contadorenemigos = 0;
        Problemas_Y_Control problemMatematicas = new Problemas_Y_Control();
        public VentanaJuego()
        {
            InitializeComponent();
            problemMatematicas.AdministradorElementos(contadorenemigos,panel1,textoRespuesta,TextboxRespuestaDenominador);
            problemMatematicas.GeneradorProblemas(MuestraProblemas,panel2Problemas);
            
            imagenes.CorazonesPlayer = 3;
            HP();
            
            player.Image = Image.FromFile(imagenes.archivosimagenes[0]);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            
            respaldopersonaje = imagenes.AdministradorEnemigos();
            enemi.Image = Image.FromFile(respaldopersonaje);
            enemi.SizeMode = PictureBoxSizeMode.Zoom;
            
            textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CambioImagen == true)
            {
                /*si la variable "Cambio Imagen" es verdadera, entonces cambiara la imagen 
                 * del enemigo                 
                 */
                CambioEnemigo();
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

            if (contadorenemigos % 3 == 0 && contadorenemigos != 0 || contadorenemigos == 10) {
                Ventana_Jefes clasjefes = new Ventana_Jefes(contadorenemigos);
                this.Hide();
                clasjefes.Show();
            } 
            //Verifica que los corazones del jugador no sean 0
            if (imagenes.CorazonesPlayer == 0) {
                mensaje = "Game Over, has perdido";
                panelBotones.Visible = false;
                tableLayoutPanel1.Visible = false;
                this.BackColor = Color.Black;
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Quieres volver a jugar?", mensaje, botones);
                if (respuesta == DialogResult.Yes)
                {
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
                }
            } 
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
            catch(NullReferenceException) {
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
                timer1.Start();
            }
            else
            {
                imagenes.CorazonesPlayer--;
                HP();
                player.Image = Image.FromFile(@"ima\image2.png");
                player.SizeMode = PictureBoxSizeMode.Zoom;
                CambioImagen = false;
                timer1.Start();
            }
            textoRespuesta.Text = "";
            problemMatematicas.GeneradorProblemas(MuestraProblemas,panel2Problemas);


            textoRespuesta.Text = problemMatematicas.RespuestaCorrecta.ToString();
        }

        private void BotonCura_Click(object sender, EventArgs e)
        {
            imagenes.CorazonesPlayer= 3;
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

        private void Iluminacion_MouseHover1(object sender, EventArgs e)
        {
            uno.BackColor = Color.WhiteSmoke;
        }

        private void TransicionEnemigo_tick(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            //this.BackgroundImage = Image.FromFile(@"")
            panelBotones.Visible = true;
            tableLayoutPanel1.Visible = true;
            timer2.Stop();
            
        }
       
    }
}
