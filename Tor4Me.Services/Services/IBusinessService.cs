using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tor4Me.Data;


namespace Tor4Me.Services.Services
{
    public interface IBusinessService
    {
        List<business> GetBusinesses();
        business GetBusiness(int id);

        //    List<executers> GetExecuters(int busid);

        bool SaveBusiness(business business);

        bool UpdateBusiness(long p, business business);
        bool DeleteBusiness(int id);
    }
}
