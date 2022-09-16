using DotNetHiringTst_Worklio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;

namespace DotNetHiringTst_Worklio.Controllers
{
    public class CountriesController : ApiController
    {

        private readonly CountriesApi countriesApi;

        public CountriesController()
        {
            this.countriesApi = new CountriesApi();
        }


        // GET api/<controller>
        public async Task<IHttpActionResult> GetCountries()
        {
            var result = await countriesApi.getCountrisAsync();
            return Ok(result);
        }

        // GET api/<controller>/5
        [HttpGet]
        public async Task<IHttpActionResult> GetCountry(string id)
        {
            var result = await countriesApi.getCountryAsync(id);
            // result.Wait();
            return Ok(result);
        }

        //// POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}