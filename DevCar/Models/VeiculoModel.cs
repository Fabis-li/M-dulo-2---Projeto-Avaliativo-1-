
namespace DevCar.Models
{
    public class VeiculoModel
    {
        public string NumeroChassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string NomeVeiculo { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }
        public string? CpfComprador { get; set; }
        public string Cor { get; set; }
        public decimal ValorVenda { get; set; }
        public DateTime DataVenda { get; set; }

        public VeiculoModel()
        {            
        }

        public VeiculoModel(DateTime dataFabricacao, string nomeVeiculo, string placa, decimal valor, string cor)
        {
            NumeroChassi = Guid.NewGuid().ToString().Substring(0, 18);         
            DataFabricacao = dataFabricacao;
            NomeVeiculo = nomeVeiculo;
            Placa = placa;
            Valor = valor;
            Cor = cor;
            
        }

        public virtual void VendaVeiculo(string cpfComprador, decimal valorVenda)
        {
           DataVenda = DateTime.Now;
           CpfComprador = cpfComprador;
           ValorVenda = valorVenda;
        }

        public virtual string ListarInformacoes()
        {
            return "";
           
        }

        public void AlterarInformacoes()
        {
        }
            
    }
}
