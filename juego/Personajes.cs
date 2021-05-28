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
        private static string DireccionImagenes = Directory.GetCurrentDirectory();
        //Dirección de todos los personajes
        private string[] _Archivosimagenes;
        public string[] archivosimagenes
        {
            get => _Archivosimagenes;
            set => _Archivosimagenes = Directory.GetFiles(DireccionImagenes + @"\ima\", "*.*");
        }
        
        private string _NombrePersonaje;
        public string nombrePersonaje
        {
            get =>_NombrePersonaje;
            set =>_NombrePersonaje=value;
        }
        private byte _enemigo;
        public byte Enemigo
        {
            get => _enemigo;
            set=>_enemigo= (byte)new Random().Next(0, archivosimagenes.Length);
        }
        
        public Personajes()
        {
            archivosimagenes = archivosimagenes;
            AdministradorEnemigos(Enemigo);
        }
        public string AdministradorEnemigos(byte indexEnemigo)
        {
            for(byte i=0; i < archivosimagenes.Length; i++)
            {
                if (indexEnemigo == 0||indexEnemigo==1)
                {
                    Enemigo = 1;
                }
                else
                {
                    if (i == indexEnemigo)
                    {
                        nombrePersonaje = archivosimagenes[i];
                    }
                }
                
            }
            return nombrePersonaje;
        }

    }
}
