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
                    cmd.CommandText = "Select * from Student where Id=" + eid + "";
                    OracleDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        User stu = new User
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString(),
                        };
                        student = stu;
                    }
                }
            }
            return student;
        }

        public void AddUser(User user)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Insert into Student(Id, Name, Email)Values(" + user.Id + ",'" + user.Name + "')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
        public void EditUser(User user)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Update Student Set Name='" + user.Name + "' where Id=" + user.Id + "";
                        cmd.ExecuteNonQuery();
                    }
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
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        con.Open();
                        cmd.CommandText = "Delete from Student where Id=" + user.Id + "";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

