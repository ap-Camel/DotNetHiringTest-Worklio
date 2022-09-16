using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DotNetHiringTst_Worklio.Models;

namespace DotNetHiringTst_Worklio.Services
{
    public class CountriesApi
    {
        private readonly string url = "https://restcountries.com/v3.1/";

        private static HttpClient client = new HttpClient();

        public async Task<List<CountryModel>> getCountrisAsync()
        {

            List<CountryModel> countries = new List<CountryModel>();
            HttpResponseMessage response = await client.GetAsync(url + "all");
            if(response.IsSuccessStatusCode)
            {
                countries = await response.Content.ReadAsAsync<List<CountryModel>>();
            }

            return countries;
        }

        public async Task<CountryModel> getCountryAsync(string code)
        {
            CountryModel country = new CountryModel();
            HttpResponseMessage response = await client.GetAsync(url + "alpha/" + code);
            if (response.IsSuccessStatusCode)
            {
                country = (await response.Content.ReadAsAsync<List<CountryModel>>())[0];
            }

            return country;
        }
    }
}