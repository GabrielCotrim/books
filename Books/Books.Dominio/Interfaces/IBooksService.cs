using Books.Dominio.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.Dominio.Interfaces
{
    public interface IBooksService
    {
        Task<(int totalItems, List<DTOBook> books)> ObtenhaLivrosPorTermo(string filtro);
    }
}
