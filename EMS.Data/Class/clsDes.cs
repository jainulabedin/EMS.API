using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EMS.Data.Services.Data
{
    public partial class Des
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmpDatabase;Integrated Security=True";
        public List<Designation> GetAllDesignaions()
        {
            List<Designation> lstdesignation = new List<Designation>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllDes", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Designation designation = new Designation();

                    designation.Des_Id = (int)sdr["Des_Id"];
                    designation.Des_Name = sdr["Des_name"].ToString();
                    lstdesignation.Add(designation);
                }
                connection.Close();
            }
            return lstdesignation ;
        
        }
    }
}
