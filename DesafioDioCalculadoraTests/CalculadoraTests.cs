using DesadioDioCalculadora;

namespace DesafioDioCalculadoraTests
{
    public class CalculadoraTests
    {

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(8, 8, 16)]
        public void SomarTests(int num1, int num2, int resultadoEsperado)
        {
            //Arrange
            Calculadora calc = new Calculadora();

            //Act
            var resultado = calc.Somar(num1, num2);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(16, 8, 8)]
        public void SubtrairTests(int num1, int num2, int resultadoEsperado)
        {
            //Arrange
            Calculadora calc = new Calculadora();

            //Act
            var resultado = calc.Subtrair(num1, num2);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2, 8, 16)]
        public void MultiplicarTests(int num1, int num2, int resultadoEsperado)
        {
            //Arrange
            Calculadora calc = new Calculadora();

            //Act
            var resultado = calc.Multiplicar(num1, num2);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(32, 8, 4)]
        public void DividirTests(int num1, int num2, int resultadoEsperado)
        {
            //Arrange
            Calculadora calc = new Calculadora();

            //Act
            var resultado = calc.Dividir(num1, num2);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DividirZeroTest()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void ExibirHistoricoTest()
        {
            //Arrange
            Calculadora calc = new Calculadora();
            List<int> listaHistoricoEsperado = new List<int>() { 10, 10, 10 };

            //Act
            calc.Somar(2, 2);
            calc.Somar(3, 7);
            calc.Somar(8, 2);
            calc.Somar(5, 5);
            var resultado = calc.ExibirHistorico();

            //Assert
            Assert.Equal(listaHistoricoEsperado, resultado);
        }
    }
}