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

        public void VendaVeiculo(string cpfComprador)
        {
           
            CpfComprador = cpfComprador;
           
            

        }

        public override string ListarInformacoes()
        {
            return $"{base.ListarInformacoes()} | Qtd Portas: {TotalDePortas} | Tipo Combustível: {TipoCombustivel} | Potência: {PotenciaMotor}";  
        }

        public void AlterarInformacoes()
        {
        }

        
       
    }
}