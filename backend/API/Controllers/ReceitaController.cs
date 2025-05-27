using backend.Data.Dto;
using backend.Services;
using Microsoft.AspNetCore.Mvc;
using backend.Utils;
using backend.Core.Entities;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitaController : Controller
    {
        private readonly ReceitaServices _receitaServices;
        private readonly ILogger<ReceitaController> _logger;
        public ReceitaController(ReceitaServices receitaServices, ILogger<ReceitaController> logger)
        {
            _receitaServices = receitaServices;
            _logger=logger;
        }

        [HttpGet]
        public async Task<ActionResult> Receitas()
        {
            var response = await _receitaServices.Receitas();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Receita(string id)
        {
            var response = await _receitaServices.Receita(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> GerarReceita([FromBody] GerarReceita request)
        {
     

            if (request == null)
            {
                //_logger.LogError("Receita enviada é nula.");
                return BadRequest("Receita não pode ser nula.");
            }

            try
            {
                var response = await _receitaServices.Gerar(request);
                return Ok(response);
                //return CreatedAtAction(nameof(GetReceitaById), new { id = receita.Id }, receita);
            }
            catch (Exception ex)
            {
                Logger.CriarLog("Catch do gerarReceita");
                Logger.CriarLog(ex.Message);
                //Logger.CriarLog(ex.InnerException.ToString());
                return BadRequest("Receita não pode ser nula.");
            }

            
            
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizarReceita(string id, [FromBody] ReceitaDto receita)
        {
            var response = await _receitaServices.AtualizarReceita(id, receita);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarReceita(string id)
        {
            var response = await _receitaServices.RemoverReceita(id);
            return Ok(response);
        }
    }
}
