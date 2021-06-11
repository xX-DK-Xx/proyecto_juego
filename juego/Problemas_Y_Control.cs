using System;
using System.Windows.Forms;
using System.Drawing;

using System.Threading.Tasks;

namespace juego
{
    class Problemas_Y_Control
    {
        private int numero1;
        private int numero2;
        public string problemagenerado;
        public Button botoncambioImagen;
        private Random azar = new Random();

        private double _respuestaDenominador;
        public double RespuestaDenominador { get => _respuestaDenominador; set => _respuestaDenominador = value; }

        public double RespuestaCorrecta {
            get => _respuestacorrecta;
            set => _respuestacorrecta = value;
        }
        

        private double _respuestacorrecta;

        public Problemas_Y_Control()
        {

        }

        public bool Fracciones;
        /*Recibe los objetos de */
        public void AdministradorElementos(byte contador, Panel PanelProblemas, TextBox Numerado, TextBox Denominador)
        {
            if (contador > 5) {
                Fracciones = true;
                Denominador.Visible = true;
                Numerado.Location = new Point(132, 8);
                PanelProblemas.Controls.Add(Numerado);

            }
            else
            {
                Fracciones = false;

                Denominador.Visible = false;
                Denominador.Enabled = false;
                Numerado.Location = new Point(123, 21);
                PanelProblemas.Controls.Add(Numerado);
            }

            /*
            textoRespuesta.Location = new Point(123, 21);
            panel1.Controls.Add(textoRespuesta);*/
        }
        //Genera el problema matematico
        public void GeneradorProblemas(Label Problema)
        {
            Problema.Location = new Point(40, 42);
            problemagenerado = "";
            RespuestaCorrecta = 0;
            //Determina si la operación generada sera de fracciones o no

            //Genera el núemero de operaciones que se harán
            int numeroOperaciones = Operacionazar();
            if (numeroOperaciones == 1) {
                double num1 = Numeroazar();
                double num2 = Numeroazar();
                int operadornum = Operacionazar();
                switch (operadornum)
                {
                    case 1:
                        RespuestaCorrecta = num1 + num2;
                        problemagenerado += num1 + "+" + num2;
                        break;
                    case 2:
                        RespuestaCorrecta = num1 - num2;
                        problemagenerado += num1 + "-" + num2;
                        break;
                    case 3:
                        RespuestaCorrecta = num1 * num2;
                        problemagenerado += num1 + "x" + num2;
                        break;
                    case 4:
                        RespuestaCorrecta = num1 / num2;
                        problemagenerado += num1 + "➗" + num2;
                        break;

                }

            }
            else
            {
                for (byte i = 1; i <= numeroOperaciones; i++) {

                    if (i == 1) {
                        numero1 = Numeroazar();
                        numero2 = Numeroazar();
                        switch (Operacionazar()) {
                            case 1:
                                RespuestaCorrecta = numero1 + numero2;
                                problemagenerado = "(" + numero1 + "+" + numero2 + ")";
                                break;
                            case 2:
                                RespuestaCorrecta = numero1 - numero2;
                                problemagenerado = "(" + numero1 + "-" + numero2 + ")";
                                break;
                            case 3:
                                RespuestaCorrecta = numero1 * numero2;
                                problemagenerado = "(" + numero1 + "x" + numero2 + ")";
                                break;
                            case 4:
                                RespuestaCorrecta = numero1 / numero2;
                                problemagenerado = "(" + numero1 + "➗" + numero2 + ")";
                                break;

                        }
                    }
                    double numero3 = Numeroazar();
                    switch (Operacionazar()) {
                        case 1:
                            RespuestaCorrecta += numero3;
                            problemagenerado = "(" + problemagenerado + "+" + numero3 + ")";
                            break;
                        case 2:
                            RespuestaCorrecta -= numero3;
                            problemagenerado = "(" + problemagenerado + "-" + numero3 + ")";
                            break;
                        case 3:
                            RespuestaCorrecta *= numero3;
                            problemagenerado = "(" + problemagenerado + "x" + numero3 + ")";
                            break;
                        case 4:
                            RespuestaCorrecta /= numero3;
                            problemagenerado = "(" + problemagenerado + "➗" + numero3 + ")";
                            break;
                    }
                }

                RespuestaCorrecta = Math.Round(RespuestaCorrecta, 3, MidpointRounding.AwayFromZero);
            }
            Problema.Text = problemagenerado;
        }

