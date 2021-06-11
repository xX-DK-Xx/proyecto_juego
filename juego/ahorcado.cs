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
            if (respu.Length==1)
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
            int numpalabra = ranpalabra.Next(1,21);
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
        private void arreglopalabra ()
        {
            palabra2 = new string[palabra.Length];
            for (int i=0;i<palabra2.Length;i++)
            {
                palabra2[i] = " - ";
                label3.Text += "" + palabra2[i];
            }
        }
        private void comprobarrespuesta()
        {
            string letra = "";
            int con = 0;
            for (int i=0;i<palabra.Length ;i++)
            {
                letra = ""+palabra[i];
                if (letra==respu)
                {
                    palabra2[i] = ""+palabra[i];
                    con++;
                }
            }
            if (con==0)
            {
                //sonido de error
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
                    mensajes.Text = "HAZ PERDIDO";
                    timer1.Start();
                    break;

            }
        }

        private void gameover(object sender, EventArgs e)
        {
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
                textBox1.Enabled = false;
                button1.Enabled = false;
                juganu.Visible = true;
                juganu.Enabled = true;
            }
        }

        private void regre_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void juganu_Click(object sender, EventArgs e)
        {
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
    }
}
