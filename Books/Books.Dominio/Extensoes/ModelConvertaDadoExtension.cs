using Books.Dominio.Models;
using Books.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Books.Dominio.Extensoes
{
    public static class ModelConvertaDadoExtension
    {
        public static Volume Converta(this VolumeModel model) 
        {
            return new Volume
            {
                Id = model.Id,
                Titulo = model.Titulo,
                Resumo = model.Resumo,
                ImageLink = model.ImageLink
            };
        }

        public static List<VolumeModel> Converta(this List<Volume> volumes)
        {
            return volumes.Select(v => v.Converta()).ToList();
        }

        public static VolumeModel Converta(this Volume volume)
        {
            return new VolumeModel
            {
                Id = volume.Id,
                Titulo = volume.Titulo,
                Resumo = volume.Resumo,
                ImageLink = volume.ImageLink
            };
        }
    }
}