        public void GeneradorProblefracciones(Label numerador1, Label denominador1, Label numerador2, Label denominador2, Label numerador3, Label denominador3, Panel PrimeraFrac, Panel segundofrac, Panel TerceraFrac, Label ProblemaGen,Label Operador1,Label Operador2) {
            ProblemaGen.Visible = false;
            ProblemaGen.Enabled = false;
            
            
            int numeroOpera = azar.Next(1, 2);
            if (numeroOpera == 1) {
                PrimeraFrac.Visible = true;
                segundofrac.Visible = true;
                PrimeraFrac.Location = new Point(111,33);
                segundofrac.Location = new Point(243, 33);
                Operador1.Location = new Point(211, 83);
                int operacion = Operacionazar();
                //Numerador y denominador para la primera fracción
                int numdem = Numeroazar();
                int numNumerador = Numeroazar();
                //Numerador y denominador para la segunda fracción
                int Numerador2frac = Numeroazar();
                int Denominador2frac = Numeroazar();
                
                numerador1.Text = numNumerador.ToString();
                numerador2.Text = Numerador2frac.ToString();
                denominador1.Text = numdem.ToString();
                denominador2.Text = Denominador2frac.ToString();

                switch (operacion)
                {
                    case 1:
                        //Genera el numerador y el denominador
                        Validadordenominador(numdem, Denominador2frac,numNumerador,Numerador2frac,'+');
                        Operador1.Text = "+";
                        break;
                    case 2:
                        //Denominador
                        Validadordenominador(numdem, Denominador2frac, numNumerador, Numerador2frac, '-');
                        Operador1.Text = "-";
                        
                        break;
                    case 3:
                        //Denominador
                        RespuestaDenominador = numdem * Numerador2frac;
                        Operador1.Text = "x";
                        //Numerador
                        RespuestaCorrecta = numNumerador * Denominador2frac;
                        break;
                    case 4:
                        //Denominador
                        RespuestaDenominador = numNumerador *Denominador2frac;
                        Operador1.Text = "÷";
                        //Numerador
                        RespuestaCorrecta = numdem * Numerador2frac;
                        break;

                }
            }
            else {
                byte[] operadores = new byte[] {(byte)Operacionazar(),(byte)Operacionazar() };
                PrimeraFrac.Visible = true;
                segundofrac.Visible = true;
                TerceraFrac.Visible = true;

                


                bool operacionsiguiente = false ;
                //Numerador y denominador para la primera fracción
                int numdem = Numeroazar();
                int numNumerador = Numeroazar();
                //Numerador y denominador para la segunda fracción
                int Numerador2frac = Numeroazar();
                int Denominador2frac = Numeroazar();
                //Numerador y denominador para la tercera fracción
                int numefrac3 = Numeroazar();
                int denofrac3 = Numeroazar();

                int numefracr1=0,denfracr1=0;

                numerador1.Text = numNumerador.ToString();
                numerador2.Text = Numerador2frac.ToString();
                denominador1.Text = numdem.ToString();
                denominador2.Text = Denominador2frac.ToString();
                numerador3.Text = numefrac3.ToString();
                denominador3.Text = denofrac3.ToString();
                //Primero hace la operación del denominador y luego la del numerador

                for (byte i=0;i<2 ;i++) {
                    if (i == 0) {
                        if (operadores[i] > operadores[i + 1])
                        {
                            operacionsiguiente = true;
                            switch (operadores[i])
                            {
                                case 1:
                                    Validadordenominador(numdem,Denominador2frac,numNumerador,Numerador2frac,'+');
                                    Operador1.Text = "+";
                                    break;
                                case 2:
                                    Validadordenominador(numdem, Denominador2frac, numNumerador, Numerador2frac, '-');
                                    Operador1.Text = "-";

                                    break;
                                case 3:
                                    RespuestaDenominador = numdem * Denominador2frac;
                                    //Numerador
                                    RespuestaCorrecta = numNumerador * Numerador2frac;
                                    Operador1.Text = "x";

                                    break;
                                case 4:
                                    RespuestaCorrecta = numNumerador * Denominador2frac;
                                    RespuestaDenominador = numdem * Numerador2frac;

                                    Operador1.Text = "÷";
                                    break;

                            }
                            numefracr1 = (int)RespuestaCorrecta;
                            denfracr1 = (int)RespuestaDenominador;
                        }
                        else {
                            operacionsiguiente = false;
                            switch (operadores[i+1]) {
                                case 1:
                                    Validadordenominador(Denominador2frac,denofrac3 , Numerador2frac,numefrac3 , '+');
                                    Operador2.Text = "+";
                                    break;
                                case 2:
                                    Validadordenominador(Denominador2frac, denofrac3, Numerador2frac, numefrac3, '-');
                                    Operador2.Text = "-";
                                    break;
                                case 3:
                                    RespuestaDenominador = denofrac3 * Denominador2frac;
                                    //Numerador
                                    RespuestaCorrecta = numefrac3 * Numerador2frac;
                                    Operador2.Text = "x";
                                    break;
                                case 4:
                                    RespuestaCorrecta = Numerador2frac * denofrac3;
                                    RespuestaDenominador = Denominador2frac * numefrac3;
                                    Operador2.Text = "÷";
                                    break;
                            }
                            numefracr1 = (int)RespuestaCorrecta;
                            denfracr1 = (int)RespuestaDenominador;
                        }
                    }
                    else{
                        if (operacionsiguiente==false) {
                            switch (operadores[i-1]) {
                                case 1:
                                    if (numdem==denfracr1) {
                                        RespuestaDenominador = numdem;
                                        RespuestaCorrecta = (numNumerador+numefracr1);
                                    }
                                    else
                                    {
                                        RespuestaDenominador = (numdem * denfracr1);
                                        RespuestaCorrecta = (numNumerador * denfracr1) + (numdem * numefracr1);
                                    }
                                    break;
                                case 2:
                                    if (numdem == denfracr1)
                                    {
                                        RespuestaDenominador = numdem;
                                        RespuestaCorrecta = (numNumerador - numefracr1);
                                    }
                                    else
                                    {
                                        RespuestaDenominador = (numdem * denfracr1);
                                        RespuestaCorrecta = (numNumerador * denfracr1) - (numdem * numefracr1);
                                    }
                                    break;
                                case 3:
                                    RespuestaCorrecta = (numNumerador*numefracr1);
                                    RespuestaDenominador = numdem * denfracr1;
                                    break;
                                case 4:
                                    RespuestaCorrecta = (numNumerador * denfracr1);
                                    RespuestaDenominador = numdem * numefracr1;
                                    break;
                            }
                        }
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
        private int Numeroazar()
        {
            int numero = azar.Next(1, 11);
            return numero;
        }
        private int Operacionazar()
        {
            int numero = azar.Next(1, 4);
            return numero;
        }

        private void Validadordenominador(int denominador1,int denominador2,int numerador1,int numerador2,char operador){
            if (denominador1 == denominador2)
            {
                RespuestaDenominador = denominador1;
                switch (operador)
                {
                    case '+':
                        RespuestaCorrecta = numerador1 + numerador2;
                        break;
                    case '-':
                        RespuestaCorrecta = numerador1 - numerador2;
                        break;
                }
            }
            else {
                RespuestaDenominador = denominador1 * denominador2;
                switch (operador) {
                    case '+':
                        RespuestaCorrecta = (numerador1 * denominador2) + (numerador2 * denominador1);
                        break;
                    case '-':
                        RespuestaCorrecta = (numerador1 * denominador2) - (numerador2 * denominador1);
                        break;
                }
            }
        }

    }
}

/*  private char[] caracteresAgrupacion = { '(', '+', '-', '÷', 'x' };
 *  private void SolucionadorProblema()
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

       }*/
/*Codigo anterior de generación de problemas
 * /*
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
                
            } 
*/

