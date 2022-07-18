namespace DevCar.Models
{
    public class TransferenciaModel : VeiculoModel
    {
        public decimal ValorVenda { get; set; }
        public DateTime DataVenda { get; set; }

        public TransferenciaModel()
        {        
        }

        public TransferenciaModel(DateTime dataFabricacao, string nomeVeiculo, string placa, decimal valor, string cor, decimal valorVenda, DateTime dataVenda) : base(dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            ValorVenda = valorVenda;
            DataVenda = dataVenda;
        }

        

    }
    
}