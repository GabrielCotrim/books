using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Books.Api.Controllers
{
    [Route("api/books")]
    public class BooksController : BaseController
    {
        private readonly IBooksService _service;

        public BooksController(IBooksService service) 
        {
            _service = service;
        }

        [HttpGet, Route("{q:string}")]
        public Task<ActionResult> Get([FromQuery] string filtro)
        {
            return Execute(() =>
            {
                return _service.ObtenhaLivrosPorTermo(filtro);
            });
        }
    }
}
