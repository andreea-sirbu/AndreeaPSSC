using PSSC.Models.Folder;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PSSC.Models.Repositories
{
    public class FarmacistRepository 
    {
        private readonly FarmacistDbContext fcontext;
        public FarmacistRepository(FarmacistDbContext fDbContext)
        {
            fcontext = fDbContext;
        }
        public async Task Create(Farmacist farmacist)
        {
            fcontext.Add(farmacist);
            await fcontext.SaveChangesAsync();

        }
        public async Task<List<Farmacist>> GetUsersAsync()
        {
            return await fcontext.farmacisti.ToListAsync();
        }
    }
}
