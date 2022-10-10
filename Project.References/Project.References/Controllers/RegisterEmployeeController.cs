using Project.References.Models;
using Project.References.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Project.References.Controllers
{
    [Route("Api/Register")]
    public class RegisterEmployeeController: ApiController
    {
        [HttpPost]
        public IHttpActionResult IsertData([FromBody] InputCliente input)
        {
            var registerEmployeeService = new RegisterEmployeeService();
             var output = registerEmployeeService.ProcessRegister(input);


               return Ok(output) ;
        }

    }
}