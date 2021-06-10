using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace juego
{
    class Personajes
    {
        //Hola soy Jose
        //Dirección de todos los personajes
        private static string DireccionImagenes = Directory.GetCurrentDirectory();
        //Arreglo que almacena cada dirección 
        private string[] _Archivosimagenes;
        public string[] archivosimagenes
        {
            get => _Archivosimagenes;
            set => _Archivosimagenes = Directory.GetFiles(DireccionImagenes + @"\ima\", "*.*");
        }
        //Almacena la localización del nombre del personage específicado
        private string _NombrePersonaje;
        private string nombrePersonaje
        {
            get =>_NombrePersonaje;
            set =>_NombrePersonaje=value;
        }
        //Escoge el enemigo a aparecer
        private byte _enemigo;
        public byte Enemigo
        {
            get => _enemigo;
            set=>_enemigo= (byte)new Random().Next(0, archivosimagenes.Length);
        }
        private byte _corazonesPayer;
        public byte CorazonesPlayer {
            get => _corazonesPayer;
            set => _corazonesPayer = value;
        }
        public Personajes()
        {
            archivosimagenes = archivosimagenes;
            AdministradorEnemigos();
        }

        public string AdministradorEnemigos()
        {
            Enemigo = 10;
            byte indexEnemigo = Enemigo;
            bool ciclovalidacion;
            do
            {
                if (indexEnemigo==1|| indexEnemigo==6|| indexEnemigo==8)
                {
                    ciclovalidacion = true;
                    nombrePersonaje = archivosimagenes[indexEnemigo];
                }
                else
                {
                    Enemigo = 1;
                    indexEnemigo = Enemigo;
                    ciclovalidacion = false;
                }
            } while (ciclovalidacion == false);
            
            return nombrePersonaje;
        }
        public void AdministradorJefes()
        {

        }
        public void MuestraCorazones(PictureBox[] corazones)
        {
            for (byte i = 0; i <= CorazonesPlayer; i++)
            {
                corazones[i].Visible = true;  
            }   
        }
        public void GeneradorCorazones(PictureBox corazon1, PictureBox corazon2, PictureBox corazon3, PictureBox corazon4, PictureBox corazon5, PictureBox corazon6, Panel PanCora1, Panel PanCora2)
        {

            if (CorazonesPlayer <= 3)
            {
                PanCora2.Visible = false;
                switch (CorazonesPlayer)
                {
                    case 0:
                        PanCora1.Visible = false;
                        corazon1.Image = Image.FromFile(@"ima\image6.png");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image = Image.FromFile(@"ima\image6.png");
                        corazon2.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon3.Image = Image.FromFile(@"ima\image6.png");
                        corazon3.SizeMode = PictureBoxSizeMode.Zoom;
                        PanCora1.Visible = true;
                        break;
                    case 1:
                        PanCora1.Visible = false;
                        corazon1.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image = Image.FromFile(@"ima\image6.png");
                        corazon2.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon3.Image = Image.FromFile(@"ima\image6.png");
                        corazon3.SizeMode = PictureBoxSizeMode.Zoom;
                        PanCora1.Visible = true;
                        break;
                    case 2:
                        PanCora1.Visible = false;
                        corazon1.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon3.Image = Image.FromFile(@"ima\image6.png");
                        corazon3.SizeMode = PictureBoxSizeMode.Zoom;
                        PanCora1.Visible = true;
                        break;
                    case 3:
                        PanCora1.Visible = false;
                        corazon1.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon3.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon3.SizeMode = PictureBoxSizeMode.Zoom;
                        PanCora1.Visible = true;
                        break;

                }
            }
            else
            {
                PanCora2.Visible = true;
                switch (CorazonesPlayer)
                {
                    case 0:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image = Image.FromFile(@"ima\image6.png");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image = Image.FromFile(@"ima\image6.png");
                        corazon2.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon3.Image = Image.FromFile(@"ima\image6.png");
                        corazon3.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon4.Image = Image.FromFile(@"ima\image6.png");
                        corazon4.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon5.Image = Image.FromFile(@"ima\image6.png");
                        corazon5.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon6.Image = Image.FromFile(@"ima\image6.png");
                        corazon6.SizeMode=PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;
                    case 1:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image=Image.FromFile(@"ima\image6.png");
                        corazon2.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon3.Image=Image.FromFile(@"ima\image6.png");
                        corazon3.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon4.Image=Image.FromFile(@"ima\image6.png");
                        corazon4.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon5.Image=Image.FromFile(@"ima\image6.png");
                        corazon5.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon6.Image=Image.FromFile(@"ima\image6.png");
                        corazon6.SizeMode=PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;
                    case 2:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon3.Image=Image.FromFile(@"ima\image6.png");
                        corazon3.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon4.Image=Image.FromFile(@"ima\image6.png");
                        corazon4.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon5.Image=Image.FromFile(@"ima\image6.png");
                        corazon5.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon6.Image=Image.FromFile(@"ima\image6.png");
                        corazon6.SizeMode = PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;
                    case 3:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon3.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon3.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon4.Image=Image.FromFile(@"ima\image6.png");
                        corazon4.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon5.Image=Image.FromFile(@"ima\image6.png");
                        corazon5.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon6.Image=Image.FromFile(@"ima\image6.png");
                        corazon6.SizeMode=PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;
                    case 4:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon3.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon3.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon4.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon4.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon5.Image=Image.FromFile(@"ima\image6.png");
                        corazon5.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon6.Image=Image.FromFile(@"ima\image6.png");
                        corazon6.SizeMode=PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;
                    case 5:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon2.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon3.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon3.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon4.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon4.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon5.Image=Image.FromFile(@"ima\imagegif2.gif");
                        corazon5.SizeMode=PictureBoxSizeMode.Zoom;
                        corazon6.Image=Image.FromFile(@"ima\image6.png");
                        corazon6.SizeMode=PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;
                    case 6:
                        PanCora1.Visible = false;
                        PanCora2.Visible = false;
                        corazon1.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon1.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon2.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon2.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon3.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon3.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon4.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon4.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon5.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon5.SizeMode = PictureBoxSizeMode.Zoom;
                        corazon6.Image = Image.FromFile(@"ima\imagegif2.gif");
                        corazon6.SizeMode = PictureBoxSizeMode.Zoom;
                        PanCora2.Visible = true;
                        PanCora1.Visible = true;
                        break;

                }
            }
        }
    }
}
