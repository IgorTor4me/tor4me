using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tor4Me.Data;
using Tor4Me.Services.Services;

namespace Tor4Me.WebApi.Controllers
{
    public class businessController : ApiController
    {
           private IBusinessService businessService = new BusinessService();

           
            public IEnumerable<business> Get()
            {
                return businessService.GetBusinesses();
            }

            public IHttpActionResult GetById(int id)
            {
                var business = businessService.GetBusiness(id);
                if (business == null)
                    return NotFound();
                return Ok(business);
            }

            public IHttpActionResult Post(business business)
            {
                bool isSave = businessService.SaveBusiness(business);
                if (isSave == true)
                    return Ok();
                return BadRequest();
            }

            public IHttpActionResult Put(business business)
            {
                bool isUpdated = businessService.UpdateBusiness(business.busid, business);
                if (isUpdated == true)
                    return Ok();
                return BadRequest();
            }

            public IHttpActionResult Delete(int id)
            {
                bool isDeleted = businessService.DeleteBusiness(id);
                if (isDeleted == true)
                    return Ok();
                return BadRequest();
            }
        }
    }


