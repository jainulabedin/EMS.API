using Business_Layer.IService;
using EMS.Data.Services.IData;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business_Layer.Service
{
    public class Department:IDepartment
    {
        private readonly IDep dep;
        public Department(IDep dep)
        {
            this.dep = dep;
        }

        public List<Model.Department> GetDepartments()
        {
            List<Model.Department> departments = new List<Model.Department>();
            departments = dep.GetDepartments();
            return departments;
        }
    }
}
