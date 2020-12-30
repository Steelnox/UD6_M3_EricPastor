using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M3
{
    public class Milestone2
    {
        public void Notas()
        {
            int[,] notas_array = new int[5, 3];
            int media = 0;

            for (int i = 0; i < notas_array.GetLength(0); i++)
            {
                for (int j = 0; j < notas_array.GetLength(1); j++)
                {
                    if (j == 0) Console.WriteLine("ALUMNO NUEVO");
                    Console.WriteLine("Dame la nota {0} del alumno {1}", i, j);
                    notas_array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < notas_array.GetLength(0); i++)
            {
                media = 0;
                for (int j = 0; j < notas_array.GetLength(1); j++)
                {
                    media += notas_array[i, j];
                    if(j == notas_array.GetLength(1) - 1)
                    {
                        media /= notas_array.GetLength(1);

                        if (media >= 5)
                        {
                            Console.WriteLine("El alumno {0} tiene una media de {1} y HA APROBADO", i, media);
                        }

                        else
                        {
                            Console.WriteLine("El alumno {0} tiene una media de {1} y HA SUSPENDIDO", i, media);
                        }
                    }
                }
            }
        }
    }
}
