using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("employee")]
        public EmployeeModel GetEmployeeDetails()
        {
            var emp = new EmployeeModel()
            {
                empNo = 101,
                empName = "Sunil",
                empDesignation = "Sales",
                empIsPermenant = true,
                empSalary = 25000
            };

            return emp;
        }

        [Route("emplist")]
        public List<EmployeeModel> GetEmployeeModelsList()
        {
            var empList = new List<EmployeeModel>()
            {
                new EmployeeModel(){ empNo=101, empName="Suman", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=102, empName="Mohan", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=103, empName="Karan", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=104, empName="Rohan", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=105, empName="Piya", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=106, empName="Riya", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=107, empName="Jiya", empDesignation="HR", empIsPermenant=true, empSalary=25000},
                new EmployeeModel(){ empNo=108, empName="Diya", empDesignation="HR", empIsPermenant=true, empSalary=25000},
            };

            return empList;
        }
    }
}