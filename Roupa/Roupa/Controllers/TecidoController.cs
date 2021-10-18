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
    public class TecidoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public TecidoController (Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]

        public List<Tecido> Get()
        {
            return Contexto.Tecidos.ToList();
        }

        [HttpGet("{id}")]

        public Tecido Get(int id)
        {
            return Contexto.Tecidos.First(e => e.IdTecido == id);
        }

        [HttpGet("idroupa/{idroupa}")]

        public List<Tecido> Filtrar(int id)
        {
            return Contexto.Tecidos.Where(e => e.IdTecido == id).ToList();
        }

        [HttpPost]
        [Route("add")]

        public async Task<ActionResult<Tecido>> Create(Tecido Tecido)
        {
            Tecido.IdTecido = 0;
            Contexto.Tecidos.Add(Tecido);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tecido.IdTecido, Tecido });
        }

        [HttpPost]
        [Route("update")]

        public async Task<ActionResult<Tecido>> Update(Tecido Tecido)
        {
            Tecido.IdTecido = 0;
            Contexto.Tecidos.Update(Tecido);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Tecido.IdTecido, Tecido });
        }
    }
}
