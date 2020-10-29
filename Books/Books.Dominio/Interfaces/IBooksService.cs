using Books.Dominio.Models;
using System.Threading.Tasks;

namespace Books.Dominio.Interfaces
{
    public interface IBooksService
    {
        void AdicioneFavorito(VolumeModel volume);
        Task<VolumeResult> ObtenhaLivrosPorTermo(BookParametros parametros);
    }
}
