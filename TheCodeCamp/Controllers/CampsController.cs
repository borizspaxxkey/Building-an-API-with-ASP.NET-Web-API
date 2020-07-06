using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new { Name = "Shawn", Occupation = "Teacher" });
        }
    }
}
