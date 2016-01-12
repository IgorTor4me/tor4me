using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tor4Me.Data;

namespace Tor4Me.services.Services
{
    public interface IExecuterService
    {
        List<executers> GetExecuters();
        executers GetExecuter(int id);

    //    List<executers> GetExecuters(int busid);

        bool SaveExecuter(executers executer);

        bool UpdateExecuter(long p, executers executer);
        bool DeleteExecuter(int id);
    }
}
