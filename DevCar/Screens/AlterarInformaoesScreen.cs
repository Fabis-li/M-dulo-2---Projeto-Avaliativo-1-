using System.Globalization;
using DevCar.Models;
using DevCar.Repositories;

namespace DevCar.Screen
{
    public class AlterarInfomacoesScreen
    {
         public static void Iniciar(VeiculosRepository repository)
         {
            Console.Clear();
            Console.WriteLine("Alterar Dados");
            Console.WriteLine("--------------");
            Console.WriteLine("Digite a placa do veiculo: ");
            string placa = Console.ReadLine().ToUpper();

            foreach (var veiculo in repository.ListaDeVeiculos)
            {
                if(veiculo.Placa == placa)
                {
                    Console.WriteLine($"Nome Veiculo: {veiculo.NomeVeiculo}");
                    Console.WriteLine($"Data Fabricacao: {veiculo.DataFabricacao.ToString("dd/MM/yyyy")}");
                    Console.WriteLine($"Placa: {veiculo.Placa}");
                    veiculo.Placa = Console.ReadLine();
                    Console.WriteLine($"Cor: {veiculo.Cor}");
                    veiculo.Cor = Console.ReadLine();

                    var voltar = Console.ReadKey();
                    switch (voltar)
                    {
                        default: Iniciar(repository); break;
                    }                  
                }
            }
         }
    }
}