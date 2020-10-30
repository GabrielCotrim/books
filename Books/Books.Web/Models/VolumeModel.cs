using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Web.Models
{
    public class VolumeModel
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string ImageLink { get; set; }
        public bool EhFavorito { get; set; }
        public string ResumoAbreviado => Resumo.Length > 300
                                         ? Resumo.Substring(0, 297)+"..."
                                         : Resumo;
    }
}
