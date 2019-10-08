using System;

namespace Area_of_a_Triangle
{
    class Triangulo
    {
        public static int triArea(int b, int h)
        {
            int area;
            area = (b * h) / 2;
            return area;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Forneca a base do triangulo: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Forneca a altura do triangulo: ");
                int h =  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A sua area é: " + triArea(b, h));
                Console.ReadKey();
            }
            catch (Exception geral)
            {
                Console.Write(geral.Message);
            }
        }
    }
}
