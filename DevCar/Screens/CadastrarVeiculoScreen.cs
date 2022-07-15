using DevCar.Models;
using DevCar.Repositories;

namespace DevCar.Screen
{
    

    public static class CadastrarVeiculoScreen
    {    
        public static void Iniciar()
        {       

            Console.Clear();
            Console.WriteLine("Cadastro de Veiculo");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto e Triciculo");
            Console.WriteLine("3 - Caminhonete");
            

            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: CarroModel();break;
                case 2: MotoTriciculoModel(); break;
                case 3: CaminhoneteModel();break;
                case 4: break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Iniciar(); break;
            }

        
           static void CarroModel()
            {
                var carro = new CarroModel();
                Console.WriteLine("Cadastrar Carro");
                Console.WriteLine("Número do Chassi");
                carro.NumeroChassi = Guid.NewGuid().ToString().Substring(0, 17);
                Console.WriteLine("Nome do Carro: ");
                carro.NomeVeiculo = Console.ReadLine();
                Console.WriteLine("Digite a Placa do Carro");
                carro.Placa = Console.ReadLine();                
                Console.WriteLine("Ano de Fabricação: ");
                carro.DataFabricacao = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Quantidade de Portas: ");
                carro.TotalDePortas = int.Parse(Console.ReadLine());
                Console.WriteLine("Tipo de Combustivel - Flex ou Gasolina");
                carro.TipoCombustivel = Console.ReadLine();
                Console.WriteLine("Potência do Motor: ");
                carro.PotenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("Cor da Carro: ");
                carro.Cor = Console.ReadLine();
                Console.WriteLine("Valor R$: ");
                carro.Valor = double.Parse(Console.ReadLine());
                VeiculosRepository.ListaDeVeiculos.Add(new CarroModel(carro.DataFabricacao, carro.NomeVeiculo, carro.Placa, carro.Valor, carro.Cor, carro.TotalDePortas, carro.TipoCombustivel, carro.PotenciaMotor));
                Console.WriteLine("Carro cadastrado com sucesso");

            }

            static void MotoTriciculoModel()
            {
                var moto = new MotoTriciculoModel();
                 Console.WriteLine("Cadastrar Carro");
                Console.WriteLine("Número do Chassi");
                moto.NumeroChassi = Guid.NewGuid().ToString().Substring(0, 17);
                Console.WriteLine("Nome do Carro: ");
                moto.NomeVeiculo = Console.ReadLine();
                Console.WriteLine("Digite a Placa do Carro");
                moto.Placa = Console.ReadLine();                
                Console.WriteLine("Ano de Fabricação: ");
                moto.DataFabricacao = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Quantidade de Rodas: ");
                moto.QtdeRodas = int.Parse(Console.ReadLine());                
                Console.WriteLine("Potência do Motor: ");
                moto.PotenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("Cor da Moto/Triciculo: ");
                moto.Cor = Console.ReadLine();
                Console.WriteLine("Valor R$: ");
                moto.Valor = double.Parse(Console.ReadLine());
                VeiculosRepository.ListaDeVeiculos.Add(new MotoTriciculoModel(moto.DataFabricacao, moto.NomeVeiculo, moto.Placa, moto.Valor, moto.Cor, moto.QtdeRodas, moto.PotenciaMotor));
                Console.WriteLine("Moto cadastrado com sucesso");

            }
            static void CaminhoneteModel()
            {
                var caminhonete = new CaminhoneteModel();
            }
        
        
        }
        
    }
}