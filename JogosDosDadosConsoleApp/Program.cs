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

                Jogador usuario = new Jogador();
                usuario.nome = "Usuário";
                Jogador usuarioDois = new Jogador();
                usuarioDois.nome = "UsuárioDois";
                Jogador computador = new Jogador();
                computador.nome = "Computador";


                while (jogoEstaEmAndamento)
                {
                    bool usuarioVenceu = usuario.ExecutarRodada();                   

                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();

                    bool usuarioDoisVenceu = usuarioDois.ExecutarRodada();

                    Console.Write("Aperte ENTER se deseja continuar....");
                    Console.ReadLine();

                    bool computadorVenceu = computador.ExecutarRodada();

                    if (usuarioVenceu || computadorVenceu || usuarioDoisVenceu)
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