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
    public partial class ahorcado : Form
    {
        Random ranpalabra = new Random();
        string palabra;
        string pista;
        string[] palabra2;
        string respu;
        int intentos;
        public ahorcado()
        {
            InitializeComponent();
            palabras();
            label2.Text = pista;
            intentos = 5;
            arreglopalabra();
            pictureBox1.Image = Image.FromFile(@"imaaho\Bomba5.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            respu = textBox1.Text.ToLower();
            textBox1.Text = "";
            if (respu.Length == 1)
            {
                comprobarrespuesta();
            }
            else
            {
                mensajes.Text = "INGRESE SOLO UNA LETRA";
            }
        }
        private void palabras()
        {
            int numpalabra = ranpalabra.Next(1, 21);
            switch (numpalabra)
            {
                case 1:
                    palabra = "vaca";
                    pista = "animal terrestre";
                    break;
                case 2:
                    palabra = "ballena";
                    pista = "animal marino";
                    break;
                case 3:
                    palabra = "computadora";
                    pista = "dispositivo electronico";
                    break;
                case 4:
                    palabra = "matematicas";
                    pista = "materia escolar";
                    break;
                case 5:
                    palabra = "chilate";
                    pista = "bebida";
                    break;
                case 6:
                    palabra = "facebook";
                    pista = "red social";
                    break;
                case 7:
                    palabra = "telefono";
                    pista = "dispositivo electronico";
                    break;
                case 8:
                    palabra = "lapiz";
                    pista = "material escolar";
                    break;
                case 9:
                    palabra = "silla";
                    pista = "mueble";
                    break;
                case 10:
                    palabra = "mesa";
                    pista = "mueble";
                    break;
                case 11:
                    palabra = "escuela";
                    pista = "edificio";
                    break;
                case 12:
                    palabra = "hospital";
                    pista = "edificio";
                    break;
                case 13:
                    palabra = "tacos";
                    pista = "comida";
                    break;
                case 14:
                    palabra = "chilaquiles";
                    pista = "comida";
                    break;
                case 15:
                    palabra = "pozole";
                    pista = "comida";
                    break;
                case 16:
                    palabra = "delfin";
                    pista = "animal marino";
                    break;
                case 17:
                    palabra = "elefante";
                    pista = "animal terrestre";
                    break;
                case 18:
                    palabra = "peru";
                    pista = "pais";
                    break;
                case 19:
                    palabra = "rusia";
                    pista = "pais";
                    break;
                case 20:
                    palabra = "japon";
                    pista = "pais";
                    break;
            }
        }
        private void arreglopalabra()
        {
            palabra2 = new string[palabra.Length];
            for (int i = 0; i < palabra2.Length; i++)
            {
                palabra2[i] = " - ";
                label3.Text += "" + palabra2[i];
            }
        }

        private void comprobarrespuesta()
        {
            string letra = "";
            int con = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                letra = "" + palabra[i];
                if (letra == respu)
                {
                    palabra2[i] = "" + palabra[i];
                    con++;
                }
            }
            if (con == 0)
            {
                //sonido de error
                SoundPlayer sound = new SoundPlayer(@"so\fail02.wav");
                sound.Play();
                intentos--;
                mensajes.Text = "LETRA EQUIVOCADA";
                calcular_intentos();
            }
            else
            {
                //sonido de acierto
                label3.Text = "";
                for (int i = 0; i < palabra2.Length; i++)
                {
                    label3.Text += "" + palabra2[i];
                }
                SoundPlayer co = new SoundPlayer(@"so\correct.wav");
                co.Play();
                mensajes.Text = "LETRA CORRECTA";
                ganar();
            }
        }
        private void calcular_intentos()
        {
            switch (intentos)
            {
                case 5:
                    pictureBox1.Image = Image.FromFile(@"imaaho\Bomba5.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"imaaho\Bomba4.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"imaaho\Bomba3.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"imaaho\Bomba2.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"imaaho\Bomba1.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case 0:
                    pictureBox1.Image = Image.FromFile(@"imaaho\Bomba.gif");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    juganu.Visible = true;
                    juganu.Enabled = true;
                    stop();
                    over();
                    mensajes.Text = "HAZ PERDIDO";
                    timer1.Start();
                    break;

            }
        }

        private void gameover(object sender, EventArgs e)
        {
            time_over.Start();
            pictureBox1.Image = Image.FromFile(@"imaaho\Bombagameover.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            timer1.Stop();
        }
        private void ganar()
        {
            string letra = "";
            int con = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                letra = "" + palabra2[i];
                if (letra == " - ")
                {
                    con++;
                }
            }
            if (con == 0)
            {

                mensajes.Text = "HAZ GANADO";
                stop();
                winn();
                timer_win.Start();
                textBox1.Enabled = false;
                button1.Enabled = false;
                juganu.Visible = true;
                juganu.Enabled = true;
            }
        }

        private void regre_Click(object sender, EventArgs e)
        {
            stop();
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void juganu_Click(object sender, EventArgs e)
        {
            stop();
            fondo();
            time_fondo.Start();
            pictureBox1.Image = Image.FromFile(@"imaaho\Bomba5.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            textBox1.Enabled = true;
            button1.Enabled = true;
            juganu.Visible = false;
            juganu.Enabled = false;
            label3.Text = "";
            palabras();
            arreglopalabra();
            label2.Text = pista;
        }

        private void mensajes_Click(object sender, EventArgs e)
        {

        }
        private void ahorcado_Load(object sender, EventArgs e)
        {
            fondo();
        }
        public void stop()
        {
            fondis.Ctlcontrols.stop();
            Oveer.Ctlcontrols.stop();
            time_fondo.Stop();
            time_over.Stop();
            win.Ctlcontrols.stop();
            timer_win.Stop();
        }
        public void fondo()
        {
            fondis.settings.volume = 15;
            fondis.URL = @"so\ahorcado.wav";
            fondis.Ctlcontrols.play();
        }
        public void over()
        {
            Oveer.settings.volume = 15;
            Oveer.URL = @"so\over.wav";
            Oveer.Ctlcontrols.play();
        }

        private void time_fondo_Tick(object sender, EventArgs e)
        {
            fondis.settings.volume = 15;
            fondis.URL = @"so\ahorcado.wav";
            fondis.Ctlcontrols.play();
        }

        private void time_over_Tick(object sender, EventArgs e)
        {
            Oveer.settings.volume = 15;
            Oveer.URL = @"so\over.wav";
            Oveer.Ctlcontrols.play();
        }

        private void timer_win_Tick(object sender, EventArgs e)
        {
            win.settings.volume = 15;
            win.URL = @"so\win.wav";
            win.Ctlcontrols.play();
        }
        public void winn()
        {
            win.settings.volume = 15;
            win.URL = @"so\win.wav";
            win.Ctlcontrols.play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            fondis.settings.volume = trackBar1.Value;
            win.settings.volume = trackBar1.Value;
            Oveer.settings.volume = trackBar1.Value;
        }
    }
}
