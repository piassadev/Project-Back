using Project.References.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

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
                var add = new AddEmplooye(input.Name, input.Idade);
                MessageBox.Show(add.mensagem);

                            }
            else { output.Status = false; }

            return output;
        }
    }
}