using _2012209624_ENT.Entities;
using _2012209624_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private a12209624DbContext _Context;

        public BusRepository(a12209624DbContext context)
        {
            _Context = context;
        }
    }
}
