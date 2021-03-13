using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {
            /* int hour = 13;
             if(hour>0 && hour < 12)
             {
                 Console.WriteLine("morning");
             }

              else if (hour > 12 && hour < 18)
             {
                 Console.WriteLine("afternoon");
             }*/
            var season2 = season2.summer;
            switch(season2)
            {

                case season2.summer:
                        Console.WriteLine("summer" );
                    break;

                case season2.winter:
                    Console.WriteLine("winter");
                    break;

                default:
                    Console.WriteLine("autumn");
                    break;

            }





        }
    }
}
