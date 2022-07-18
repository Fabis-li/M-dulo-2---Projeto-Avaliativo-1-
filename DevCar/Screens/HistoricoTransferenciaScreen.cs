using System.Globalization;
using DevCar.Models;
using DevCar.Repositories;
using System.Linq;
using System.Text.RegularExpressions;

namespace DevCar.Screen
{
    public static class HistoricoTransferenciaScreen
    {
        public static void Iniciar(VeiculosRepository repository)
        {
            Console.Clear();
            Console.WriteLine("Transferencia de Veiculos (Venda)");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Veiculo");
            Console.WriteLine("2 - Venda com maior valor");
            Console.WriteLine("3 - Venda com menor valor");                       
            Console.WriteLine("0 - Voltar ao menu Iniciar");

            var option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: VendaVeiculo(repository);break;
                case 2: VendaMaior(repository);break;
                case 3: VendaMenor(repository);break;
                case 4: ;break;
                case 0: MenuScreen.Iniciar(repository);break;
                default: break;
            }
            Console.ReadKey();
        }

        static void VendaVeiculo(VeiculosRepository repository)
        {
            Regex regexNumeros = new Regex("^[0-9]+$");
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo:");
            string placa = Console.ReadLine().ToUpper();
            

            foreach (var veiculo  in repository.ListaDeVeiculos)
            {
                if(veiculo.Placa == placa)
                {                    
                    Console.WriteLine($"Nome Veiculo: {veiculo.NomeVeiculo}");
                    Console.WriteLine($"Cor : {veiculo.Cor}");
                    Console.WriteLine($"Data Fabricação: {veiculo.DataFabricacao.ToString("dd/MM/yyyy")}");
                    Console.WriteLine($"Valor Veiculo: {veiculo.Valor.ToString("c")}");
                    Console.WriteLine("CPF Comprador: ");
                    string cpfComprador = Console.ReadLine();
                    Console.WriteLine($"Data Venda: {DateTime.Today.ToString("dd/MM/yyyy")}");
                    Console.WriteLine("Valor Vendido: ");
                    try
                    {
                        if(veiculo.ValorVenda >= 0)
                        {
                            veiculo.ValorVenda = decimal.Parse(Console.ReadLine());
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        
                        Console.WriteLine($"O erro é: {ex.Message}");
                    }
                    
                    Console.WriteLine("Pressione ENTER para voltar ao Menu Principal");
                        
                    var voltar = Console.ReadKey();
                    switch (voltar)
                    {
                        default: Iniciar(repository); break;
                    }                       
                }
            }
            

        }

        static void VendaMaior (VeiculosRepository repository)
        {
            Console.Clear();
            Console.WriteLine("Veiculo Vendido com o maior preço");
            Console.WriteLine("---------------------------------");

            var maiorValor = (repository.ListaDeVeiculos.Where(w  => w.CpfComprador != null).Max(veiculos => veiculos.ValorVenda));

            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                if(veiculo.ValorVenda == maiorValor)
                {
                    Console.WriteLine(veiculo.ListarInformacoes());
                    veiculo.ListarInformacoes();
                    Console.WriteLine($"Valor R$: {veiculo.ValorVenda.ToString("c")} | CPF Comprador: {veiculo.CpfComprador}");
                }
            }

            var voltar = Console.ReadKey();
                    switch (voltar)
                    {
                        default: Iniciar(repository); break;
                    }                       
        }

        static void VendaMenor(VeiculosRepository repository)
        {
            Console.Clear();
            Console.WriteLine("Veiculo vendido com o menor preço");
            Console.WriteLine("----------------------------------");

            var menorValor = (repository.ListaDeVeiculos.Where(m => m.CpfComprador != null).Min(veiculos => veiculos.ValorVenda));
            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                if(veiculo.ValorVenda == menorValor)
                {
                    Console.WriteLine(veiculo.ListarInformacoes());
                    veiculo.ListarInformacoes();
                    Console.WriteLine($"Valor R$: {veiculo.ValorVenda.ToString("c")} | CPF Comprador: {veiculo.CpfComprador}");
                }
            }

            var voltar = Console.ReadKey();
                    switch (voltar)
                    {
                        default: Iniciar(repository); break;
                    }                       
        }          

    }
}