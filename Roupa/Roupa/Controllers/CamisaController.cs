using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roupa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roupa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamisaController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public CamisaController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]

        public List<Camisa> Get()
        {
            return Contexto.Camisas.ToList();
        }

        [HttpGet("{id}")]

        public Camisa Get(int id)
        {
            return Contexto.Camisas.First(e => e.IdRoupa == id);
        }

        [HttpGet("idroupa/{idroupa}")]

        public List<Camisa> Filtrar(int id)
        {
            return Contexto.Camisas.Where(e => e.IdRoupa == id).ToList();
        }

        [HttpPost]
        [Route("add")]

        public async Task<ActionResult<Camisa>> Create (Camisa Camisa)
        {
            Camisa.IdRoupa = 0;
            Contexto.Camisas.Add(Camisa);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Camisa.IdRoupa, Camisa });
        }

        [HttpPost]
        [Route("update")]

        public async Task<ActionResult<Camisa>> Update(Camisa Camisa)
        {
            Camisa.IdRoupa = 0;
            Contexto.Camisas.Update(Camisa);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Camisa.IdRoupa, Camisa });
        }

    }
}
