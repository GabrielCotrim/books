using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Books.Web.Models;

namespace Books.Web.Controllers
{
    public class VolumeController : Controller
    {
        private readonly ILogger<VolumeController> _logger;

        public VolumeController(ILogger<VolumeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Pesquisa(string filtro)
        {
            var pesquisa = new PesquisaModel
            {
                Pesquisa = filtro
            };
            var uri = $"volumes?pesquisa={pesquisa.Pesquisa}&pagina={pesquisa.PaginaAtual}&itensPorPagina={pesquisa.VolumesPorPagina}";
            var volumes = await ApiBase.ApiVolume.Get<VolumeResult>(uri);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
