using Books.Dominio.DTOs;
using Books.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.Dominio.Extensoes
{
    public static class DTOConvertModelExtension
    {
        public static List<VolumeModel> Converta(this List<DTOBook> list)
        {
            return list.Select(item => item.Converta()).ToList();
        }

        public static VolumeModel Converta(this DTOBook book)
        {
            var volumeInfo = book.VolumeInfo;
            return new VolumeModel
            {
                Id = book.Id,
                Titulo = volumeInfo.Title,
                Resumo = volumeInfo.Description,
                ImageLink = volumeInfo.ImageLinks.Thumbnail
            };
        }
    }
}
