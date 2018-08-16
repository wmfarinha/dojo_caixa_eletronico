using Puzzle1;
using Xunit;

public class NotasTest
{
    [Fact]
    public void RetornoDeNotas()
    {
        var notas = new Notas(1, 1, 1, 1);

        Assert.Equal(1, notas.NotaDez);
        Assert.Equal(1, notas.NotaVinte);
        Assert.Equal(1, notas.NotaCinquenta);
        Assert.Equal(1, notas.NotaCem);
    }
}
