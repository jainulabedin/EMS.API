using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Data.Services.IData
{
    public interface IDep
    {
        List<Department> GetDepartments();
    }
}
