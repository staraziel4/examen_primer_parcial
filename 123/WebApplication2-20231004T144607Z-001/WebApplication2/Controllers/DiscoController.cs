using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Modelsss;

namespace WebApplication2.Controllersss
{
    [ApiController]
    [Route("[controller]")]
    public class DiscoController : ControllerBase
    {
        private readonly ILogger<DiscoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DiscoController(
            ILogger<DiscoController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Disco disco)
        {
            _aplicacionContexto.disco.Add(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<Disco> Get()
        {
            return _aplicacionContexto.disco.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Disco disco)
        {
            _aplicacionContexto.disco.Update(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        //Delete: Eliminar estudiantes
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int discoID)
        {
            _aplicacionContexto.disco.Remove(
                _aplicacionContexto.disco.ToList()
                .Where(x => x.id_disco == discoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(discoID);
        }
    }
}
