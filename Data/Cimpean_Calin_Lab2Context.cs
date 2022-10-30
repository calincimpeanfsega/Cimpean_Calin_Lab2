using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cimpean_Calin_Lab2.Models;

namespace Cimpean_Calin_Lab2.Data
{
    public class Cimpean_Calin_Lab2Context : DbContext
    {
        public Cimpean_Calin_Lab2Context (DbContextOptions<Cimpean_Calin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cimpean_Calin_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cimpean_Calin_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
