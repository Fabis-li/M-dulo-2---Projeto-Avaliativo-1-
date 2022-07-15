
namespace DevCar.Models
{
    public class VeiculoModel
    {
        public string NumeroChassi { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string NomeVeiculo { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public int? CpfComprador { get; set; }
        public string Cor { get; set; }

        public VeiculoModel()
        {            
        }

        public VeiculoModel(DateTime dataFabricacao, string nomeVeiculo, string placa, double valor, string cor)
        {
            this.NumeroChassi = Guid.NewGuid().ToString().Substring(0, 18);
            this.DataFabricacao = dataFabricacao;
            this.NomeVeiculo = nomeVeiculo;
            this.Placa = placa;
            this.Valor = valor;
            this.CpfComprador = CpfComprador;
            this.Cor = cor;
            
        }

        public void VendaVeiculo()
        {

        }

        public virtual string ListarInformacoes()
        {
            return "";
            // Console.WriteLine(numeroChassi);
            // Console.WriteLine(dataFabricacao);
            // Console.WriteLine(nomeVeiculo);
            // Console.WriteLine(placa);
            // Console.WriteLine(valor);
            // Console.WriteLine(cor);
        }

        public void AlterarInformacoes()
        {
        }
            
    }
}
