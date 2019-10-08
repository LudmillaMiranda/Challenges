using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLetter
{
    class Program
    {
        //Create a function that takes a word and returns true if the word has two consecutive identical letters.

        //Examples
        //DoubleLetters("loop") ➞ true

        //DoubleLetters("yummy") ➞ true

        //DoubleLetters("orange") ➞ false

        //DoubleLetters("munchkin") ➞ false
        public static bool DoubleLetters(string word)
        {                     
            int tamanho = word.Length;
            string resultado = "";

            for (int i = 0; i <tamanho; i++)
            {
                char letra = word[i];
                if (resultado.Contains(letra))
                {                    
                    return true;
                }
                else
                {
                    resultado += letra;
                }
            }
            return false;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine (DoubleLetters("orange"));
            Console.ReadKey();

        }
    }
}
