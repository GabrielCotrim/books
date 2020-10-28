using Books.Dominio.DTOs;
using Books.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.Dominio.Interfaces
{
    public interface IBooksService
    {
        Task<VolumeResult> ObtenhaLivrosPorTermo(string filtro);
    }
}
