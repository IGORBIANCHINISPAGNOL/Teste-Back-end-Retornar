using Data.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class Contexts : DbContext
    {
        public Contexts(DbContextOptions<Contexts> options) : base(options) { }
        public DbSet<tb_cliente> tb_cliente { get; set; }       
        public DbSet<tb_numerosGerados> tb_numerosGerados { get; set; }       
    }
}
