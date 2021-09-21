using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double nombre1 = 0, nombre2 = 0, result = 0;
            bool calculatriceOn = true, nombreUnEstUnNombre = false, nombreDeuxEstUnNombre = false;


            while (calculatriceOn)
            {
                while (!nombreUnEstUnNombre)
                {
                    Console.Write("Nombre 1 : ");
                    nombreUnEstUnNombre = Double.TryParse(Console.ReadLine(), out nombre1);
                    if (!nombreUnEstUnNombre) { Console.WriteLine("L'entrée n'est pas valide"); }
                }
                while (!nombreDeuxEstUnNombre)
                {
                    Console.Write("Nombre 2 : ");
                    nombreDeuxEstUnNombre = Double.TryParse(Console.ReadLine(), out nombre2);
                    if (!nombreDeuxEstUnNombre) { Console.WriteLine("L'entrée n'est pas valide"); }
                }

                Console.Write("Qu'elle opération choisissez vous entre addition, division, multiplication ou soustraction : ");
                string operationChoisie = Console.ReadLine().ToLower();

                if (operationChoisie == "addition")
                {
                    result = add(nombre1, nombre2);
                    Console.WriteLine(nombre1 + " + " + nombre2 + " = " + result);
                }
                else if (operationChoisie == "soustraction")
                {
                    result = soustrait(nombre1, nombre2);
                    Console.WriteLine(nombre1 + " - " + nombre2 + " = " + result);
                }
                else if (operationChoisie == "multiplication" )
                {
                    result = multiplie(nombre1, nombre2);
                    Console.WriteLine(nombre1 + " x " + nombre2 + " = " + result);
                }
                else if (operationChoisie == "division")
                {
                    result = divise(nombre1, nombre2);
                    Console.WriteLine(nombre1 + " x " + nombre2 + " = " + result);
                }
                else { Console.WriteLine("L'opération choisie n'est pas répertoriée"); }

                Console.WriteLine("Voulez-vous continuer ? (si non appuyer sur q)");
                string continuer = Console.ReadLine().ToLower();
                if (continuer == "q") { calculatriceOn = false; }
                nombreUnEstUnNombre = false;
                nombreDeuxEstUnNombre = false;
            }
        }


        //definition des fonctions
        static double add(double nombre1, double nombre2) 
        {
            return nombre1 + nombre2;
        }
        static double multiplie(double nombre1, double nombre2)
        {
            return nombre1 + nombre2;
        }
        static double divise(double nombre1, double nombre2)
        {
            return nombre1 + nombre2;
        }
        static double soustrait(double nombre1, double nombre2)
        {
            return nombre1 + nombre2;
        }
        static double soustrait(double nombre1, double nombre2)
        {
            return nombre1 + nombre2;
        }

    }
}