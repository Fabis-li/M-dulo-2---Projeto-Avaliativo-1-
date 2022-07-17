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

         public void VendaVeiculo(string cpfComprador)
        {            
            CpfComprador = cpfComprador;            
        }

        public override string ListarInformacoes()
        {
            return $"{base.ListarInformacoes()} | Total Portas: {TotalPortas} | Tipo Combustível: {TipoCombustivel} | Capacidade Caçamba: {CapacidadeDeCarregamento} | Potência Motor: {PotenciaMotor}";
        }

        public void AlterarInformacoes()
        {
        }

        //Todo:
        // criar enumetor para cor
    }
}