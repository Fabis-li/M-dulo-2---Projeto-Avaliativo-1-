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
            Console.WriteLine("0 - Voltar ao menu Iniciar");

            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: CarroModel(repository);break;
                case 2: MotoTriciculoModel(repository); break;
                case 3: CaminhoneteModel(repository);break;
                case 4: break;
                case 0: MenuScreen.Iniciar(repository);break;
                default: break;
            }
            Console.ReadKey();
        }       


            
             static void CarroModel(VeiculosRepository repository)            
            {
                foreach (var carro in repository.ListaDeVeiculos)
                {
                    Console.WriteLine("Lista de Carro");
                    Console.WriteLine("--------------");
                    Console.WriteLine();
                    Console.WriteLine($" Nome do Carro: {carro.NomeVeiculo}");
                }               
            
               
               
            }
            static void MotoTriciculoModel(VeiculosRepository repository)
            {

            }
            static void CaminhoneteModel(VeiculosRepository repository)
            {

            }

        
    }
}