using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Dominio.Models
{
    public class Volume
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string ImageLink { get; set; }
    }
}
