using Books.Repositorio.Interfaces;
using Books.Repositorio.Models;
using System;
using System.Collections.Generic;
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
            _contexto.Add(volume);
            _contexto.SaveChanges();
        }
    }
}
