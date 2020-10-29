using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Web.Models
{
    public class PesquisaModel
    {
        public string Pesquisa { get; set; }
        public int PaginaAtual { get; set; } = 0;
        public int VolumesPorPagina { get; set; } = 10;
    }
}
