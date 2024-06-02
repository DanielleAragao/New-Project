using System;
using Xunit;
using New_Project;

namespace TestNewProject
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "01/06/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(6,2,8)]
        [InlineData(10, 5, 15)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(10, 5, 5)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 12)]
        [InlineData(10, 5, 50)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 5, 2)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);

        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));

        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1,2);
            calc.somar(2, 4);
            calc.somar(3, 5);
            calc.somar(2, 2);

            var lista =  calc.historico(); 

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }




    }
}
