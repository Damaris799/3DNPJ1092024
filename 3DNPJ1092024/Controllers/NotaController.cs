using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _3DNPJ1092024.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotaController : ControllerBase
    {
        private static List<Nota> notas = new List<Nota>();

        // GET: api/notas
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Nota> Get()
        {
            return notas;
        }

        // POST api/notas
        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] Nota nota)
        {
            if (nota == null)
            {
                return BadRequest("Nota no puede ser nula.");
            }

            notas.Add(nota);
            return Ok();
        }


    }

    public class Nota
    {
        public int Id { get; set; }
        public string Asignatura { get; set; }
        public int Valor { get; set; }
    }


}
         
        
           


