using EMS.Data.Services.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Services.Data
{
  public partial class Dep : IDep
    {
        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            departments = GetAllDepartment();
                return departments;
        }
    }
}
