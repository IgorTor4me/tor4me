using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tor4Me.Data;
using System.Data.Entity;



namespace Tor4Me.services.Services
{
    public class ExecuterService : IExecuterService
    {
        private DB_9EED4C_tor4meserverEntities db = new DB_9EED4C_tor4meserverEntities();
        public List<executers> GetExecuters()
        {
            return db.executers.ToList();
        }

        public executers GetExecuter(int id)
        {
            return db.executers.Where(x => x.exeid == id).FirstOrDefault();
        }


        public bool SaveExecuter(executers executer)
        {
            try
            {
                db.executers.Add(executer);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool UpdateExecuter(long exeid, executers executer)
        {
            try
            {
                db.Entry(executer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteExecuter(int id)
        {
            try
            {
                var executer = db.executers.Where(x => x.exeid == id).FirstOrDefault();
                if (executer == null) return false;
                db.Entry(executer).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }






        /*      public List<executers> GetExecuters(int busid)
              {
             //     return db.executers.ToList().Where(x => x.exebusid == busid).FirstOrDefault();;
               //   var executer= db.executers.Where(x => x.exebusid == busid).FirstOrDefault(); 
                /*  return db.executers.ToList()
                .Where(x => x.exebusid == busid)
                .Select(xx => new
                                 {
                                   id = xx.exeid,
                                   busid = xx.exebusid
                                 }));*/
        //    return db.executers.ToList().Where(x => x.exebusid == busid).SelectMany;
        //     } 

        /*   var employeeOptions = employees
           .SelectMany(e => empOptions
                              .Where(eo => eo.id == e.id)
                              .Select(eo => new
                              {
                                id = eo.id,
                                optionsCount = eo.optionsCount
                              }));

         foreach (var item in employeeOptions)
           Console.WriteLine(item);
       }*/
    }
}