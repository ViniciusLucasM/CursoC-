using System.Globalization;

namespace Exercicio06_Estrutura_Sequencial {
    internal class Program {
        static void Main(string[] args) {

            float A, B, C;
            double pi;
            double triangulo, circulo, trapezio, quadrado, retangulo;
            string[] vet = Console.ReadLine().Split(' ');
            
            A = float.Parse(vet[0].Replace(',', '.'), CultureInfo.InvariantCulture);
            B = float.Parse(vet[1].Replace(',', '.'), CultureInfo.InvariantCulture);
            C = float.Parse(vet[2].Replace(',', '.'), CultureInfo.InvariantCulture);
            pi = 3.14159;

            triangulo = (A * C) / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = (A + B) * C / 2;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: {0}\nCIRCULO: {1}\nTRAPEZIO: {2}\nQUADRADO: {3}\nRETANGULO: {4}", 
                triangulo.ToString("F3", CultureInfo.InvariantCulture),
                circulo.ToString("F3", CultureInfo.InvariantCulture),
                trapezio.ToString("F3", CultureInfo.InvariantCulture),
                quadrado.ToString("F3", CultureInfo.InvariantCulture),
                retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
