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
            //Personajes archivos = new Personajes();
            VentanaJuego Juego = new VentanaJuego();
            this.Hide();
            Juego.Show();
            
        }
    }
}
