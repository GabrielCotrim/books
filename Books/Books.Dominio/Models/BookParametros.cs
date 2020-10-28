using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Books.Dominio.Models
{
    public class BookParametros
    {
        [Display(Name = "pesquisa")]
        public string Pesquisa { get; set; }

        [Display(Name = "pagina")]
        public int? Pagina { get; set; }

        [Display(Name = "itemPorPagina")]
        public int? ItemPorPagina { get; set; }
    }
}
