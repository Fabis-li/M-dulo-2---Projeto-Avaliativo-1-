
namespace DevCar.Models
{
    public class MotoTriciculoModel : VeiculoModel
    
    {
        public int PotenciaMotor { get; set; }
        public int QtdeRodas { get; set; }
        
        public MotoTriciculoModel()
        {        
        }

        public MotoTriciculoModel(DateTime dataFabricacao, string nomeVeiculo, string placa, decimal valor, string cor, int potenciaMotor, int qtdeRodas) : base (dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            PotenciaMotor = potenciaMotor;
            QtdeRodas = qtdeRodas;
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