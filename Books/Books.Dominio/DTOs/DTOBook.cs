using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Dominio.DTOs
{
    public class DTOImageLinks
    {
        public string Thumbnail { get; set; }
    }

    public class DTOVolumeInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DTOImageLinks ImageLinks { get; set; }
    }

    public class DTOBook
    {
        public string Id { set; get; }
        public DTOVolumeInfo VolumeInfo { get; set; }
    }
}
