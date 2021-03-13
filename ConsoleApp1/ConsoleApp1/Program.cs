using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
       class Program
    {
        static void Main(string[] args)
        {

            //int i = 0;
            //while(i<=10)
            //{
            //    if(i % 2==0)
            //        {
            //        Console.WriteLine(i);
            //        i++;
            //    }

            while (true)
            {

                Console.Write("name here");
                var input = Console.ReadLine();
                Console.WriteLine(input);
                if (string.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine(" echo" +input);


            }
            }
          
            }





        }
    

