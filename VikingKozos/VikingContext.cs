using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VikingKozos
{
    public class VikingContext:DbContext
    {
        public  DbSet<Huzas> Huzasok { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VikingLottoHuzasok;Trusted_Connection=True;");
        }
    }
}
