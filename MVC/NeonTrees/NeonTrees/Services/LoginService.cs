using Microsoft.Extensions.Configuration;
using NeonTrees.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.AspNetCore.Http;

namespace NeonTrees.Services
{
    public class LoginService : ILoginService
    {
        private readonly string _connectionString;

        public LoginService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public bool GetLoginByUser(Login login)
        {
            bool isValid = false;
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select * from Login Where userName = '" + login.Name + "' AND password = '"+login.Password+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        public void EditLogin(Login login)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Update Login Set Password = '" + login.Password + "', username = '" + login.Name + "' Where loginID = '" + login.ID + "'";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void AddLogin(Login login)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into Login(CustomerID,Password,Username)" +
                        "Values(" + login.CustomerID + ",'" + login.Password + "','" + login.Name + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void DeleteLogin(Login login)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Delete From Login Where LoginID = " + login.ID + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public int GetNewLoginId(Login login)
        {
            int new_login_id = -1;
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Select loginID from login where CustomerID = "+login.CustomerID+" AND Password = '"+ login.Password +"' and username = '"+ login.Name +"'";
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        new_login_id = int.Parse(reader.GetValue(0).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }

            return new_login_id;
        }
    }
}
