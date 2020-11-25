using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserService : IUserService
    {
        private readonly string _connectionString;
        public UserService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> userlist = new List<User>();
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    //con.Open();
                    //OracleCommand cmd = new OracleCommand();
                    //cmd.CommandText = "Select Column1 from Testing";
                    //cmd.Connection = con;
                    //cmd.CommandType = System.Data.CommandType.Text;
                    //OracleDataReader reader = cmd.ExecuteReader();
                    //while(reader.Read())
                    //{
                    //    string stest = reader.GetValue(0).ToString();
                    //}

                    using (OracleCommand cmd = con.CreateCommand())
                    {
                        int counter = 0;
                        con.Open();
                        cmd.CommandText = "Select Column1 from Testing";
                        OracleDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            string test = rdr.GetValue(0).ToString();
                            User stu = new User
                            {
                                Id = counter,
                                Name = test,
                            };
                            userlist.Add(stu);
                            counter++;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
            return userlist;
        }

        public User GetUserById(int eid)
        {
            User student = new User();
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                
                using (OracleCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "Select * from Testing where Column1='Franco'";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        User stu = new User
                        {
                            Id = 1,
                            Name = rdr.GetValue(0).ToString(),
                        };
                        student = stu;
                    }
                    //cmd.Dispose();
                    //rdr.Close();
                }
                
                con.Close();
            }
            return student;
        }

        public void AddUser(User user) 
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    //OracleCommand cmd = new OracleCommand();
                    //cmd.CommandText = "Select * from "
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Insert Into Testing(Column1) Values('"+user.Name+"')";
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                   
                    //using (OracleCommand cmd = new OracleCommand())
                    //{
                    //    con.Open();
                    //    cmd.CommandText = cmd.CommandText = "Select Column1 from Testing";
                    //    OracleDataReader rdr = cmd.ExecuteReader();
                    //    //cmd.CommandText = "Insert into Testing(Column1) Values('" + user.Name + "')";
                    //    //cmd.ExecuteNonQuery();
                    //}
                }
            }
            catch(Exception ex)
            {
                string test = ex.ToString();
                throw;
            }
        }
        public void EditUser(User user)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Update Testing Set COlumn1='" + user.Name + "' where Column1 ='Franco'";
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //using (OracleCommand cmd = new OracleCommand())
                    //{
                    //    con.Open();
                    //    cmd.CommandText = "Update Testing Set COlumn1='" + user.Name + "' where Column1 ='Franco'";
                    //    cmd.ExecuteNonQuery();
                    //}
                }
            }
            catch
            {
                throw;
            }
        }
        public void DeleteUser(User user)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    string test = user.Id.ToString();
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Delete from Testing Where Column1='"+ test +"'";
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    //using (OracleCommand cmd = new OracleCommand())
                    //{
                    //    con.Open();
                    //    cmd.CommandText = "Delete from Student where Id=" + user.Id + "";
                    //    cmd.ExecuteNonQuery();
                    //}
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

