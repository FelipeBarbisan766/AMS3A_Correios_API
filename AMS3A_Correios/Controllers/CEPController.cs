using AMS3A_Correios.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AMS3A_Correios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CEPController : ControllerBase
    {
        private readonly IViaCepIntegracao _integracao;
        public CEPController(IViaCepIntegracao viaCepIntegracao)
        {
            _integracao = viaCepIntegracao;
        }
        [HttpGet("{cep}")]
        public async Task<ActionResult<Addres>> ListarDados(string cep)
        {
            var responseData = await _integracao.ObterDados(cep);   

            return Ok(responseData);
        }
    }
}
