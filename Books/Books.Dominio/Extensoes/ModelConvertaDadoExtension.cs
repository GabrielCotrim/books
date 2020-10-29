using Books.Dominio.Models;
using Books.Repositorio.Models;
using System;
using System.Collections.Generic;
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
    }
}
