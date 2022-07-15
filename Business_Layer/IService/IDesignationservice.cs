using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Layer.IService
{
    public interface IDesignationservice
    {
        List<Designation> GetDesignations();
    }
}
