namespace JogosDosDadosConsoleApp
{
    /*Versão 1 - Estrutura básica e simulação de dados 
        Requisitos:

        Exibir um banner para o jogo de dados
        Implementar a geração de números aleatórios para simular um dado (1-6)
        Exibir o resultado do lançamento do dado
        Permitir que o usuário pressione Enter para lançar o dado
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                ExibirCabecalho();

                
                int resultado = LancarDado();

                
                ExibirResultadoSorteio(resultado);


                string opcaoContinuar = MenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }
            
        }

        static void ExibirCabecalho ()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo dos Dados!");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Pressione enter para lançar o dado....");
            Console.ReadLine();
        }

        static int LancarDado ()
        {
            Random geradordeNumeros = new Random();

            int resultado = geradordeNumeros.Next(1, 7);

            return resultado;
        }

        static void ExibirResultadoSorteio (int resultado)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"O valor sorteado foi: {resultado}");
            Console.WriteLine("------------------------------------------------");
        }

        static string MenuContinuar ()
        {
            Console.WriteLine("Deseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            return opcaoContinuar;
        }

            


    }
}
