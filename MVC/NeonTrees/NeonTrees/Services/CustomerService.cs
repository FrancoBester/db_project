using Microsoft.Extensions.Configuration;
using NeonTrees.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using NeonTrees.Interface;

namespace NeonTrees.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly string _connectionString;

        public CustomerService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            List<Customer> customerList = new List<Customer>();

            try
            {
                using(OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Select * from Customer";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        string stest = reader.GetValue(0).ToString();
                          Customer _customer = new Customer
                          {
                              ID = int.Parse(reader.GetValue(0).ToString()),
                              Name = reader.GetValue(1).ToString(),
                              Surname = reader.GetValue(2).ToString(),
                              Phone = reader.GetValue(3).ToString(),
                              Email = reader.GetValue(4).ToString(),
                              Registered = char.Parse(reader.GetValue(5).ToString()),
                              LoginID = int.Parse(reader.GetValue(6).ToString()),
                          };
                        customerList.Add(_customer);
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }

            return customerList;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customer = new Customer();
            using(OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select * from Customer Where CustomerID = " + id + "";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Customer _customer = new Customer
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Name = reader.GetValue(1).ToString(),
                        Surname = reader.GetValue(2).ToString(),
                        Phone = reader.GetValue(3).ToString(),
                        Email = reader.GetValue(4).ToString(),
                        Registered = char.Parse(reader.GetValue(5).ToString()),
                        LoginID = int.Parse(reader.GetValue(6).ToString()),
                    };
                    customer = _customer;
                }
                con.Close();
            }
            return customer;
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Insert Into Customer(CustomerName,CustomerSurname,Phone,Email,Registered,LoginID) "+
                        "Values('"+customer.Name+"','"+customer.Surname+"','"+customer.Phone+"','"+customer.Email+"','"+customer.Registered+"',0)";
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

        public void EditCustomer(Customer customer)
        {
            try 
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Update Customer Set CustomerName = '" + customer.Name + "' ,CustomerSurname = '" + customer.Surname + "+" +
                        "',Phone = '" + customer.Phone + "',Email = '" + customer.Email + "' ,Registered = '" + customer.Registered + "' Where CustomerID ="+ customer.ID+"";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Delete From Customer Where CustomerID ="+customer.ID+"";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public int GetNewCustomerID(Customer customer)
        {
            int new_customer_id = -1;
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select CustomerID from Customer Where CustomerName = '" + customer.Name + "'AND CustomerSurname = '"+customer.Surname+"' AND email = '"+customer.Email+"'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    new_customer_id = int.Parse(reader.GetValue(0).ToString());
                }
            }
            return new_customer_id;
        }
    }
}
