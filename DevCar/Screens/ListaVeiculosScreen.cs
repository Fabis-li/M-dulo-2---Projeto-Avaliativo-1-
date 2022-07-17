using DevCar.Models;
using DevCar.Repositories;


namespace DevCar.Screen
{
    public static class ListaVeiculosScreen
    {
        public static void Iniciar(VeiculosRepository repository)
        {
            Console.Clear();
            Console.WriteLine("Lista de Veiculo");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto e Triciculo");
            Console.WriteLine("3 - Caminhonete");
            Console.WriteLine("4 - Todos");
            Console.WriteLine("0 - Voltar ao menu Iniciar");

            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: CarroModel(repository);break;
                case 2: MotoTriciculoModel(repository); break;
                case 3: CaminhoneteModel(repository);break;
                case 4: ListarTudo(repository);break;
                case 0: MenuScreen.Iniciar(repository);break;
                default: break;
            }
            Console.ReadKey();
        }                   
            static void CarroModel(VeiculosRepository repository)            
            {
                Console.Clear();
                Console.WriteLine("Lista de Carro");
                Console.WriteLine("------------------------------");
                Console.WriteLine(Environment.NewLine);

                if(repository.ListaDeVeiculos.Count == 0)
                {
                    Console.WriteLine("Não há veiculos na lista!");
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }
                else
                {
                    foreach (CarroModel carro in repository.ListaDeVeiculos)
                    {
                        Console.WriteLine(carro.ListarInformacoes());

                        Console.WriteLine("------------------------------");
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }                                 
                    
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }          
            }
            
            static void MotoTriciculoModel(VeiculosRepository repository)
            {
                Console.Clear();
                Console.WriteLine("Lista de Moto | Triciculo");
                Console.WriteLine("--------------------------");
                Console.WriteLine(Environment.NewLine);

                if(repository.ListaDeVeiculos.Count == 0)
                {
                    Console.WriteLine("Não há veiculos na lista!");
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }
                else
                {
                    foreach (MotoTriciculoModel motoTriciculo in repository.ListaDeVeiculos)
                    {
                        Console.WriteLine(motoTriciculo.ListarInformacoes());

                        Console.WriteLine("------------------------------");
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }                                     
                    
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }              
                
            }

            static void CaminhoneteModel(VeiculosRepository repository)
            {
                Console.Clear();
                Console.WriteLine("Lista de Caminhonete");
                Console.WriteLine("-------------------------------");
                Console.WriteLine(Environment.NewLine);

                if(repository.ListaDeVeiculos.Count == 0)
                {
                    Console.WriteLine("Não há veiculos na lista!");
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }
                else
                {
                    foreach (CaminhoneteModel caminhonete in repository.ListaDeVeiculos)
                    {
                        Console.WriteLine(caminhonete.ListarInformacoes());

                        Console.WriteLine("------------------------------");
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }                                    
                    
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }         
                
            }

            static void ListarTudo(VeiculosRepository repository)
            {              
                Console.Clear();
                Console.WriteLine("Lista de Veiculos");
                Console.WriteLine("--------------------");
                Console.WriteLine(Environment.NewLine);

                if(repository.ListaDeVeiculos.Count == 0)
                {
                    Console.WriteLine("Não há veiculos na lista!");
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }
                else
                {
                    foreach ( VeiculoModel veiculos in repository.ListaDeVeiculos)
                    {
                        Console.WriteLine(veiculos.ListarInformacoes());

                        Console.WriteLine("----------------------------");
                    }
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                    Console.ReadLine();
                }                                
                    
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }
                
            }
    }
}

            
                  

            
    
