using Business_Layer.IService;
using EMS.Data.Services.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Service
{
    public class Emp:IEmp
    {
        private readonly IEmps emps;

        public Emp(IEmps emps)
        {
            this.emps = emps;
        }

        public void CreateEmployees(Employees employee)
        {
            emps.CreateEmployees(employee);
        }

        public void DeleteEmployees(int id)
        {
            emps.DeleteEmployees(id);
        }

        public List<Employees> GetEmployees()
        {
            List<Employees> employees = new List<Employees>();
            employees= emps.GetEmployees();
            return employees;
        }

        public void UpdateEmployees(Employees employees)
        {
           emps.UpdateEmployees(employees);
        }
    }
}
