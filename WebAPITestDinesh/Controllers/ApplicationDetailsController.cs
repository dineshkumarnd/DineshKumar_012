using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPITestDinesh.Models;

namespace WebAPITestDinesh.Controllers
{
    public class ApplicationDetailsController : ApiController
    {
        private DatabaseWepAPITestDineshEntities db = new DatabaseWepAPITestDineshEntities();


        [HttpGet]
        [Route("api/ApplicationDetail")]
        public HttpResponseMessage GetApplicationDetail()
        {
            try
            {
                if (db.ApplicationDetails != null)//Check Database Object
                {
                    var Data = new //Data Object
                    {
                        db.ApplicationDetails//Get Data from Database using Entity Frame work
                    };
                   return Request.CreateResponse(HttpStatusCode.OK, Data);//ReturnvResponse Data
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest,"No data Found");//Return No data Found Response
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,"Some thing went wrong");//Return Error Response
            }
            
        }

    }
}