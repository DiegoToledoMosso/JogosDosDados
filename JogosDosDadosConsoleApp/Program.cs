namespace JogosDosDadosConsoleApp
{
    /*Versão 2 - Controle da posição do jogador 
        Requisitos:

        Armazenar a posição do jogador na pista e atualizar o valor após o lançamento do dado
        Exibir a posição atual do jogador na pista
        Definir a linha de chegada em 30 verificar se o jogador alcançou ou ultrapassou a linha de chegada
        Permitir o jogador realizar várias jogadas
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            const int limiteLinhaChegada = 30;
            

            
            while (true)
            {
                
                int posicaoUsario = 0;
                bool jogoEstaEmAndamento = true;


                while (jogoEstaEmAndamento)
                {

                    ExibirCabecalho();


                    int resultado = LancarDado();


                    ExibirResultadoSorteio(resultado);

                    posicaoUsario += resultado;

                    Console.WriteLine("------------------------------------------------");

                    if (posicaoUsario >= limiteLinhaChegada)
                    {
                        Console.WriteLine("Parabéns você alcançou a linha de chegada!!");
                        jogoEstaEmAndamento = false;
                    }
                                          

                    else
                        Console.WriteLine($"O jogador está na posição: {posicaoUsario} de {limiteLinhaChegada}");


                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();
                }             

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
