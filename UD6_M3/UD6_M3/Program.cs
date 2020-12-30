using System;

namespace UD6_M3
{
    class Program
    {
        static void Main(string[] args)
        {
            Milestone1 m1 = new Milestone1();

            string opcion = "";

            Console.WriteLine("Escribe una opcion entre la 1 y la 3");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    m1.Principal();
                    break;
                default:
                    Console.WriteLine("No es una opcion correcta. Vuelve a intentarlo más tarde");
                    break;
            }
        }
    }
}
