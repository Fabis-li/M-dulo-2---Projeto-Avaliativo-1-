namespace DevCar.Models
{
    public class CaminhoneteModel : VeiculoModel
    {
        public int TotalPortas { get; set; }

        public string TipoCombustivel { get; set; }
        public int CapacidadeDeCarregamento { get; set; }
        public int PotenciaMotor { get; set; }

        public CaminhoneteModel()
        {            
        }

        public CaminhoneteModel(DateTime dataFabricacao, string nomeVeiculo, string placa, decimal valor, string cor, int totalPortas, string tipoCombustivel, int capacidadeDeCarregamento, int potenciaMotor) : base (dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            TotalPortas = totalPortas;
            TipoCombustivel = tipoCombustivel;
            CapacidadeDeCarregamento = capacidadeDeCarregamento;
            PotenciaMotor = potenciaMotor;
        }

         public override void VendaVeiculo(string cpfComprador, decimal valorVenda)
        {
            DataVenda = DateTime.Now;
            CpfComprador = cpfComprador;
            ValorVenda = valorVenda;
        }

        public string ListarInformacoes()
        {
            return"";
        }

        public void AlterarInformacoes()
        {
        }

        //Todo:
        // criar enumetor para cor
    }
}