using Microsoft.EntityFrameworkCore;
using API_erros.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_erros.Models
{
    public class AppDbContexto : DbContext
    {
        public AppDbContexto(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }

    public DbSet<Erro> Erros { get; set; }
}
