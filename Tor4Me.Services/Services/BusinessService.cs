using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tor4Me.Data;
using System.Data.Entity;
namespace Tor4Me.Services.Services
{
    public class BusinessService : IBusinessService
    {

        private DB_9EED4C_tor4meserverEntities db = new DB_9EED4C_tor4meserverEntities();
        public List<business> GetBusinesses()
        {
            return db.business.ToList();
        }

        public business GetBusiness(int id)
        {
            return db.business.Where(x => x.busid == id).FirstOrDefault();
        }


        public bool SaveBusiness(business business)
        {
            try
            {
                db.business.Add(business);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool UpdateBusiness(long exeid, business business)
        {
            try
            {
                db.Entry(business).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteBusiness(int id)
        {
            try
            {
                var business = db.business.Where(x => x.busid == id).FirstOrDefault();
                if (business == null) return false;
                db.Entry(business).State = System.Data.Entity.EntityState.Deleted;
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