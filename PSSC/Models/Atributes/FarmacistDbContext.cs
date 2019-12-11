using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace PSSC.Models.Folder
{
    public class FarmacistDbContext : DbContext
    {
        public FarmacistDbContext()
        {

        }

        public FarmacistDbContext(DbContextOptions<FarmacistDbContext> options) : base(options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<Farmacist> farmacisti { get; set; }11
    }
}
