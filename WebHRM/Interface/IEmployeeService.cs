﻿using System.Text;
using WebHRM.DTO;
using WebHRM.Models;

namespace WebHRM.Interface
{

    public interface IEmployeeService
    {
        EmployeeInformationDto AddEmployee(EmployeeDto employeeDto);
        bool UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);
        bool DeleteEmployee(int id);
        //List<Accounts> GetAllEmployees();
        //ResponsePageAccountDto GetEmployees(AccountDto accountDto);
        List<ResponseSearchEmployee> SearchEmployee(RequestSearchEmployee requestSearchEmployee);
    }
}