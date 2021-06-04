using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    class Problemas_Y_Control
    {
        private Random numero1 = new Random();
        private Random numero2=new Random();
        public Problemas_Y_Control(Label ProblemaMuestra)
        {
            GeneradorProblemas(ProblemaMuestra);
        }
       
        private bool Fracciones;
        private void AdministradorElementos(byte contador, Panel PanelProblemas, TextBox Numerado, TextBox Denominador, Label Problema)
        {
            if (contador>5) {
                Fracciones = true;
            }
            else
            {
                Fracciones = false;
                Problema.Visible = false;
                Denominador.Visible = false;
                Denominador.Enabled = false;
                Numerado.Location = new Point(123,21);
                PanelProblemas.Controls.Add(Numerado);
            }
            
            /*
            textoRespuesta.Location = new Point(123, 21);
            panel1.Controls.Add(textoRespuesta);*/
        }
        private void GeneradorProblemas(Label Problema)
        {
            bool validarcaracter;
            char ayudaCaracter;
            char[] caracteresAgrupacion = {'(',')','+','-','÷','x'};
            string cadenaProblema = "";
            byte numeroOperaciones = (byte)new Random().Next(1,5);
            Random empiezaNumeroCaracter =new Random();
            Random eleccionOperador = new Random();
            if (Fracciones==false) {
                for (byte i=0;i<numeroOperaciones ;i++) {
                    if (empiezaNumeroCaracter.Next(0, 1) == 1) {
                        cadenaProblema += numero1.Next(1, 20).ToString();
                    }
                    else
                    {
                        
                    }
                }
            }   
        }
    }
}
