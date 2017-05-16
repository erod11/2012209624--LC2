using _2012209624_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012209624_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {

        public IAdministrativoRepository Administrativos { get; private set; }

        public IBusRepository Buss { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEncomiendaRepository Encomiendas { get; private set; }

        public ILugarViajeRepository LugarViajes { get; private set; }

        public IServicioRepository Servicios { get; private set; }

        public ITipoComprobanteRepository TipoComprobantes { get; private set; }

        public ITipoLugarRepository TipoLugars { get; private set; }

        public ITipoPagoRepository TipoPagos { get; private set; }

        public ITipoTripulacionRepository TipoTripulacions { get; private set; }

        public ITipoViajeRepository TipoViajes { get; private set; }

        public ITransporteRepository Transportes { get; private set; }

        public ITripulacionRepository Tripulacions { get; private set; }

        public IVentaRepository Ventas { get; private set; }

        private UnityOfWork()
        {
            _Context = new a12209624DbContext();
        }

        public static UnityOfWork
        {
            
        }




        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnityOfWork.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
