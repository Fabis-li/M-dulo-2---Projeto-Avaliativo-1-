using System.Text;
using DevCar.Models;

namespace devcar_tests;

public class UnitTest1 : CaminhoneteModel
{
    [Theory]
    [InlineData("ROXA")]
    [InlineData("AZUL")]
    public void teste_cor_caminhote_sucesso(string ROXA)
    {
        CaminhoneteModel caminhonete = new CaminhoneteModel();

        bool condicao = caminhonete.Cor != "ROXA";
        string mensagemErro = "Erro caminhote não fabricada na DevCar";

        Assert.NotNull(caminhonete);
        Assert.True(condicao, mensagemErro);
        Assert.False(condicao == true, mensagemErro);

    }
}