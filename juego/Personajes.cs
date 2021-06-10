﻿using System;

using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace juego
{
    class Personajes
    {
        //Hola soy Jose
        //Dirección del directorio actual
        private static string DireccionImagenes = Directory.GetCurrentDirectory();
        public string direccionEse=@"Escenarios\image22.png";
        public byte posicionJefe;
        private byte _contadorenemigo;
        public byte Contadorenemigo { get => _contadorenemigo; set => _contadorenemigo = value; }

        //Dirección de las imagenes de los jefes
        private string[] _imagenesJefes;
        public string[] ImagenesJefes { get => _imagenesJefes; set => _imagenesJefes = Directory.GetFiles(DireccionImagenes + @"\JefesIma\", "*.*"); }

        private byte _dañoEnemigo;
        public byte DañoEnemigo { get => _dañoEnemigo; set => _dañoEnemigo = value; }

        //Arreglo que almacena cada dirección 
        private string[] _archivosimagenes;
        
        public string[] Archivosimagenes
        {
            get => _archivosimagenes;
            set => _archivosimagenes = Directory.GetFiles(DireccionImagenes + @"\ima\", "*.*");
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
            set=>_enemigo= (byte)new Random().Next(0, Archivosimagenes.Length);
        }
        private byte _corazonesPayer;
        public byte CorazonesPlayer {
            get => _corazonesPayer;
            set => _corazonesPayer = value;
        }
        

        public Personajes()
        {
            Archivosimagenes = Archivosimagenes;
            ImagenesJefes = ImagenesJefes;
            AdministradorEnemigos();
        }

        public string AdministradorEnemigos()
        {
            Enemigo = 10;
            byte indexEnemigo = Enemigo;
            bool ciclovalidacion;
            do
            {
                if (indexEnemigo==1|| indexEnemigo==3|| indexEnemigo==5)
                {
                    ciclovalidacion = true;
                    nombrePersonaje = Archivosimagenes[indexEnemigo];
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
        public void AdministradorJefes(byte contadorenemigo, PictureBox EnemiJefe)
        {
            
            switch (contadorenemigo) {
                case 3:
                    //Jefe planta
                    posicionJefe = 4;
                    direccionEse = @"Escenario\image22.png";
                    EnemiJefe.Image = Image.FromFile(ImagenesJefes[posicionJefe]);
                    
                    break;
                case 6:
                    //Jefe fantasma con hoz
                    posicionJefe = 1;
                    direccionEse = @"Escenario\image21.png";
                    EnemiJefe.Image = Image.FromFile(ImagenesJefes[posicionJefe]);
                    
                    break;
                case 9:
                    //Jefe robot
                    posicionJefe = 10;
                    direccionEse = @"Escenario\image21.png";
                    EnemiJefe.Image = Image.FromFile(ImagenesJefes[posicionJefe]);
                    
                    break;
                case 10:
                    posicionJefe = 7;
                    //Jefe brujita
                    direccionEse = @"Escenario\image20.png";
                    EnemiJefe.Image = Image.FromFile(ImagenesJefes[posicionJefe]);
                    
                    break;
            }
        }
        public void MuestraCorazones(PictureBox[] corazones)
        {
            for (byte i = 0; i <= CorazonesPlayer; i++)
            {
                corazones[i].Visible = true;  
            }   
        }
        public void GeneradorCorazones(PictureBox corazon1, PictureBox corazon2, PictureBox corazon3, PictureBox corazon4, PictureBox corazon5, PictureBox corazon6, Panel PanCora1)
        {

            if (CorazonesPlayer <= 3)
            {
                
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
                
                switch (CorazonesPlayer)
                {
                    case 0:
                        PanCora1.Visible = false;
                        
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
                       
                        PanCora1.Visible = true;
                        break;
                    case 1:
                        PanCora1.Visible = false;
                       
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
                        
                        PanCora1.Visible = true;
                        break;
                    case 2:
                        PanCora1.Visible = false;
                        
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
                        
                        PanCora1.Visible = true;
                        break;
                    case 3:
                        PanCora1.Visible = false;
                        
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
                        
                        PanCora1.Visible = true;
                        break;
                    case 4:
                        PanCora1.Visible = false;
                        
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
                        
                        PanCora1.Visible = true;
                        break;
                    case 5:
                        PanCora1.Visible = false;
                        
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
                        
                        PanCora1.Visible = true;
                        break;
                    case 6:
                        PanCora1.Visible = false;
                        
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
                        
                        PanCora1.Visible = true;
                        break;

                }
            }
        }
    }
}
