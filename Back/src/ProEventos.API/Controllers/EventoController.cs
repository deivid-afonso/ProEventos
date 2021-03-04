using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

       public IEnumerable<Evento> _evento =  new Evento[]{
             new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 e .net5", 
                    Local = "BH",
                    Lote = "1º lote", 
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "foto.png"
                    },

              new Evento(){
                    EventoId = 2,
                    Tema = "Angular 11 e ", 
                    Local = "sp",
                    Lote = "2º lote", 
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemUrl = "foto1.png"
                    }
          };

        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
          return _evento.Where(evento => evento.EventoId == id);
        }

         [HttpPost]
        public string Post()
        {
          return "post example";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
          return $"put example with id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
          return $"delete example with id = {id}";
        }
    }
}
