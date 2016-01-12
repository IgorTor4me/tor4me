using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tor4Me.Data;
using Tor4Me.Services.Services;

namespace Tor4Me.WebAPi.Controllers
{
    public class serviceController : ApiController
    {
        private IServicesService serviceService = new ServicesService();


        public IEnumerable<service> Get()
        {
            return serviceService.GetServices();
        }

        public IHttpActionResult GetById(int id)
        {
            var service = serviceService.GetService(id);
            if (service == null)
                return NotFound();
            return Ok(service);
        }

        public IHttpActionResult Post(service service)
        {
            bool isSave = serviceService.SaveService(service);
            if (isSave == true)
                return Ok();
            return BadRequest();
        }

        public IHttpActionResult Put(service service)
        {
            bool isUpdated = serviceService.UpdateService(service.servid, service);
            if (isUpdated == true)
                return Ok();
            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            bool isDeleted = serviceService.DeleteService(id);
            if (isDeleted == true)
                return Ok();
            return BadRequest();
        }

    }
}
