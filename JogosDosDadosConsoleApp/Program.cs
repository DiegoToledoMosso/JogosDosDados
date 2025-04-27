namespace JogosDosDadosConsoleApp
{
    /*Versão 3 - Incluir o computador como oponente 
        Requisitos:

        Informar que o computador está jogando
        Armazenar a posição do computador na pista e atualizar o valor após o lançamento do dado
        Atualizar a posição do computador após seu lançamento de dado
        Exibir mensagens informativas quando os eventos ocorrerem
        Atualizar a posição do jogador conforme as regras dos eventos
        Exibir a nova posição
        Verificar se o computador alcançou ou ultrapassou a linha de chegada
        Informar quem venceu o jogo
        Implementar turnos alternados entre jogador e computador
    */
    internal class Program
    {
        static void Main(string[] args)
        {

            const int limiteLinhaChegada = 30;
            

            
            while (true)
            {
                
                int posicaoUsario = 0;
                int posicaoComputador = 0;

                bool jogoEstaEmAndamento = true;


                while (jogoEstaEmAndamento)
                {
                    //turno usuario
                    //--------------------------------------------------------------------------
                    ExibirCabecalho("Usuário");


                    int resultado = LancarDado();


                    ExibirResultadoSorteio(resultado);

                    posicaoUsario += resultado;

                    Console.WriteLine("------------------------------------------------");

                    if (posicaoUsario >= limiteLinhaChegada)
                    {
                        Console.WriteLine("Parabéns você alcançou a linha de chegada!!");
                        Console.ReadLine();
                        jogoEstaEmAndamento = false;
                        continue;
                    }                                         

                    else
                        Console.WriteLine($"O jogador está na posição: {posicaoUsario} de {limiteLinhaChegada}");


                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();




                    //turno computador
                    //--------------------------------------------------------------------------
                    ExibirCabecalho("Computador");


                    int resultadoComputador = LancarDado();


                    ExibirResultadoSorteio(resultadoComputador);

                    posicaoComputador += resultadoComputador;

                    Console.WriteLine("------------------------------------------------");

                    if (posicaoComputador >= limiteLinhaChegada)
                    {
                        Console.WriteLine("Que pena !! O computador alcançou a linha de chegada!!");
                        jogoEstaEmAndamento = false;
                        Console.ReadLine();

                        continue;
                    }

                    else
                        Console.WriteLine($"O jogador está na posição: {posicaoComputador} de {limiteLinhaChegada}");


                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();



                }             

                string opcaoContinuar = MenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }
            
        }

        static void ExibirCabecalho (string nomeJogador)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Jogo dos Dados!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Turno do(a):  {nomeJogador}");
            Console.WriteLine("------------------------------------------------");

            if (nomeJogador != "Computador")
            {
                Console.WriteLine("Pressione enter para lançar o dado....");
                Console.ReadLine();
            }

            
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
