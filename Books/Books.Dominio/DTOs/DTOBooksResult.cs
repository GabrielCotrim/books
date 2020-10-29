using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Dominio.DTOs
{
    public class DTOBooksResult
    {
        public int TotalItems { get; set; }
        public List<DTOBook> Items { get; set; } = new List<DTOBook>();
    }
}
