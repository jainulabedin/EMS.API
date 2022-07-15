using Business_Layer.IService;
using EMS.Data.Services.Data;
using EMS.Data.Services.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.Service
{
    public class Designationservice : IDesignationservice
    {
        private readonly IDes des;
        public Designationservice(IDes des)
        {
        this.des=des;
        }

        public List<Designation> GetDesignations()
        {
           List<Designation> designations = new List<Designation>();
            designations=des.GetDesignations();
            return designations;
            
        }
    }
}
