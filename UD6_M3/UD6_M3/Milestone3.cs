using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M3
{
    public class Milestone3
    {
        public void Fibonacci()
        {
            int longitud_Fibo = 0;
            Console.WriteLine("Escribe la longitud del Fibonacci");
            longitud_Fibo = Convert.ToInt32(Console.ReadLine());

            int[] array_Fibo = new int[longitud_Fibo];
            
            for (int i = 0; i < array_Fibo.Length; i++)
            {
                if (i == 0) array_Fibo[i] = 0;
                else if (i == 1) array_Fibo[i] = 1;
                else
                {
                    array_Fibo[i] = array_Fibo[i - 1] + array_Fibo[i - 2];
                }

                if (i == array_Fibo.Length - 1) Console.WriteLine(array_Fibo[i]);
                else
                {
                    Console.Write(array_Fibo[i] + ", ");
                }
            }
        }
    }
}
