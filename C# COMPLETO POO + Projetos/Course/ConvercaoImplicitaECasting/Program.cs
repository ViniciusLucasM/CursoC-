﻿namespace ConvercaoImplicitaECasting {
    class ConvercaoImplicitaECasting {
        static void Main(string[] args) {
            //Essa é uma conversão implicita de float para double
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);
            Console.WriteLine("-----------");

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);
            Console.WriteLine("------------");

            double c;
            int d;

            c = 5.1;
            d = (int)a;
            Console.WriteLine(d);
            Console.WriteLine("-------------");

            int e = 5;
            int f = 2;

            double resultado = (double) e / f;
            Console.WriteLine(resultado);
        }
    }
}