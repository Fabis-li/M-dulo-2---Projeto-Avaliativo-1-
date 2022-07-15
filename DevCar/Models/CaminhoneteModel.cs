namespace DevCar.Models
{
    public class CaminhoneteModel : VeiculoModel
    {
        public int totalPortas { get; set; }

        public string tipoCombustivel { get; set; }
        public int capacidadeDeCarregamento { get; set; }
        public int potenciaMotor { get; set; }

        public CaminhoneteModel()
        {            
        }

        public CaminhoneteModel(DateTime dataFabricacao, string nomeVeiculo, string placa, double valor, string cor, int totalPortas, string tipoCombustivel, int capacidadeDeCarregamento, int potenciaMotor) : base (dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            this.totalPortas = totalPortas;
            this.tipoCombustivel = tipoCombustivel;
            this.capacidadeDeCarregamento = capacidadeDeCarregamento;
            this.potenciaMotor = potenciaMotor;
        }

         public void VendaVeiculo()
        {

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