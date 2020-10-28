using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Dominio.DTOs
{
    public class DTOBooksResult
    {
        public IList<DTOBook> Items { get; set; } = new List<DTOBook>();
    }
}
