using Books.Dominio.Models;
using System.Threading.Tasks;

namespace Books.Dominio.Interfaces
{
    public interface IBooksService
    {
        Task<VolumeResult> ObtenhaLivrosPorTermo(BookParametros parametros);
    }
}
