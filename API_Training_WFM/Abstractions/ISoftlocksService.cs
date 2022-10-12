using API_Training_WFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Training_WFM.Abstractions
{
    public interface ISoftlocksService
    {
        IEnumerable<Softlocks> GetSoftlocks();
        Softlocks GetSoftlocksbyid(int id);
        bool AddSoftlocks(Softlocks softlocks);
        bool UpdateSoftlocks(Softlocks softlocks); 
    }
}
