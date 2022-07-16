using DevCar.Screen;
using DevCar.Repositories;

namespace DevCar
{
    public static class MenuScreen
    {
        public static void Iniciar(VeiculosRepository repository)
        {
            Console.Clear();
            TituloDaTela();
            ExibirOpcoes();

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CadastrarVeiculoScreen.Iniciar(repository);break;
                case 2: ListaVeiculosScreen.Iniciar(repository);break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Environment.Exit(0); break;
            }

            Console.ReadLine();              

        }

        static void TituloDaTela()
        {
            Console.WriteLine("Seja bem vindo ao DevCar 1.0");
                for(int i = 0; i<=35; i ++)
                    Console.Write("-");
            Console.WriteLine();
                
        }

        static void ExibirOpcoes()
        {
            Console.WriteLine("1 - Cadastro de veiculos");
            Console.WriteLine("2 - Listar Veiculos");
            Console.WriteLine("3 - Carros Disponiveis");
            Console.WriteLine("4 - Carros Vendidos");
            Console.WriteLine("5 - Histórico de Transferencia");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            Console.WriteLine("Digite a opcao: ");
        }
    }
}