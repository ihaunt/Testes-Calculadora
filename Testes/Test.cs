
using NewTalents;

namespace Testes;

public class Test
{
    public Calculadora construirClasse()
    {
        string data = "20/11/2023";
        Calculadora calc = new Calculadora(data);

        return calc;
    }


    [Fact]
    public void TestSomar()
    {
        Calculadora calc = construirClasse();

        int resultado = calc.Somar(1, 2);

        Assert.Equal(3, resultado);
    }


    [Theory]
    [InlineData(3, 4, 7)]
    [InlineData(5, 6, 11)]
    [InlineData(10, 20, 30)]
    public void TesetSomar(int var1, int var2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalc = calc.Somar(var1, var2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void TestMultiplicar()
    {
        Calculadora calc = construirClasse();

        int resultado = calc.Multiplicar(1, 2);

        Assert.Equal(2, resultado);
    }


    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(5, 6, 30)]
    [InlineData(10, 20, 200)]
    public void TesetMultiplicar(int var1, int var2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalc = calc.Multiplicar(var1, var2);

        Assert.Equal(resultado, resultadoCalc);
    }


    [Fact]
    public void TestSubtrair()
    {
        Calculadora calc = construirClasse();

        int resultado = calc.Subtrair(1, 2);

        Assert.Equal(-1, resultado);
    }


    [Theory]
    [InlineData(4, 3, 1)]
    [InlineData(10, 8, 2)]
    [InlineData(30, 20, 10)]
    public void TesteSubtrair(int var1, int var2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalc = calc.Subtrair(var1, var2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void TestDividir()
    {
        Calculadora calc = construirClasse();
        int resultado = calc.Dividir(10, 2);

        Assert.Equal(5, resultado);
    }


    [Theory]
    [InlineData(20, 10, 2)]
    [InlineData(12, 6, 2)]
    [InlineData(100, 20, 5)]
    public void TesteDivir(int var1, int var2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalc = calc.Dividir(var1, var2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void TestarDivisaoPorzero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        //similando opera
        calc.Somar(1, 2);
        calc.Subtrair(2, 1);
        calc.Dividir(2, 1);
        calc.Multiplicar(2, 2);

        var lista = calc.historico();


        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }


}