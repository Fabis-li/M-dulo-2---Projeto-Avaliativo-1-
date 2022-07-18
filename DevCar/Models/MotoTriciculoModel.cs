
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

         public void VendaVeiculo(string cpfComprador)
        {            
            CpfComprador = cpfComprador;            

        }

        public override string ListarInformacoes()
        {
            return $"{base.ListarInformacoes()} | Potência Motor: {PotenciaMotor} | Qtd Rodas: {QtdeRodas}";
        }

        public void AlterarInformacoes()
        {
        }

        
    }

    

   
}