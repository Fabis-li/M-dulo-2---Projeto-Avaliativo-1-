namespace DevCar
{
    public static class MenuScreen
    {
        public static void Iniciar()
        {
            Console.Clear();
            TituloDaTela();
            ExibirOpcoes();

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("Digite a opcao: ");
        }
    }
}