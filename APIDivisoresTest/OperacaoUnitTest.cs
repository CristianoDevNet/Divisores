using Divisores.Controllers;
using Divisores.Models;
using Divisores.Services;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace APIDivisoresTest
{
    public class OperacaoUnitTest
    {
        private readonly int numero = 548;

        [Fact]
        public void TestarOperacaoObterDivisores()
        {
            var operacao = new OperacaoService().ObterDivisores(numero);

            NumerosDivisores valorEsperado = new NumerosDivisores
            {
                NaoPrimos = new List<int> { 548, 274, 4, 1 },

                Primos = new List<int> { 137, 2 }
            };

            operacao.Should().BeEquivalentTo(valorEsperado);
        }

        [Fact]
        public void TestarObterNumerosPrimos()
        {
            var operacao = new OperacaoService().ObterDivisores(numero).Primos;

            var valorEsperado = new List<int> { 137, 2 };

            Assert.Equal(valorEsperado, operacao);
        }

        [Fact]
        public void TestarObterNumerosNaoPrimos()
        {
            var operacao = new OperacaoService().ObterDivisores(numero).NaoPrimos;

            var valorEsperado = new List<int> { 548, 274, 4, 1 };

            Assert.Equal(valorEsperado, operacao);
        }

        [Fact]
        public void TestarSeNumeroEhPrimo()
        {
            var operacao = new OperacaoService().EhPrimo(137);

            var valorEsperado = true;

            Assert.Equal(valorEsperado, operacao);
        }
    }
}
