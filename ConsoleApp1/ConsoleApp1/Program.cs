using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = new List<int>() { 1, 2, 3 };
            num.Add(7);
            num.AddRange(new int[3] { 4, 5, 6 });
            foreach (var i in num)
                Console.WriteLine(i);


            Console.WriteLine( "count"+num.Count);

            num.Remove(1);
            foreach(var r in num)
                Console.WriteLine("remove:"+r);
            num.Clear();
        

        
        }
    }
}
