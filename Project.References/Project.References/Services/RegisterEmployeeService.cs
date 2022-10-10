using Project.References.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.References.Services
{
    public class RegisterEmployeeService
    {
        public OutputRegisterEmployee ProcessRegister(InputCliente input)
        {
            var dadosDto = new EmployeeDTO();
            var output = new OutputRegisterEmployee();

            dadosDto.AnoNasc = (DateTime.Now.Year - input.Idade);

            if(dadosDto.AnoNasc <= 2004)
            {
                output.Status = true;
            }
            else { output.Status = false; }

            return output;
        }
    }
}