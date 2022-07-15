
namespace DevCar.Models
{
    public class MotoTriciculoModel : VeiculoModel
    
    {
        public int PotenciaMotor { get; set; }
        public int QtdeRodas { get; set; }
        
        public MotoTriciculoModel()
        {        
        }

        public MotoTriciculoModel(DateTime dataFabricacao, string nomeVeiculo, string placa, double valor, string cor, int potenciaMotor, int qtdeRodas) : base (dataFabricacao, nomeVeiculo, placa, valor, cor)
        {
            this.PotenciaMotor = potenciaMotor;
            this.QtdeRodas = qtdeRodas;
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