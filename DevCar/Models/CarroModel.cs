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

        public CarroModel(DateTime dataFabricacao, string nomeVeiculo, string placa, decimal valor, string cor, int totalDePortas, string tipoCombustivel, int potenciaMotor) : base(dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            
            TotalDePortas = totalDePortas;
            TipoCombustivel = tipoCombustivel;
            PotenciaMotor = potenciaMotor;
            
        }

        public void VendaVeiculo(string cpfComprador, decimal valorVenda)
        {
            DataVenda = DateTime.Now;
            CpfComprador = cpfComprador;
            ValorVenda = valorVenda;
            

        }

        public void ListarInformacoes()
        {
            
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