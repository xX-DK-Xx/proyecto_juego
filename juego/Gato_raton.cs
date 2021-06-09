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
    public partial class Gato_raton : Form
    {
        public int juga;
        public string quiengana;
        public int con;
        public string direccion;
        public string[] tablero = new string[9];
        bool computadora;
        bool gana = false;
        bool tur = false;
        public Gato_raton()
        {
            InitializeComponent();
            label1.Visible = false;
            juga = 0;
            label1.Text = "Turno de Gato";
            direccion = @"imagato\gato.png";
        }
        public void jugado(int casilla)
        {
            con++;
            if (juga == 1)
            {
                tablero[casilla] = "o";
                label1.Text = "Turno de Gato";
                juga = 0;
                quiengana = "RATON";
                ganar();
                direccion = @"imagato\raton.png";
            }
            else
            {
                tablero[casilla] = "x";
                label1.Text = "Turno de Raton";
                juga = 1;
                quiengana = "GATO";
                ganar();
                direccion = @"imagato\gato.png";               
            }
        }
        public void ganar()
        {
            if (tablero[0] == tablero[1] && tablero[0] == tablero[2])
            {
                if (tablero[0] == "x" || tablero[0] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[3] == tablero[4] && tablero[3] == tablero[5])
            {
                if (tablero[3] == "x" || tablero[4] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[6] == tablero[7] && tablero[6] == tablero[8])
            {
                if (tablero[6] == "x" || tablero[6] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[0] == tablero[3] && tablero[0] == tablero[6])
            {
                if (tablero[0] == "x" || tablero[0] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[1] == tablero[4] && tablero[1] == tablero[7])
            {
                if (tablero[1] == "x" || tablero[1] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[2] == tablero[5] && tablero[2] == tablero[8])
            {
                if (tablero[2] == "x" || tablero[2] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[0] == tablero[4] && tablero[0] == tablero[8])
            {
                if (tablero[0] == "x" || tablero[0] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (tablero[2] == tablero[4] && tablero[2] == tablero[6])
            {
                if (tablero[2] == "x" || tablero[2] == "o")
                {
                    label1.Text = "EL GANADOR ES " + quiengana;
                    gana = true;
                    desa();
                }
            }
            else if (con == 9)
            {
                label1.Text = "ES UN EMPATE";
                gana = true;
                desa();
            }

        }
        public void desa()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jugado(0);
            button1.BackgroundImage = Image.FromFile(direccion);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Enabled = false;
            inteligencia_compu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jugado(1);
            button2.BackgroundImage = Image.FromFile(direccion);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Enabled = false;
            inteligencia_compu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jugado(3);
            button4.BackgroundImage = Image.FromFile(direccion);
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Enabled = false;
            inteligencia_compu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jugado(4);
            button5.BackgroundImage = Image.FromFile(direccion);
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Enabled = false;
            inteligencia_compu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jugado(2);
            button3.BackgroundImage = Image.FromFile(direccion);
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Enabled = false;
            inteligencia_compu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jugado(5);
            button6.BackgroundImage = Image.FromFile(direccion);
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Enabled = false;
            inteligencia_compu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            jugado(8);
            button9.BackgroundImage = Image.FromFile(direccion);
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Enabled = false;
            inteligencia_compu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            jugado(7);
            button8.BackgroundImage = Image.FromFile(direccion);
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Enabled = false;
            inteligencia_compu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jugado(6);
            button7.BackgroundImage = Image.FromFile(direccion);
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Enabled = false;
            inteligencia_compu();
        }
        private void Computadora_botones()
        {
            label1.Visible = true;
            button1.Enabled = true;
            button1.Visible =true;
            button2.Enabled = true;
            button2.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            button4.Enabled = true;
            button4.Visible = true;
            button5.Enabled = true;
            button5.Visible = true;
            button6.Enabled = true;
            button6.Visible = true;
            button7.Enabled = true;
            button7.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
            button9.Enabled = true;
            button9.Visible = true;
            button10.Enabled = false;
            button10.Visible = false;
            button11.Enabled = false;
            button11.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            computadora = false;
            Computadora_botones();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            computadora = true;
            Computadora_botones();
        }
        private void inteligencia_compu()
        {
            if (computadora==true) {
                if (gana==false) {                   
                    Random casilla = new Random();                   
                    do
                    {
                        int tpc =  casilla.Next(0, 9);
                        if (tablero[tpc] == "x" || tablero[tpc] == "o")
                        {
                            tur = false;
                        }
                        else
                        {                           
                            tablero[tpc] = "o";
                            tur = true;                            
                            direccion = @"imagato\raton.png";                          
                            boton(tpc);
                            label1.Text = "Turno de Gato";
                            quiengana = "RATON";
                            ganar();
                        }
                    } while (tur != true);
                    con++;
                    juga = 0;
                    tur = false;
                }
            }
            
        }
        private void boton(int numboton)
        {
            switch (numboton)
            {
                case 0:                    
                    button1.BackgroundImage = Image.FromFile(direccion);
                    button1.BackgroundImageLayout = ImageLayout.Zoom;
                    button1.Enabled = false;
                    break;
                case 1:
                    button2.BackgroundImage = Image.FromFile(direccion);
                    button2.BackgroundImageLayout = ImageLayout.Zoom;
                    button2.Enabled = false;
                    break;
                case 2:
                    button3.BackgroundImage = Image.FromFile(direccion);
                    button3.BackgroundImageLayout = ImageLayout.Zoom;
                    button3.Enabled = false;
                    break;
                case 3:
                    button4.BackgroundImage = Image.FromFile(direccion);
                    button4.BackgroundImageLayout = ImageLayout.Zoom;
                    button4.Enabled = false;
                    break;
                case 4:
                    button5.BackgroundImage = Image.FromFile(direccion);
                    button5.BackgroundImageLayout = ImageLayout.Zoom;
                    button5.Enabled = false;
                    break;
                case 5:
                    button6.BackgroundImage = Image.FromFile(direccion);
                    button6.BackgroundImageLayout = ImageLayout.Zoom;
                    button6.Enabled = false;
                    break;
                case 6:
                    button7.BackgroundImage = Image.FromFile(direccion);
                    button7.BackgroundImageLayout = ImageLayout.Zoom;
                    button7.Enabled = false;
                    break;
                case 7:
                    button8.BackgroundImage = Image.FromFile(direccion);
                    button8.BackgroundImageLayout = ImageLayout.Zoom;
                    button8.Enabled = false;
                    break;
                case 8:
                    button9.BackgroundImage = Image.FromFile(direccion);
                    button9.BackgroundImageLayout = ImageLayout.Zoom;
                    button9.Enabled = false;
                    break;
            }
        }
    }
}
