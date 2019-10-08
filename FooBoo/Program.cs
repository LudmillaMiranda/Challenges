using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program fooboo = new Program();
            fooboo.FooBoo();
            Console.ReadKey();
        }

        public void FooBoo()
        {
            for (int a = 0; a <= 10; a++)
            {
                if (a % 2 == 1)
                {
                    Console.WriteLine ("Boo");

                }
                else
                    Console.WriteLine("Foo");
                }
            }
        
    }
}
