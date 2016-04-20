using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talent_Manager.Models;
namespace Talent_Manager.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            return new Employee[] { 
                new Employee { EmployeeId = 13, Name = "Hunain", FatherName = "Muhammad Zahid butt" },
               new Employee { EmployeeId = 13, Name = "Hunain", FatherName = "Muhammad Zahid butt" },
               new Employee {EmployeeId=14,Name="Hunain",FatherName="Muhammad Zahid butt" }
            };
        }

        // GET api/values/5
        public Employee Get(int id)
        {
            return new Employee() {EmployeeId=12,Name="Hunain",FatherName="Muhammad Zahid butt" }; 
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}