using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EMS.Data.Services.Data
{
    public partial class Emps
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmpDatabase;Integrated Security=True";
        public List<Employees> GetAllEmployee()
        {
            List<Employees> lstEmployee = new List<Employees>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Employees employee = new Employees();
                    employee.Empid = (int)sdr["Empid"];
                    employee.First_name = sdr["First_name"].ToString();
                    employee.Middle_name = sdr["Middle_name"].ToString();
                    employee.Last_name = sdr["Last_name"].ToString();
                    employee.Hobbies = sdr["Hobbies"].ToString();
                    employee.Salary = (int)sdr["Salary"];
                    employee.Gender = sdr["Gender"].ToString();
                    employee.Dep_name = sdr["Dep_name"].ToString();
                    employee.Des_name = sdr["Des_name"].ToString();
                    employee.Des_Id = (int)sdr["Des_Id"];
                    employee.Dep_Id = (int)sdr["Dep_Id"];


                    lstEmployee.Add(employee);
                }
                connection.Close();
            }
            return lstEmployee;
        }

        public void CreateEmp(Employees employee)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("CreateEmp", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@First_name", employee.First_name);
                cmd.Parameters.AddWithValue("@Middle_name", employee.Middle_name);
                cmd.Parameters.AddWithValue("@Last_name", employee.Last_name);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.Parameters.AddWithValue("@Hobbies", employee.Hobbies);
                cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                cmd.Parameters.AddWithValue("@Dep_Id", employee.Dep_Id);
                cmd.Parameters.AddWithValue("@Des_Id", employee.Des_Id);


                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void UpdateEmp(Employees employees)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmp", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Empid", employees.Empid);

                cmd.Parameters.AddWithValue("@First_name", employees.First_name);
                cmd.Parameters.AddWithValue("@Middle_name", employees.Middle_name);
                cmd.Parameters.AddWithValue("@Last_name", employees.Last_name);
                cmd.Parameters.AddWithValue("@Salary", employees.Salary);
                cmd.Parameters.AddWithValue("@Hobbies", employees.Hobbies);
                cmd.Parameters.AddWithValue("@Gender", employees.Gender);
                cmd.Parameters.AddWithValue("@Dep_Id", employees.Dep_Id);
                cmd.Parameters.AddWithValue("@Des_Id",employees.Des_Id);


                
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        public void DeleteEmp(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Empid", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
