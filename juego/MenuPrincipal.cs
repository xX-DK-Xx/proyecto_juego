using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;


namespace juego
{
    public partial class MenuPrincipal : Form
    {
        
        public MenuPrincipal()
        {
            InitializeComponent();
            Menu.URL= @"so\menu.wav";
            Menu.settings.volume = 20;
            time_bu.Start();
            //VentanaJuego Juego = new VentanaJuego();
            //Juego.Show();
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
           
            VentanaJuego Juego = new VentanaJuego();
            Menu.Ctlcontrols.stop();
            time_bu.Stop();
            this.Hide();
            Juego.Show();
            
        }
        //Bucle de musica menu
        private void Bu(object sender, EventArgs e)
        {
            Menu.settings.volume = trackBar1.Value;
            Menu.URL = @"so\menu.wav";
            Menu.Ctlcontrols.play();
        }
        //barra de volumen
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Menu.settings.volume = trackBar1.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gato_raton gato = new Gato_raton();
            Menu.Ctlcontrols.stop();
            time_bu.Stop();
            this.Hide();
            gato.Show();
        }
    }
}
