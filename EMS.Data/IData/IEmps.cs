using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Services.IData
{
   public  interface IEmps
    {
        List<Employees> GetEmployees();
        void CreateEmployees(Employees employee);
        void UpdateEmployees(Employees employees);
        void DeleteEmployees(int id);
     
    }
}
