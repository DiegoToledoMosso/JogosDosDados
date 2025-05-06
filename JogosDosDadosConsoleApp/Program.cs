namespace JogosDosDadosConsoleApp
{
    
    internal class Program
    {
                
        public static int limiteLinhaChegada = 30;

        static void Main(string[] args)
        {            

            while (true)
            {
                               
                bool jogoEstaEmAndamento = true;


                while (jogoEstaEmAndamento)
                {
                    bool usuarioVenceu = Usuario.ExecutarRodada();                   

                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();
                                      
                    bool computadorVenceu = Computador.ExecutarRodada();

                    if (usuarioVenceu || computadorVenceu)
                        jogoEstaEmAndamento = false;


                    Console.WriteLine("------------------------------");

                    Console.Write("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                string opcaoContinuar = MenuContinuar();

                if (opcaoContinuar != "S")
                    break;
            }

        }                             

        static string MenuContinuar()
        {
            Console.WriteLine("Deseja continuar? (S/N) ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            return opcaoContinuar;
        }

    }
}