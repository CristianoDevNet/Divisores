using Divisores.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Divisores.Services
{
    public class OperacaoService : IOperacaoService
    {
        public NumerosDivisores ObterDivisores(int numero)
        {
            NumerosDivisores divs = new NumerosDivisores();

            for (int i = numero; i > 0; i--)
            {
                if (numero % i == 0)
                {
                    if (EhPrimo(i))
                    {
                        divs.Primos.Add(i);
                    }
                    else
                    {
                        divs.NaoPrimos.Add(i);
                    }
                }
            }

            return divs;
        }

        public bool EhPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
