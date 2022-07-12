
namespace DevCar.Models
{
    public class VeiculoModel
    {
        public string numeroChassi { get; set; }
        public DateTime dataFabricacao { get; set; }
        public string nomeVeiculo { get; set; }
        public string placa { get; set; }
        public double valor { get; set; }
        public int? cpfComprador { get; set; }
        public string cor { get; set; }

        public VeiculoModel()
        {            
        }

        public VeiculoModel(DateTime dataFabricacao, string nomeVeiculo, string placa, double valor, string cor)
        {
            this.numeroChassi = Guid.NewGuid().ToString().Substring(0, 17);
            this.dataFabricacao = dataFabricacao;
            this.nomeVeiculo = nomeVeiculo;
            this.placa = placa;
            this.valor = valor;
            this.cpfComprador = cpfComprador;
            this.cor = cor;
            
        }

        public void VendaVeiculo()
        {

        }

        public string ListarInformacoes()
        {
            return "";
        }

        public void AlterarInformacoes()
        {
        }
            
    }
}
