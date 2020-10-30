using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Books.Dominio.Interfaces;
using Books.Dominio.Models;
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

        [HttpGet, Route("volumes")]
        public Task<ActionResult<VolumeResult>> Get([FromQuery] BookParametros parametros)
        {
            return Execute(() => _service.ObtenhaLivrosPorTermo(parametros));
        }

        [HttpPost, Route("favorite")]
        public Task<ActionResult> Post([FromBody] VolumeModel volume)
        {
            return ExecuteAsync(() => _service.AdicioneFavorito(volume));
        }

        [HttpGet, Route("favorites")]
        public Task<ActionResult<VolumeResult>> GetFavoritos([FromQuery] BookParametros parametros)
        {
            return ExecuteAsync(() => _service.ObtenhaFavoritos(parametros));
        }

        [HttpDelete, Route("favorite")]
        public Task<ActionResult> Delete([FromQuery] string id)
        {
            return ExecuteAsync(() => _service.DeleteFavorito(id));
        }
    }
}
