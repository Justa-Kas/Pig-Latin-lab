using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word for the pig latin converter.");
            string wordGiven = Console.ReadLine();
            
            Console.WriteLine(PigLatinConverter(wordGiven));
            Console.ReadKey();
        }
        public static string PigLatinConverter(string takeWord)
        {
            takeWord=takeWord.ToLower();
            TakeWord=takeWord.Trim();
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u'};
            foreach (char v in vowels)
            {
                if (takeWord[0] == v)
                {
                    return takeWord + "way";

                }
            }
            for (int i = 0; i < takeWord.Length; i++)
            {
                foreach (char v in vowels)
                {
                    if (takeWord[i] == v)
                    {
                        string translateP1 = takeWord.Substring(0, i);
                        string translateP2 = takeWord.Substring(i);
                        return translateP2 + translateP1 + "ay";

                    }
                }
            }
            return "Word has no vowel";


        }
    }
}





