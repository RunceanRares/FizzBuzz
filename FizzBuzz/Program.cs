﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzTDD fizzBuzz = new FizzBuzzTDD(); 
            //iteram pentru a afisa in consola
            for(int i=1;i<=100;i++)
            {
                string rezultat = fizzBuzz.Convert(i);
                Console.Write(rezultat + " ");
            }
            Console.ReadKey();
        }
    }
}
