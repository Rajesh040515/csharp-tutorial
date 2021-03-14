using System;
using System.Collections.Generic;

namespace C_Sharp_Tutorials
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sentence = "This is going to be really really really really really long text";
            var summary = stringutility.SummerizeText(sentence, 30);
            Console.WriteLine(summary);

        }

    } }

