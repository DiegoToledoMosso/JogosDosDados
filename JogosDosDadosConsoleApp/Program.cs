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

                    bool rodadaExtraUsuario;

                    do
                    {                        
                        rodadaExtraUsuario = false;

                        
                        ExibirCabecalho("Usuário");


                        int resultado = LancarDado();


                        ExibirResultadoSorteio(resultado);

                        posicaoUsario += resultado;

                        if (posicaoUsario == 5 || posicaoUsario == 10 || posicaoUsario == 15)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Evento Especial: Avanço Extra de 3 casas!");
                            Console.WriteLine("------------------------------------");

                            posicaoUsario += 3;
                            Console.WriteLine($"Nova posição {posicaoUsario}!");

                        }

                        else if (posicaoUsario == 7 || posicaoUsario == 13 || posicaoUsario == 20)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Evento Especial: Recuo de 2 casas!");
                            Console.WriteLine("------------------------------------");

                            posicaoUsario -= 2;
                            Console.WriteLine($"Nova posição {posicaoUsario}");
                        }

                        if (resultado == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Evento Especial: RODADA EXTRA");
                            Console.WriteLine("------------------------------------");

                            rodadaExtraUsuario = true;
                        }
                        else if (posicaoUsario >= limiteLinhaChegada)
                        {
                            Console.WriteLine("Parabéns você alcançou a linha de chegada!!");
                            Console.ReadLine();

                            jogoEstaEmAndamento = false;
                            continue;
                        }

                        else
                            Console.WriteLine($"O jogador está na posição: {posicaoUsario} de {limiteLinhaChegada}");

                        Console.WriteLine("-----------------------------------------");
                        

                    } while (rodadaExtraUsuario);

                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();

                    bool rodadaExtraComputador;

                    do
                    {
                        rodadaExtraComputador = false;

                        
                        ExibirCabecalho("Computador");


                        int resultadoComputador = LancarDado();


                        ExibirResultadoSorteio(resultadoComputador);

                        posicaoComputador += resultadoComputador;

                        if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Evento Especial: Avanço Extra de 3 casas!");
                            Console.WriteLine("------------------------------------");

                            posicaoComputador += 3;

                            Console.WriteLine($"Nova posição {posicaoComputador}");
                        }

                        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Evento Especial: Recuo de 2 casas!");
                            Console.WriteLine("------------------------------------");

                            posicaoComputador -= 2;
                            Console.WriteLine($"Nova posição {posicaoComputador}");
                        }

                        if (resultadoComputador == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("Evento Especial: RODADA EXTRA");
                            Console.WriteLine("------------------------------------");

                            rodadaExtraComputador = true;
                        }
                        else if (posicaoComputador >= limiteLinhaChegada)
                        {
                            Console.WriteLine("Parabéns você alcançou a linha de chegada!!");
                            Console.ReadLine();

                            jogoEstaEmAndamento = false;
                            continue;
                        }

                        else
                        {
                            Console.WriteLine($"O Computador está na posição: {posicaoComputador} de {limiteLinhaChegada}");
                            Console.ReadLine() ;
                        }
                            
                            

                        Console.WriteLine("-----------------------------------------");

                    } while (rodadaExtraComputador);                                     
                                                         

                    


                }             

                string opcaoContinuar = MenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }
            
        }

        static void ExibirCabecalho (string nomeJogador)
        {
            Console.Clear ();
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
