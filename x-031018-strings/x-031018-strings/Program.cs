using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_031018_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que te calcule la largura de un string.

            //string respuesta;
            //respuesta = Console.ReadLine();


            //Console.WriteLine(respuesta.Length);
            //Console.ReadLine();


            //Escribe un programa que te calcule el total de palabras que hay en un string.

            //string respuesta;
            //respuesta = Console.ReadLine();

            //Console.WriteLine(respuesta.());
            //Console.ReadLine();


            //Escribe un programa que nos cuente el número de vocales en un string.

            int vocales = 0;
            string respuesta;
            Console.WriteLine("Dime tu nombre. ");
            respuesta = Console.ReadLine();

            for (int i = 0; i < respuesta.Length; i++)
            {
                if(respuesta[i] == 'a' || respuesta[i] == 'e' || respuesta[i] == 'i' || respuesta[i] == 'o' || respuesta[i] == 'u')
                {
                    vocales++;
                }
                
            }
            Console.WriteLine("La palabra " + respuesta + " tiene " + vocales + " vocales.");
            Console.ReadLine();
        }
    }
}
