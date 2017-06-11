using _2012209624_ENT.Entities;
using _2012209624_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_PER.Repositories
{
    public class AdministrativoRepository : Repository<Administrativo>, IAdministrativoRepository
    {
        private 2012209624Context _context;

        private AdministrativoRepository()
        {

        }
        public AdministrativoRepository(2012209624Context Context)
        {
            _context = Context;
        }


        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministativoByEmpeledo(Empleado Empleado)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativosWithEmpleado(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
