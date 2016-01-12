using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tor4Me.Data;

namespace Tor4Me.Services.Services
{
    public interface IServicesService
    {
        List<service> GetServices();
        service GetService(int id);


        bool SaveService(service service);
        bool UpdateService(long p, service service);
        bool DeleteService(int id);
    }
}
