using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialRecuperatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largo, ancho, altura, Ab, Ah, Aa, areaTotal, volumen;
            double diagonal;
            int cantidadPrismas = 0;

            Console.WriteLine("Cálculo de Prismas Rectangulares Rectos");

            do
            {
                Console.Write("Ingrese el valor del largo: ");
                largo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor del ancho: ");
                ancho = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor de la altura: ");
                altura= int.Parse(Console.ReadLine());

                if (largo != 0)
                {
                    Console.Write("Ingrese el valor del ancho: ");
                    ancho = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el valor de la altura: ");
                    altura = int.Parse(Console.ReadLine());

                    Ab = largo * ancho;
                    Ah = altura * ancho;
                    Aa = altura * largo;
                    areaTotal = 2 * (Ab + Ah + Aa);
                    volumen = largo * ancho * altura;
                    diagonal = Math.Sqrt(Math.Pow(largo, 2) + Math.Pow(ancho, 2) + Math.Pow(altura, 2));

                    Console.WriteLine("Área de la base: " + Ab);
                    Console.WriteLine("Área de la altura: " + Ah);
                    Console.WriteLine("Área del ancho: " + Aa);
                    Console.WriteLine("Área total: " + areaTotal);
                    Console.WriteLine("Volumen: " + volumen);
                    Console.WriteLine("Diagonal: " + diagonal);

                    cantidadPrismas++;
                }

            } while (largo != 0 && ancho != 0 && altura != 0);

            Console.WriteLine("Proceso finalizado.");
            Console.WriteLine("Cantidad de prismas ingresados: " + cantidadPrismas);
        }
    }
}
