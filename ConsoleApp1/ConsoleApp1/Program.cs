using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new[] { 1, 2, 3, 4, 5 };

            //array length
            Console.WriteLine("length"+ number.Length);
            
            //index number find
            var index = Array.IndexOf(number, 2);
            Console.WriteLine(index);

            //clear
            Array.Clear(number, 1, 2);
            Console.WriteLine("clear()");
            foreach(var n in number)
                Console.WriteLine(n);
            //copy
            int[] another = new int[3];
            Array.Copy(number, another, 3);
            Console.WriteLine("copy");
            foreach (var i in another) Console.WriteLine(i);

            Array.Sort(another);
            Console.WriteLine("sort");
            foreach(var k in another)
                Console.WriteLine(k);


            

        
        }
    }
}
