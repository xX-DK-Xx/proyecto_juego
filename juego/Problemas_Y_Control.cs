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
        public string problemagenerado;
        public Button botoncambioImagen;

        public double RespuestaCorrecta {
            get => _respuestacorrecta;
            set => _respuestacorrecta=value;
        }

        private double _respuestacorrecta;
        

        private char[] caracteresAgrupacion = { '(', '+', '-', '÷', 'x' };
        public Problemas_Y_Control()
        {
            
        }
       
        private bool Fracciones;
        /*Recibe los objetos de */
        public void AdministradorElementos(byte contador, Panel PanelProblemas, TextBox Numerado, TextBox Denominador)
        {
            if (contador>5) {
                Fracciones = true;
            }
            else
            {
                Fracciones = false;
                
                Denominador.Visible = false;
                Denominador.Enabled = false;
                Numerado.Location = new Point(123,21);
                PanelProblemas.Controls.Add(Numerado);
            }
            
            /*
            textoRespuesta.Location = new Point(123, 21);
            panel1.Controls.Add(textoRespuesta);*/
        }
        public void GeneradorProblemas(Label Problema,Panel PanelMuestraproblema)
        {

            byte contadorparen=0;
            
            
            string cadenaProblema = "";
            byte numeroOperaciones = (byte)new Random().Next(1,5);//Declara el número de operaciones que se realizará

            Random empiezaNumeroCaracter =new Random();

            
            
            if (Fracciones==false) {
                //Determina si el problema empezará con un "(" o no, si no es así, empieza con un número
                if (empiezaNumeroCaracter.Next(0, 1) == 1)
                {
                    cadenaProblema += numero1.Next(1, 20).ToString();
                }
                else
                {
                    cadenaProblema += "(";
                    cadenaProblema += numero1.Next(1,20).ToString();
                    contadorparen++;
                }
                //Comienza a llenar un string de operaciones
                for (byte i=0;i<numeroOperaciones ;i++) {
                    //Agrega la primera operación a realizar
                    cadenaProblema += caracteresAgrupacion[empiezaNumeroCaracter.Next(0,4)];
                    if (cadenaProblema[cadenaProblema.Length - 1] == '(') {
                        contadorparen++;
                    }                    
                    cadenaProblema += numero1.Next(1,20).ToString();
                }
                for (byte i=0;i<contadorparen ;i++) {
                    cadenaProblema += ")";
                }
                //Modifica el contenido de la etiqueta
                Problema.Text = cadenaProblema;
                
                PanelMuestraproblema.Controls.Add(Problema);

                problemagenerado = cadenaProblema;
                SolucionadorProblema();
            }   
        }
        //optiene los números de la operación generada
        private void SolucionadorProblema()
        {
            string[] operaciones = problemagenerado.Split(new char[] {'(',')'}, StringSplitOptions.RemoveEmptyEntries);
            double ayudaoperacion;

            if (double.TryParse(operaciones[operaciones.Length-1][0].ToString(), out ayudaoperacion) == true)
            {
                RespuestaCorrecta = ayudaoperacion;
            }
            //Comienza a resolver las operaciones desde la ultima subcadena
            for (int i=operaciones.Length-1; i>0 ;i--) {
                
                for (byte j=0;j<operaciones[i].Length-1 ;j++) {
                    switch (operaciones[i][j]) {
                        //Busca en la cadena las operaciones que hay
                        case '+':
                            ayudaoperacion = double.Parse(operaciones[i][j - 1].ToString()) + int.Parse(operaciones[i][j + 1].ToString());
                            RespuestaCorrecta = ayudaoperacion;
                            break;
                        case '-':
                            ayudaoperacion = double.Parse(operaciones[i][j - 1].ToString()) - int.Parse(operaciones[i][j + 1].ToString());
                            RespuestaCorrecta= ayudaoperacion;
                            break;
                        case 'x':
                            ayudaoperacion = double.Parse(operaciones[i][j - 1].ToString()) *int.Parse(operaciones[i][j + 1].ToString());
                            RespuestaCorrecta = ayudaoperacion;
                            break;
                        case '÷':
                            ayudaoperacion = double.Parse(operaciones[i][j - 1].ToString()) / int.Parse(operaciones[i][j + 1].ToString());
                            RespuestaCorrecta = ayudaoperacion;
                            break;
                    }
                    
                }
            }        
            
        }
        public void Animacionboton(Button botonImagen, Timer tiempoAnimacion) {
            botonImagen.BackgroundImage = Image.FromFile(@"ima\image19.png");
            tiempoAnimacion.Start();
            botonImagen.BackgroundImageLayout = ImageLayout.Zoom;
            botoncambioImagen = botonImagen;
        }
        

    }
}
