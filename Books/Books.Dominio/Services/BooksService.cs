using Books.Dominio.DTOs;
using Books.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Books.Dominio.Services
{
    public class BooksService : IBooksService
    {
        public Task<(int totalItems, List<DTOBook> books)> ObtenhaLivrosPorTermo(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
