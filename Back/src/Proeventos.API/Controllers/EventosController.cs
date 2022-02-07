using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public DataContext _context{get;}
        public EventosController(DataContext _context) 
        {
            this._context = _context;
               
        }
                
        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetByID(int id){
            
            return _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }
                   
    }
}
