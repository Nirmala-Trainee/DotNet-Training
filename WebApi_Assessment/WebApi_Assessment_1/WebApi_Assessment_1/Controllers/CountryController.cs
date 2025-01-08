using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Assessment_1.Models;

namespace WebApi_Assessment_1.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "Canada", Capital = "Ottawa" }
        };


        [HttpGet]
        public IHttpActionResult GetAllCountries()
        {
            return Ok(countries);
        }

        [HttpGet]
        public IHttpActionResult GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            return Ok(country);
        }


        [HttpPost]
        public IHttpActionResult AddCountry(Country country)
        {
            if (country == null)
                return BadRequest("Invalid data.");

            countries.Add(country);
            return Created($"api/Country/{country.ID}", country);
        }

        [HttpPut]
        public IHttpActionResult UpdateCountry(int id, Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;
            return Ok(country);
        }


        [HttpDelete]
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();

            countries.Remove(country);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
