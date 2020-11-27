﻿using Microsoft.Extensions.Configuration;
using NeonTrees.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace NeonTrees.Services
{
    public class LoginService : ILoginService
    {
        private readonly string _connectionString;

        public LoginService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public Login GetLoginByUser(string username)
        {
            Login login = new Login();
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select * from Login Where userName = '" + username + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Login _login = new Login
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        CustomerID = int.Parse(reader.GetValue(1).ToString()),
                        password = reader.GetValue(2).ToString(),
                        userName = reader.GetValue(3).ToString()
                    };
                    login = _login;
                }
            }
            return login;
        }

        public void EditLogin(Login login)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Update Login Set Password = '" + login.password + "', username = '" + login.userName + "' Where loginID = '" + login.ID + "'";
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
                using (OracleConnection con = new OracleConnection())
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "Insert into Login(CustomerID,Password,Username)" +
                        "Values(" + login.ID + ",'" + login.password + "','" + login.userName + "')";
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
    }
}
