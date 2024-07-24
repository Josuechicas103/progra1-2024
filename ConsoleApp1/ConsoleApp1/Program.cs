using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            // ejercio de obtener la nota final de la materia de programacion 1.
            Console.Write("lab1:");
            double lab1 = double.Parse(Console.ReadLine());//8

            Console.Write("lab2:");
            double lab2 = double.Parse(Console.ReadLine());//9

            Console.Write("Parcial 1:");
            double Parcial1 = double.Parse(Console.ReadLine());//7

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + Parcial1 * 40 / 100;
            Console.WriteLine("la nota de C1 es : {0}", c1);

          
            
            Console.Write("lab1:");
            double Lab1 = double.Parse(Console.ReadLine());//6

            Console.Write("lab2:");
            double Lab2 = double.Parse(Console.ReadLine());//6

            Console.Write("Parcial 2:");
            double Parcial2 = double.Parse(Console.ReadLine());//7

            double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + Parcial2 * 40 / 100;
            Console.WriteLine("la nota de C2 es : {0}", c2);


            
            Console.Write("LAB1:");
            double LAB1 = double.Parse(Console.ReadLine());//9

            Console.Write("LAB2:");
            double LAB2 = double.Parse(Console.ReadLine());//9

            Console.Write("Parcial 3:");
            double Parcial3 = double.Parse(Console.ReadLine());//3

            double C3 = lab1 * 30 / 100 + lab2 * 30 / 100 + Parcial3 * 40 / 100;
            Console.WriteLine("la nota de C3 es : {0}", C3);


            double NF = c1 + c2 + C3;
            Console.WriteLine("la nota de NF es: {0}",c1, c2, C3);

            //pausa
            Console.WriteLine();

            
        }
    }
}
