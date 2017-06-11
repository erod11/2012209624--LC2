using _2012209624_ENT;
using _2012209624_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_PER.Repositories
{
    public class LugarViajeRepository : Repository<LugarViaje>, ILugarViajeRepository
    {
        public LugarViajeRepository(DbContext context) : base(context)
        {
        }

    }
}
