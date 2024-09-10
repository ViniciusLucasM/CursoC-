namespace Exercicio04_Estrutura_Condicional {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a hora inicial e hora final do jogo: ");
            string[] input = Console.ReadLine().Split(' ');

            int horaInicio = int.Parse(input[0]);
            int horaFinal = int.Parse(input[1]);
            int duracao;

            if (horaInicio < horaFinal) {
                duracao = horaFinal - horaInicio;
            }
            else
            {
                duracao = 24 - horaInicio + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS(S)");
        }
    }
}
