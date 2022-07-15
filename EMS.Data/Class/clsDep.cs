using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EMS.Data.Services.Data
{
    public partial class Dep
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmpDatabase;Integrated Security=True";
        public List<Department> GetAllDepartment()
        {
            List<Department> lstdepartments = new List<Department>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllDep", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Department department = new Department();

                    department.Dep_Id = (int)sdr["Dep_Id"];
                    department.Dep_name = sdr["Dep_name"].ToString();
                    lstdepartments.Add(department);
                }
                connection.Close();
            }
            return lstdepartments;  
        }
    }
}
