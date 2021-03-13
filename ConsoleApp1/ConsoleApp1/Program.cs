using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {

            var timespan = new TimeSpan(10,15,30);
            var timespan1 = new TimeSpan();
            var timespan2 = TimeSpan.FromHours(1);
            var strt = DateTime.Now;
            var end = DateTime.Now.AddMinutes(10);
            var duration = strt - end;
            Console.WriteLine(duration);



           
        }

            }
          
            }





        
    

