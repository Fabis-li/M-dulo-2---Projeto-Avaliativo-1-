using DevCar.Models;
namespace DevCar.Repositories
{
    public class VeiculosRepository
    {
        public IList <VeiculoModel> ListaDeVeiculos;
        public VeiculosRepository()
        {
            ListaDeVeiculos = new List <VeiculoModel>();
        }
    }
}
