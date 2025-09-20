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
            //int i;
            for (int i=1; i<=10;i++)
            {
                Console.WriteLine(i);
            }




        }
    }
}
