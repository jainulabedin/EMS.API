using EMS.Data.Services.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Services.Data
{
   public partial class Emps :IEmps
    {
        public List<Employees> GetEmployees()
        {
            List<Employees> employees = new List<Employees>();
            employees = GetAllEmployee();
            return employees;
        }
        public void CreateEmployees(Employees employees)
        {
            CreateEmp(employees);
        }
        public void UpdateEmployees(Employees employees)
        {
            UpdateEmp(employees);
        }
        public void DeleteEmployees(int id)
        {
            DeleteEmp(id);
        }
    }
}

