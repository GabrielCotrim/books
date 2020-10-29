using Books.Repositorio.Interfaces;
using Books.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.Repositorio
{
    public class RepositorioDeVolume : IRepositorioDeVolume
    {
        private readonly VolumeContexto _contexto;

        public RepositorioDeVolume(VolumeContexto contexto)
        {
            _contexto = contexto;
        }

        public void AdicioneFavorito(Volume volume)
        {
            var volumeAdicionado = _contexto.Volumes.SingleOrDefault(v => v.Id == volume.Id);
            if (volumeAdicionado != null)
            {
                throw new Exception("Volume já foi adicionado aos favoritos.");
            }
            _contexto.Add(volume);
            _contexto.SaveChanges();
        }

        public List<Volume> ObtenhaFavoritos()
        {
            return _contexto.Volumes.ToList();
        }

        public void DeleteFavorito(string id)
        {
            var volume = _contexto.Volumes.SingleOrDefault(v => v.Id == id);
            if (volume == null)
            {
                throw new Exception("Volume para exclusão, não foi encontrado.");
            }
            _contexto.Volumes.Remove(volume);
            _contexto.SaveChanges();
        }
    }
}
