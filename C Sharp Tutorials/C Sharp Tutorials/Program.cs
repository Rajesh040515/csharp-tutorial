using System;

namespace C_Sharp_Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var firstname = "rajesh patel";
            Console.WriteLine(firstname.Trim());
            Console.WriteLine(firstname.Trim().ToUpper());

            var index = firstname.IndexOf("rajesh");
            var fname = firstname.Substring(0, index);
            var lname = firstname.Substring(index + 1);
            Console.WriteLine("fname" + fname);
            Console.WriteLine("lname " + lname);

            var names = firstname.Split(' ');
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);

            var rename = firstname.Replace();
            Console.WriteLine("Replace name :" + rename);

            var str = "21";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age is" + age);

            double price = 10.234;
            Console.WriteLine(price.ToString("C"));

        }
    }
}
