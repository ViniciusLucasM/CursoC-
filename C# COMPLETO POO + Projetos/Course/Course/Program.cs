namespace tiposbasicosdedados {
    class TiposBasicosDeDados {
        static void Main(string[] args) {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine("-------------------------");

            int i1 = int.MinValue;
            int i2 = int.MaxValue;
            sbyte s1 = sbyte.MinValue;
            sbyte s2 = sbyte.MaxValue;
            decimal d1 = decimal.MinValue;
            decimal d2 = decimal.MaxValue;

            Console.WriteLine(i1);
            Console.WriteLine(i2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}