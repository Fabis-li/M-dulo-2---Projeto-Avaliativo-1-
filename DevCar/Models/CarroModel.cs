namespace DevCar.Models
{
    public class CarroModel : VeiculoModel
    {
        public int TotalDePortas { get; set; }

        public string TipoCombustivel { get; set; }

        public int PotenciaMotor { get; set; }

        public CarroModel()
        {            
        }

        public CarroModel(DateTime dataFabricacao, string nomeVeiculo, string placa, double valor, string cor, int totalDePortas, string tipoCombustivel, int potenciaMotor) : base(dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            
            TotalDePortas = totalDePortas;
            TipoCombustivel = tipoCombustivel;
            PotenciaMotor = potenciaMotor;
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
        // public enum Cor
        // {
        //     Branco = 1,
        //     Prata = 2,
        //     Preto = 3,
        //     Vermelho = 4,
        //     Azul = 5,
        // }
    }
}