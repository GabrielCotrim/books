using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Dominio.Models
{
    public class VolumeResult
    {
        public int TotalItems { get; set; }
        public List<VolumeModel> Items { get; set; } = new List<VolumeModel>();
    }
}
