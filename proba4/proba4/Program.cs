using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba4
{
     class Program
    {
        static void Main(string[] args)
        {
            //vezba 1
            var sentence = "this is going to be a really really really really long sentence";
            var summerize = StringUtility.SummerizeText(sentence, 25);

            Console.WriteLine(summerize);
            

            //vezba 2
            Console.WriteLine("Enter an English word: ");
            var englishWord = Console.ReadLine();

            var vowelsCount = 0;
            var vowels = new List<char>(new char[] {'a','e','i','o','u'});

            foreach(char ch in englishWord)
            {
                if(vowels.Contains(ch))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
            

            //vezba 3
            var path = @"C:\Users\mila.bogovac\Documents\proba\test.txt";
            var wordsNum = new List<string>(File.ReadAllText(path).Split(' '));

            Console.WriteLine(wordsNum.Count());

            var longestWord = "";

            for(int i = 0; i <= wordsNum.Count - 1; i++)
            {
                if(wordsNum[i].Length > wordsNum[i+1].Length)
                {
                    longestWord = wordsNum[i];
                }
               
            }

            Console.WriteLine(longestWord);

        }

    }
}
