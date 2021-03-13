using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            //    for (var i = 0;i<= 10; i++)
            //    Console.WriteLine(random.Next(1,10));
            var buffer = new char[10];
            for(var i = 0; i < 8; i++)
            {
                buffer[i]=(char)("a" + random.Next(1,10));
            var password = new string(buffer);
            Console.WriteLine(password);
            }

            }
          
            }





        }
    

