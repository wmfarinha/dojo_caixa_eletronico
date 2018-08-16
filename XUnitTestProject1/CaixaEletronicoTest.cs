using Puzzle1;
using System;
using Xunit;

public class CaixaEletronicoTest
{
    [Fact]
    public void SaqueRetornaUmaDezUmaVinte()
    {
        var caixaEletronico = new CaixaEletronico();
        var notas = caixaEletronico.Saque(30);

        var expectativaNotas = new Notas(1, 1, 0, 0);

        Assert.Equal(expectativaNotas, notas);
    }

    [Fact]
    public void SaqueRetornaUmaCinquentaUmaVinteUmaDez()
    {
        var caixaEletronico = new CaixaEletronico();
        var notas = caixaEletronico.Saque(80);

        var expectativaNotas = new Notas(1, 1, 1, 0);

        Assert.Equal(expectativaNotas, notas);
    }

    [Fact]
    public void SaqueRetornaUmaCemUmaCinquentaUmaVinteUmaDez()
    {
        var caixaEletronico = new CaixaEletronico();
        var notas = caixaEletronico.Saque(180);

        var expectativaNota = new Notas(1, 1, 1, 1);

        Assert.Equal(expectativaNota, notas);
    }

    //[Fact]
    //public void SaqueRetornaValorNaoPermitido()
    //{
    //    var caixaEletronico = new CaixaEletronico();
    //    var notas = caixaEletronico.Saque(25);

    //    var expectativa = new Exception("Valor não permitido");

    //    Assert.Equal(expectativa, notas);
    //}
}
