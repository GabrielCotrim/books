using Books.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Repositorio.Interfaces
{
    public interface IRepositorioDeVolume
    {
        void AdicioneFavorito(Volume volume);
    }
}
