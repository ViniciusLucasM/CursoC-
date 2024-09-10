namespace Funcoes {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números inteiros: ");
            string[] input = Console.ReadLine().Split(' ');

            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            double resultado = Maior(A, B, C);


            Console.WriteLine("Maior: " + resultado);

            /*
            if (A > B && A > C) {
                Console.WriteLine("Maior: " + A);
            } else if (B > C) {
                Console.WriteLine("Maior: " + B);
            } else {
                Console.WriteLine("Maior: " + C);
            }
            */


        }

        static int Maior(int A, int B, int C) {
            int m;
        
            if (A > B && A > C) {
                m = A;
            } else if (B > C) {
                m = B;
            } else {
                m = C;
            }

            return m;
        }
    }
}
