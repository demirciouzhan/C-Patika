using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inplicit
            Console.WriteLine("Hello World!");

            byte b = 150;

            short s = b;

            int i = s + b;

            long a = b;

            //Explicit

            long al = 30000;
            int t = (int)al;

            short er =36;
            short es = (short)er;

            string kalem = "400";

            short c= Convert.ToInt16(kalem);

            int cu = Convert.ToInt32("300");
        }
    }
}