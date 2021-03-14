using System;

namespace C_Sharp_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "this is a sentence this is a sentence this is a sentence";
          
            var summary =stringutility.summarizetext(sentence, 25);
            Console.WriteLine(summary);

            }

          
        }


    }
}
