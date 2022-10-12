using API_Training_WFM.Abstractions;
using API_Training_WFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Training_WFM.Services
{
    public class SoftlocksService : ISoftlocksService
    {
        private readonly WFMDbContext _wfmDbContext;
        public SoftlocksService(WFMDbContext wfmDbContext)
        {
            _wfmDbContext = wfmDbContext;
        }
        public IEnumerable<Softlocks> GetSoftlocks()
        {
            var result = _wfmDbContext.Softlocks.Where(x => x.managerstatus == "awaiting_approval").ToList();
            return result;
        }

        public Softlocks GetSoftlocksbyid(int id)
        {
            var result = _wfmDbContext.Softlocks.FirstOrDefault(s => s.lockid == id);
            return result;
        }

        public bool UpdateSoftlocks(Softlocks softlocks)
        {
            var softlock = _wfmDbContext.Softlocks.Where(x => x.lockid == softlocks.lockid).FirstOrDefault();
            if(softlock != null)
            {
                softlock.lockid = softlocks.lockid;
                softlock.managerstatus = softlocks.managerstatus;
                softlock.mgrlastupdate = DateTime.Now;
                try
                {
                    _wfmDbContext.Update(softlock);
                    _wfmDbContext.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }                
            }
            return false;
        }

        public bool AddSoftlocks(Softlocks softlocks)
        {
            var emp = _wfmDbContext.Employees.Where(x => x.employee_id == softlocks.employee_id).FirstOrDefault();
            Softlocks soft = new Softlocks()
            {
                employee_id = softlocks.employee_id,
                manager = emp.manager,
                reqdate = DateTime.Now,
                status = "waiting",
                lastupdated = DateTime.Now,
                requestmessage = softlocks.requestmessage,
                wfmremark = null,
                managerstatus = "awaiting_approval",
                mgrlastupdate = DateTime.Now,
                mgrstatuscomment = null,
            };
            try
            {
                _wfmDbContext.Softlocks.Add(soft);
                _wfmDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
