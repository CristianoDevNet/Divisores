using Divisores.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Divisores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DivisoresController : ControllerBase
    {
        private readonly IOperacaoService _operacao;

        public DivisoresController(IOperacaoService operacao)
        {
            _operacao = operacao;
        }

        [HttpGet("{number}")]
        public IActionResult GetDivisors(int number)
        {
            try
            {
                var result = _operacao.ObterDivisores(number);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
