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
        private string nombrePersonaje
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
            AdministradorEnemigos();
        }
        public string AdministradorEnemigos()
        {
            Enemigo = 1;
            byte indexEnemigo = Enemigo;
            bool ciclovalidacion;
            do
            {
                if (indexEnemigo==10|| indexEnemigo==11|| indexEnemigo==15|| indexEnemigo==16|| indexEnemigo==17|| indexEnemigo==18)
                {
                    
                    ciclovalidacion = true;
                    nombrePersonaje = archivosimagenes[indexEnemigo];
                }
                else
                {                    
                    indexEnemigo = Enemigo;
                    ciclovalidacion = false;
                }
            } while (ciclovalidacion == false);
            
            return nombrePersonaje;
        }

    }
}
