using EMS.Data.Services.IData;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Services.Data
{
    public partial class Des:IDes
    {
        public List<Designation> GetDesignations()
        {
            List<Designation> designations = new List<Designation>();
            designations = GetAllDesignaions();
            return designations;
        }
    }
}
