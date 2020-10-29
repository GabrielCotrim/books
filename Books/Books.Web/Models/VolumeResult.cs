using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Web.Models
{
    public class VolumeResult
    {
        public int TotalItems { get; set; }
        public List<VolumeModel> Items { get; set; } = new List<VolumeModel>();
    }
}
