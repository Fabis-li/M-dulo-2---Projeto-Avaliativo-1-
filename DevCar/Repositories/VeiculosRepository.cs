using DevCar.Models;
namespace DevCar.Repositories
{
    public static class VeiculosRepository
    {
        public static IList <VeiculoModel> ListaDeVeiculos;

        static VeiculosRepository()
        {
            ListaDeVeiculos = new List<VeiculoModel>();
        }
        
        // public VeiculosRepository()
        // {
        //     ListaDeVeiculos = new List <VeiculoModel>();
        // }

        public static void Listar()
        {
            foreach (var listaDeVeiculos in ListaDeVeiculos)
            {
                Console.WriteLine("Chassi: " + listaDeVeiculos.NumeroChassi);
                Console.WriteLine("Nome: " + listaDeVeiculos.NomeVeiculo);
                Console.WriteLine("Data Fabricação: " + listaDeVeiculos.DataFabricacao);
                Console.WriteLine("Cor: " + listaDeVeiculos.Cor);
                Console.WriteLine("Placa: " + listaDeVeiculos.Placa);
                Console.WriteLine("Valor: " + listaDeVeiculos.Valor);
                Console.WriteLine("CPF Comprador: " + listaDeVeiculos.CpfComprador);               

            }
        }
    }
}
