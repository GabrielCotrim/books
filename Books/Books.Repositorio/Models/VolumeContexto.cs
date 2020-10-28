using Books.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Repositorio.Models
{
    public class VolumeContexto : DbContext
    {
        public VolumeContexto(DbContextOptions<VolumeContexto> options) : base(options) { }

        public DbSet<Volume> Volumes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Volume>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
