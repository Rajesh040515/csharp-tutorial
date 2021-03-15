using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace C_Sharp_Tutorials
{
    class Program
    {
        public static void Main(string[] args)
        {
          var fibonacci=new List<int> { 1,1};

            while(fibonacci.count<20)
            {
                var previous= fibonacci.Count-1;
                var previous1= fibonacci.Count-2;
                var add=(previous+previous1);


            }
            Console.WriteLine(add);
        }

    } }

