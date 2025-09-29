using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa que pida al usuaio un numero del 1 al 12 y escriba el nombre del mes 
            //que corresponde a ese numero en el calendario. Agregar un case default.
            /*
            int numero;
            Console.WriteLine("Ingrese un numero del 1 al 12: ");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:    
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            } */

            /*  //hacer un programa que pida al usuario un numero y decida si es par o impar.
              int numero = 0;
              Console.WriteLine("Ingrese un numero: ");
              numero = int.Parse(Console.ReadLine());

              switch (numero%2)
              {
                  case 0:
                      Console.WriteLine("El numero es par");
                      break;
                  default:
                      Console.WriteLine("El numero no es par");
                      break;
              }*/


            /*  //ejercicio de las horas y pago de estacionamiento

              float minutos;
              Console.WriteLine("Ingrese la cantidad de minutos que estuvo estacionado: ");
              minutos = Convert.ToSingle(Console.ReadLine());

              if((minutos >= 0) && (minutos <= 60))
              {
                  Console.WriteLine("Debe pagar $5.00 USD");
              }
              else
              {
                  if ((minutos >= 60) && (minutos <= 120))
                  {
                      Console.WriteLine("Paga $15.00 USD ");
                  }
                  else
                  {
                      if(minutos > 120)
                      {
                          Console.WriteLine("Paga $40.00 por favor");
                      }
                  }
              }*/


            /* //PRACTIDA DE OPERADORES DE INCREMENTO Y DECREMENTO

             int i;
             i = 10;
             Console.WriteLine("Valor inicial del operador :{0}", i);
             Console.WriteLine("Valor con incremento :{0}", ++i);
             Console.WriteLine(i);
             Console.WriteLine("************************************************");
             int n = 20;
             Console.WriteLine("Valor inicial de n: {0} ",n);
             Console.WriteLine("Variable de decremento: {0}",--n);
             Console.WriteLine("Variable con decremento n-- {0}",n);
             */


            /* //Ejercicio de Escuela y Notas

             double calificacion1, calificacion2, calificacion3,promedio;

             Console.WriteLine("Ingrese la calificacion 1 : ");
             calificacion1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Ingrese la calificacion 2 : ");
             calificacion2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Ingrese la calificacion 3 : ");
             calificacion3 = Convert.ToDouble(Console.ReadLine());

             promedio = (calificacion1 + calificacion2 + calificacion3)/3;

             Console.WriteLine("El promedio de calificaciones es: {0}", promedio);*/

            //FOR con expresion Boolean
            //variable de control
            //Asignacion compuesta (x - = 5) == (x = x -5)

            /*  int i;
              int contador = 0;

              for (i=1; i <= 10; i++)
              {
                  contador++;
                  Console.WriteLine("Vuelta del ciclo numero {0}",contador);
              }
              Console.WriteLine("El numero de vueltas que dio el ciclo fue {0}",contador);
            */

            //Ejercicio que pregunta el numero de alumnos a calificar,
            //pide la calificacion de cada alumno 
            //calcula el promedio de calificaciones
            //muestra el promedio 

            /*byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Console.WriteLine("Intruduce la cantidad de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i=1; i<=numAlumnos; i++)
            {
                Console.WriteLine("Ingresa la calificacion: ");
                calificacion=Convert.ToDouble(Console.ReadLine());
                sumaCalif += calificacion;
            }
            promedio = sumaCalif / numAlumnos;

            Console.WriteLine("El primedio es: {0} ", promedio);

            */















            /*    //sucesion de Fibonacci

                //0,1,1,2,3,5,8,13,21,34,55,89,

                            Console.WriteLine("¿Cuantos numeros quieres ver?");
                            int n= int.Parse(Console.ReadLine());

                            int a = 0;
                            int b = 1;
                            int c;

                            Console.WriteLine("Secesion de fibonacci: ");
                            for (int i=0; i<n; i++)
                            {
                                Console.Write(a + " ");
                                c = a + b;
                                a = b;
                                b = c;
                            }
                            Console.WriteLine();
            */



            /*
            //Ejercicio de Factoreo
            ulong i, numero, factorial = 1;
            Console.WriteLine("Ingresa el numero para calcular el factorial: ");
            numero = Convert.ToUInt64(Console.ReadLine());

            for(i=numero; i>=1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial de {0} , es : {1}", numero , factorial);
            */

            /*
             * //Ejercicio con WHILE, este se usa cuando no sabemos la cantidad de veces a repetir un ciclo

             byte numero = 1;
             while (numero<=10)
             {
                 Console.WriteLine(numero);
                 numero++;
             }*/


            /*
            //Ejercicio WHILE: Contraseñas
            string contraseña1, contraseña2="";
            //contraseña2 debo incializarla en vacio "" pues la estoy usando antes de darle valor en el bucle

            Console.WriteLine("Ingrese la contraseña 1: ");
            contraseña1=Convert.ToString(Console.ReadLine());

            while (contraseña1 != contraseña2)
            {
                Console.WriteLine("Confirma tu contraseña: ");
                contraseña2=Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Contraseña Guardada ");
            */


            /*
                        //Ejercicios con DO

                        int i = 10;

                        //do
                        //{
                        //    Console.WriteLine(i--);
                        //} while (i>=1);

                        while (i >= 1) 
                        {
                            Console.WriteLine(i--);
                        } 
                        */

            /*
            //ejercicio de operaciones basicas

            decimal num1, num2, resultado=0;
            byte opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Division");
                Console.WriteLine("4. Multiplicacion");
                Console.WriteLine("Escoge una opcion: ");
                opcion=Convert.ToByte(Console.ReadLine());

            } while ((opcion <1) || (opcion >4));


            Console.WriteLine("Dame el primer numero: ");
            num1 =Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            switch (opcion)
            {
                    case 1:
                    resultado = num1 + num2;
                    break;

                    case 2:
                    resultado = num1 - num2;
                    break;

                    case 3: 
                    resultado=num1 * num2;
                    break;

                    case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("El divisor no es valido ");
                    }
                    break;
                  }
            Console.WriteLine("El resultado es {0}", resultado);
            */


            //Instrucciones de Iteraciones anidadas
            /*
            int i;
            int j;
            int resultado=0;

            for(i=1;i<=10;i++)
            {
                Console.WriteLine("Tabla de multiplicar del {0}",i);
                for (j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);
                }
            }
            Console.ReadKey();
            */

            //ejercicio calculando la potencia de un numero
            int i;
            int numBase;
            int numPotencia;
            double resultado = 1;
            double    resultadoNegativo;

            Console.WriteLine("Ingrese el numero base de la operacion: ");
            numBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la potencia a operar: ");
            numPotencia = Convert.ToInt32(Console.ReadLine());


            if (numPotencia < 0)
            {
                //numPotencia = numPotencia * -1;
                numPotencia *= -1;
            }

            for (i = 1; i <= numPotencia; i++)
            {
                //resultado = resultado * numBase;
                resultado *= numBase;
            }
            resultadoNegativo = (1 / resultado);

            //mostamos el resultado negativo
            Console.WriteLine("{0}^{1}={2}", numBase,numPotencia,resultadoNegativo);


        }
    }
}
