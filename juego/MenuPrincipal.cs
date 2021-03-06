using System;

using System.Drawing;

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
            //VentanaJuego Juego = new VentanaJuego();
            //Juego.Show();
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
           
            VentanaJuego Juego = new VentanaJuego(3,0,3,@"Escenarios\image22.png");
            Menu.Ctlcontrols.stop();
            time_bu.Stop();
            this.Hide();
            Juego.Show();
            
        }
        //Bucle de musica menu
        private void Bu(object sender, EventArgs e)
        {
            Menu.settings.volume = 15;
            Menu.URL = @"so\menu.wav";
            Menu.Ctlcontrols.play();
        }
        //barra de volumen
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Menu.settings.volume = trackBar1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gato_raton gato = new Gato_raton();
            Menu.Ctlcontrols.stop();
            time_bu.Stop();
            this.Hide();
            gato.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ahorcado aho = new ahorcado();
            Menu.Ctlcontrols.stop();
            time_bu.Stop();
            this.Hide();
            aho.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Menu.settings.volume = 15;
            Menu.URL = @"so\menu.wav";
            time_bu.Start();
        }
    }
}
