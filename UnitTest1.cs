using DIO_ProjetoFinal;

namespace TesteDIO_ProjetoFinal
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(5, 4, 9)]
        public void TestarSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            //Arrange and Act
            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 4, 1)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            //Arrange and Act
            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 4, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            //Arrange and Act
            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            //Arrange and Act
            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
  
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

          
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));
        }

        [Fact]
        public void testarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(3, 5);
            calc.Somar(4, 7);
            calc.Somar(8, 6);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }

    }
}