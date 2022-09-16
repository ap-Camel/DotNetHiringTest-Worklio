using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DotNetHiringTst_Worklio.Controllers
{
    public class TestController : ApiController
    {
        public IHttpActionResult getValues()
        {
            return Ok("hello this is return values");
        }

        public IHttpActionResult getValue(int id)
        {
            return Ok("value");
        }
    }
}
