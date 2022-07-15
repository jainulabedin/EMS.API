using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.IService
{
    public interface IEmp
    {
        List<Employees> GetEmployees();
        void CreateEmployees(Employees employee);
        void UpdateEmployees(Employees employees);
        void DeleteEmployees(int id);
    }
}
