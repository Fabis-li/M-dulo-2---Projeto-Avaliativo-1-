using System.Globalization;
using DevCar.Models;
using DevCar.Repositories;

namespace DevCar.Screen
{
    

    public static class CadastrarVeiculoScreen
    {    
        public static void Iniciar(VeiculosRepository repository)
        {       

            Console.Clear();
            Console.WriteLine("Cadastro de Veiculo");
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
                var carro = new CarroModel();
                Console.WriteLine();
                Console.WriteLine("Cadastrar Carro");
                Console.WriteLine("---------------");             
                Console.WriteLine("Nome do Carro: ");
                carro.NomeVeiculo = Console.ReadLine();
                Console.WriteLine("Digite a Placa do Carro: ");
                carro.Placa = Console.ReadLine();                
                Console.WriteLine("Ano de Fabricação (dd/MM/aaaa): ");
                carro.DataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                Console.WriteLine("Quantidade de Portas: ");
                carro.TotalDePortas = int.Parse(Console.ReadLine());
                Console.WriteLine("Tipo de Combustivel - Flex ou Gasolina: ");
                carro.TipoCombustivel = Console.ReadLine();
                Console.WriteLine("Potência do Motor: ");
                carro.PotenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("Cor da Carro: ");
                carro.Cor = Console.ReadLine();
                Console.WriteLine("Valor R$: ");
                carro.Valor = decimal.Parse(Console.ReadLine());
                repository.ListaDeVeiculos.Add(new CarroModel(carro.DataFabricacao, carro.NomeVeiculo, carro.Placa, carro.Valor, carro.Cor, carro.TotalDePortas, carro.TipoCombustivel, carro.PotenciaMotor));
                Console.WriteLine("Carro cadastrado com sucesso");
                Console.WriteLine();
                Console.WriteLine("Precione enter para voltar ao menu");
               
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }
            }

            static void MotoTriciculoModel(VeiculosRepository repository)
            {
                var moto = new MotoTriciculoModel();
                Console.WriteLine("Cadastrar Carro");                
                Console.WriteLine("Nome do Carro: ");
                moto.NomeVeiculo = Console.ReadLine();
                Console.WriteLine("Digite a Placa do Carro");
                moto.Placa = Console.ReadLine();                
                Console.WriteLine("Ano de Fabricação (dd/MM/aaaa): ");
                moto.DataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                Console.WriteLine("Quantidade de Rodas: ");
                moto.QtdeRodas = int.Parse(Console.ReadLine());                
                Console.WriteLine("Potência do Motor: ");
                moto.PotenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("Cor da Moto/Triciculo: ");
                moto.Cor = Console.ReadLine();
                Console.WriteLine("Valor R$: ");
                moto.Valor = decimal.Parse(Console.ReadLine());
                repository.ListaDeVeiculos.Add(new MotoTriciculoModel(moto.DataFabricacao, moto.NomeVeiculo, moto.Placa, moto.Valor, moto.Cor, moto.QtdeRodas, moto.PotenciaMotor));
                Console.WriteLine("Moto cadastrado com sucesso");
                Console.WriteLine();
                Console.WriteLine("Precione enter para voltar ao menu");
               
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }

            }

            static void CaminhoneteModel(VeiculosRepository repository)
            {
                var caminhonete = new CaminhoneteModel();
                Console.WriteLine("Cadastrar Carro");                
                Console.WriteLine("Nome do Carro: ");
                caminhonete.NomeVeiculo = Console.ReadLine();
                Console.WriteLine("Digite a Placa do Carro");
                caminhonete.Placa = Console.ReadLine();                
                Console.WriteLine("Ano de Fabricação (dd/MM/aaaa): ");
                caminhonete.DataFabricacao = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                Console.WriteLine("Quantidade de Rodas: ");
                caminhonete.TotalPortas = int.Parse(Console.ReadLine());                
                Console.WriteLine("Potência do Motor: ");
                caminhonete.PotenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("Cor da Moto/Triciculo: ");
                caminhonete.Cor = Console.ReadLine();
                Console.WriteLine("Valor R$: ");
                caminhonete.Valor = decimal.Parse(Console.ReadLine());
                repository.ListaDeVeiculos.Add(new CaminhoneteModel(caminhonete.DataFabricacao, caminhonete.NomeVeiculo, caminhonete.Placa, caminhonete.Valor, caminhonete.Cor, caminhonete.TotalPortas, caminhonete.TipoCombustivel, caminhonete.CapacidadeDeCarregamento,caminhonete.PotenciaMotor));
                Console.WriteLine("Caminhonete cadastrado com sucesso");
                Console.WriteLine();
                Console.WriteLine("Precione enter para voltar ao menu");
               
                var voltar = Console.ReadKey();
                switch (voltar)
                {
                    default: Iniciar(repository); break;
                }
            }
        
        
    }
        
}
