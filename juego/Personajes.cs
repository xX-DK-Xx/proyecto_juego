using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace juego
{
    class Personajes
    {
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

    }
}
