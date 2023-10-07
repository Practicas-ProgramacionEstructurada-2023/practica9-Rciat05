using System;
using System.Diagnostics;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int opcion;
            do 
            {
                Console.WriteLine("\nMenu de opciones:");
                Console.WriteLine("1.Multiplicar números");
                Console.WriteLine("2.Restar números");
                Console.WriteLine("3.Concatenar Cadenas ");
                Console.WriteLine("4.Salir ");
                Console.Write("\nIngrese su opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion ))
                {
                switch (opcion)
                {
                    case 1: 
                        Console.WriteLine("\nIngrese 2 numeros enteros para multiplicarlos ");

                        Console.Write("\nNumero 1: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                         Console.Write("Numero 2: ");
                        int num2 =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nResultado de la multiplicación (entero): " + Multiplicar (num1, num2));

                        Console.WriteLine("\nIngrese 2 numeros decimales para multiplicar: ");
                        
                        Console.WriteLine("\nNumero 1: ");
                        double num1double = Convert.ToDouble(Console.ReadLine());

                         Console.WriteLine("Numero 2: ");
                        double num2double = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("\nResultado de la multiplicación (decimal); " + Multiplicar(num1double, num2double));    
                        
                        break;
                    
                    case 2:
                        Console.WriteLine("\nEl resultado es: " + RestarNumeros(20, 5, 3, 2));

                        break;


                    case 3:
                        Console.Write("\nIngrese su primer nombre: "); 
                        string? cadena1 = Convert.ToString(Console.ReadLine());

                        Console.Write("\nIngrese su primer apellido: "); 
                        string? cadena2 = Convert.ToString(Console.ReadLine());

                        Console.Write("Ingrese el separador");
                        string? separador = Convert.ToString(Console.ReadLine());

                        string resultadoConcatenacion1 = ConcatenarCadena(cadena1, cadena2, separador);
                        Console.WriteLine($"Resultado de la contatenación: {resultadoConcatenacion1}");




                        Console.Write("\nIngrese su segundo nombre: "); 
                        string? cadena3 = Convert.ToString(Console.ReadLine());

                        Console.Write("\nIngrese su segundo apellido: "); 
                        string? cadena4 = Convert.ToString(Console.ReadLine());

                        Console.Write("\nIngrese su tercer apellido: "); 
                        string? cadena5 = Convert.ToString(Console.ReadLine());

                        Console.Write("Ingrese el separador");
                        string? separador2 = Convert.ToString(Console.ReadLine());

                        string resultadoConcatenacion2 = ConcatenarCadena(cadena3, cadena4, cadena5, separador2);
                        Console.WriteLine($"Resultado de la contatenación: {resultadoConcatenacion2}");
                        break;    
                    
                    case 4:
                        Console.WriteLine("\nSaliendo del programa...");
                        break;
                    default:
                            Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                        break;
                }
                }
                else
                {
                    Console.WriteLine("\nOpcion no valida. Intente de nuevo");
                }
            } while (opcion != 4);
        }
        
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }//Fin de multiplicar

        static double Multiplicar(double a, double b)
        {
            return a * b;
        } //Fin de double multiplicar

        static int RestarNumeros (params int[]numeros)
        {
            int resultado = numeros[0]; //Inicializamos el resultado con el primer número 

            for (int i = 1; i < numeros.Length; i++)
            {
                resultado -= numeros[i];
            }

            return resultado;
        } //Fin de restarNumeros

       static string ConcatenarCadena(string? cadena1, string? cadena2, string? separador)
       {
            return cadena1 + separador + cadena2;
       }

       static string ConcatenarCadena(string? cadena1, string? cadena2, string? cadena3, string? separador)
       {
            return cadena1 + separador + cadena2 + separador + cadena3;
       }
    }
}