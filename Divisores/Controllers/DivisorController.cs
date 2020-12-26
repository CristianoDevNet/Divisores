using Divisores.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Divisores.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DivisorController : ControllerBase
    {
        private readonly IOperacaoService _operacao;

        public DivisorController(IOperacaoService operacao)
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
