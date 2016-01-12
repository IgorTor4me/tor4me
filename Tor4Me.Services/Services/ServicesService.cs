using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tor4Me.Data;
using System.Data;

namespace Tor4Me.Services.Services
{
    public class ServicesService : IServicesService
    {
        private DB_9EED4C_tor4meserverEntities db = new DB_9EED4C_tor4meserverEntities();
        public List<service> GetServices()
        {
            return db.service.ToList();
        }

        public service GetService(int id)
        {
            return db.service.Where(x => x.servid == id).FirstOrDefault();
        }


        public bool SaveService(service service)
        {
            try
            {
                db.service.Add(service);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool UpdateService(long servid, service service)
        {
            try
            {
                db.Entry(service).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteService(int id)
        {
            try
            {
                var service = db.service.Where(x => x.servid == id).FirstOrDefault();
                if (service == null) return false;
                db.Entry(service).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}