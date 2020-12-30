using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M3
{
    public class Milestone1
    {
        public void Principal()
        {
            string ciudad1 = "";
            string ciudad2 = "";
            string ciudad3 = "";
            string ciudad4 = "";
            string ciudad5 = "";
            string ciudad6 = "";

            
            Console.WriteLine("------------FASE 1---------");
            Console.WriteLine("Escribe el nombre de la ciudad 1");
            ciudad1 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 2");
            ciudad2 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 3");
            ciudad3 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 4");
            ciudad4 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 5");
            ciudad5 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la ciudad 6");
            ciudad6 = Console.ReadLine();

            Console.WriteLine("El nombre de las 6 ciudades es {0}, {1}, {2}, {3}, {4}, {5}", ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6);
        
            Console.WriteLine("------------FASE 2---------");
            string[] arrayCiudades = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };
            Array.Sort(arrayCiudades);

            for (int i = 0; i < arrayCiudades.Length; i++)
            {
                Console.WriteLine(arrayCiudades[i]);
            }

            Console.WriteLine("------------FASE 3---------");
            string[] arrayCiudadesModificadas = new string[arrayCiudades.Length];
            for (int i = 0; i < arrayCiudades.Length; i++)
            {
                arrayCiudadesModificadas[i] = arrayCiudades[i].Replace('a', '4');
                Console.WriteLine(arrayCiudadesModificadas[i]);
            }

            Console.WriteLine("------------FASE 4---------");
            string[] arrayCiudad1 = new string[ciudad1.Length];
            string[] arrayCiudad2 = new string[ciudad2.Length];
            string[] arrayCiudad3 = new string[ciudad3.Length];
            string[] arrayCiudad4 = new string[ciudad4.Length];
            string[] arrayCiudad5 = new string[ciudad5.Length];
            string[] arrayCiudad6 = new string[ciudad6.Length];

            for (int i = 0; i < arrayCiudad1.Length; i++)
            {
                arrayCiudad1[i] = ciudad1.Substring(i,1);
            }
            for (int i = 0; i < arrayCiudad2.Length; i++)
            {
                arrayCiudad2[i] = ciudad2.Substring(i, 1);
            }
            for (int i = 0; i < arrayCiudad3.Length; i++)
            {
                arrayCiudad3[i] = ciudad3.Substring(i, 1);
            }
            for (int i = 0; i < arrayCiudad4.Length; i++)
            {
                arrayCiudad4[i] = ciudad4.Substring(i, 1);
            }
            for (int i = 0; i < arrayCiudad5.Length; i++)
            {
                arrayCiudad5[i] = ciudad5.Substring(i, 1);
            }
            for (int i = 0; i < arrayCiudad6.Length; i++)
            {
                arrayCiudad6[i] = ciudad6.Substring(i, 1);
            }

            Array.Reverse(arrayCiudad1);
            Array.Reverse(arrayCiudad2);
            Array.Reverse(arrayCiudad3);
            Array.Reverse(arrayCiudad4);
            Array.Reverse(arrayCiudad5);
            Array.Reverse(arrayCiudad6);

            for (int i = 0; i < arrayCiudad1.Length; i++)
            {
                Console.Write(arrayCiudad1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCiudad2.Length; i++)
            {
                Console.Write(arrayCiudad2[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCiudad3.Length; i++)
            {
                Console.Write(arrayCiudad3[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCiudad4.Length; i++)
            {
                Console.Write(arrayCiudad4[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCiudad5.Length; i++)
            {
                Console.Write(arrayCiudad5[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arrayCiudad6.Length; i++)
            {
                Console.Write(arrayCiudad6[i]);
            }
            Console.WriteLine();
        }
    }
}
