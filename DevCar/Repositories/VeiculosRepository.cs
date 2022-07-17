using DevCar.Models;
namespace DevCar.Repositories
{
    public class VeiculosRepository
    {
        public IList <VeiculoModel> ListaDeVeiculos;        

        public VeiculosRepository()
        {
            ListaDeVeiculos = new List<VeiculoModel>();
        }       


        public void Listar()
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
