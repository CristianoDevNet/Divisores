using Divisores.Models;

namespace Divisores.Services
{
    public interface IOperacaoService
    {
        NumerosDivisores ObterDivisores(int numero);
    }
}
