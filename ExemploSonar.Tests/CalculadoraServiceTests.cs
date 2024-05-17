using ExemploSonar.Services;

namespace ExemploSonar.Tests
{
    public class CalculadoraServiceTests
    {
        [Fact]
        public void TesteSomar()
        {
            var service = new CalculadoraService();

            var resultado = service.Soma(1, 2);

            Assert.Equal(3, resultado);
        }
    }
}