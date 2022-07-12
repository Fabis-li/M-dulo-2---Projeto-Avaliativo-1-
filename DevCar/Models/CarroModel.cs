namespace DevCar.Models
{
    public class CarroModel : VeiculoModel
    {
        public int totalDePortas { get; set; }

        public string tipoCombustivel { get; set; }

        public int potenciaMotor { get; set; }

        public CarroModel()
        {            
        }

        public CarroModel(DateTime dataFabricacao, string nomeVeiculo, string placa, double valor, string cor, int totalDePortas, string tipoCombustivel, int potenciaMotor) : base(dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            this.totalDePortas = totalDePortas;
            this.tipoCombustivel = tipoCombustivel;
            this.potenciaMotor = potenciaMotor;
        }

        //Todo:
        // criar enumetor para cor
    }
}