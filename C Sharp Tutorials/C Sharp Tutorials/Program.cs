using System;

using System.Text;


namespace C_Sharp_Tutorials
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = new StringBuilder("helloworld");
            builder.Append('-', 10);
            builder
            .AppendLine()
            .Append("name")
            .AppendLine()
            .Append('*', 10)
            .Replace('-', '+')
            .Remove(0,5)
            .Insert(0, new string('-', 5));
            Console.WriteLine(builder);
            Console.WriteLine( "char "+builder[5]);
                

            
        }

    } }

