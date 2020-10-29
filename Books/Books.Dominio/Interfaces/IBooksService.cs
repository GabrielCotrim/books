using Books.Dominio.Models;
using System.Threading.Tasks;

namespace Books.Dominio.Interfaces
{
    public interface IBooksService
    {
        void AdicioneFavorito(VolumeModel volume);
        VolumeResult ObtenhaFavoritos();
        void DeleteFavorito(string id);
        Task<VolumeResult> ObtenhaLivrosPorTermo(BookParametros parametros);
    }
}
