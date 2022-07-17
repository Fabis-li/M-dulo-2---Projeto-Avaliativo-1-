
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

        public virtual void VendaVeiculo()
        {          
           
           
        }

        public virtual string ListarInformacoes()
        {
            return $"Data: {DataFabricacao.ToString("dd/MM/yyyy")} | Nome: {NomeVeiculo} | Placa: {Placa} | Valor: {Valor} | Cor: {Cor}";
           
        }

        public void AlterarInformacoes(DateTime dataFabricacao, string nomeVeiculo, string placa, decimal valor, string cor)
        {
            DataFabricacao = dataFabricacao;
            NomeVeiculo = nomeVeiculo;
            Placa = placa;
            Valor = valor;
            Cor = cor;            
        }
            
    }
}
