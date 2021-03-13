using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {

            var datetime = new DateTime();
            var now = DateTime.Now;
            var today = DateTime.Today;
            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);
            //Console.WriteLine(today.Hour);
            //Console.WriteLine(today.Day);
            //Console.WriteLine(today.Month);

            var tommorow = now.AddDays(1);
            Console.WriteLine(tommorow);

            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString());
            

           
        }

            }
          
            }





        
    

