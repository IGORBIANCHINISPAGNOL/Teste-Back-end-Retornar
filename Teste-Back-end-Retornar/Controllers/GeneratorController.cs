using Domain.Models.Interfaces;
using Domain.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace Teste_Back_end_Retornar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneratorController : ControllerBase
    {
        public readonly IGeneratorService _generatorService;
        public GeneratorController(IGeneratorService generatorService)
        {
            _generatorService = generatorService;   
        }
        [HttpPost("PostNewKey")]
        public async Task<IActionResult> PostNewKey(Cliente cliente)
        {
            var _return = await _generatorService.RegisterNewKey(cliente);
            return _return.bSucess ? Ok(_return) : BadRequest(_return);        
        }
    }
}
