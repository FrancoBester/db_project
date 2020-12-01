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
    public class BuildService : IBuildService
    {
        private readonly string _connectionString;

        public BuildService(IConfiguration _configuration)
        {
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IEnumerable<Build> GetAllBuilds()
        {
            List<Build> buildList = new List<Build>();

            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Select * from Build";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Build _build = new Build
                        {
                            ID = int.Parse(reader.GetValue(0).ToString()),
                            CustomerID = int.Parse(reader.GetValue(2).ToString()),
                            Date = DateTime.Parse(reader.GetValue(1).ToString()).Date,
                            Total = double.Parse(reader.GetValue(3).ToString()),
                            OrderDetails = reader.GetValue(4).ToString(),
                        };
                        buildList.Add(_build);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
            return buildList;
        }

        public Build GetBuildById(int id)
        {
            Build build = new Build();
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select * from Build Where BuildID = " + id + "";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Build _build = new Build
                    {
                        ID = int.Parse(reader.GetValue(0).ToString()),
                        Date = DateTime.Parse(reader.GetValue(1).ToString()),
                        Total = double.Parse(reader.GetValue(3).ToString()),
                        OrderDetails = reader.GetValue(4).ToString(),
                        ProductIDs = reader.GetValue(5).ToString(),
                    };
                    build = _build;
                }

            }
            return build;
        }

        public int GetBuildId(Build build)
        {
            string buildDate = ConvertDate(build.Date);
            int build_id = -1;
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "Select * from Build Where  customerId = " + build.CustomerID + " and buildDate = '" + buildDate + "'";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    build_id = int.Parse(reader.GetValue(0).ToString());
                }

            }
            return build_id;
        }

        public void AddBuild(Build build)
        {
            try
            {
                string formated_date = ConvertDate(build.Date);
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    //cmd.CommandText = "Insert into Build(Builddate,customerID,Total,ORderDetails,ProductID)" +
                    //    "Values('"+ formated_date + "',0," + build.Total + ",'" + build.OrderDetails + "','"+build.ProductIDs+"')";

                    cmd.CommandText = "Insert into Build(Builddate,customerID,Total,ORderDetails,ProductIds)" +
                        "Values('" + formated_date + "'," + build.CustomerID + "," + build.Total + ",'" + build.OrderDetails + "','" + build.ProductIDs + "')";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void EditBuild(Build build)
        {
            try
            {
                string formated_date = ConvertDate(build.Date);
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Update build Set Builddate = '" + formated_date + "',Total = " + build.Total + ",OrderDetails = '" + build.OrderDetails + "', productIDs = '" + build.ProductIDs + "' Where BuildID = " + build.ID + "";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void DeleteBuild(Build build)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Delete From Build Where BuildID =" + build.ID + "";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void DeleteBuildId(int id)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Delete From Build Where CustomerID =" + id + "";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        private string ConvertDate(DateTime model_date)
        {
            string returnValue = model_date.Day.ToString() + "/";
            int month = model_date.Month;

            switch (month)
            {
                case 1:
                    returnValue = returnValue + "JAN/";
                    break;
                case 2:
                    returnValue = returnValue + "FEB/";
                    break;
                case 3:
                    returnValue = returnValue + "MAR/";
                    break;
                case 4:
                    returnValue = returnValue + "APR/";
                    break;
                case 5:
                    returnValue = returnValue + "MAY/";
                    break;
                case 6:
                    returnValue = returnValue + "JUN/";
                    break;
                case 7:
                    returnValue = returnValue + "JUL/";
                    break;
                case 8:
                    returnValue = returnValue + "AUG/";
                    break;
                case 9:
                    returnValue = returnValue + "SEP/";
                    break;
                case 10:
                    returnValue = returnValue + "OCT/";
                    break;
                case 11:
                    returnValue = returnValue + "NOV/";
                    break;
                case 12:
                    returnValue = returnValue + "DEC/";
                    break;
            }

            string year = model_date.Year.ToString();
            returnValue = returnValue + year[2] + year[3];

            return returnValue;
        }

        public List<int> GetBuildPriceData()
        {
            List<int> repeat_total = new List<int>();
            try
            {
                double value = MaxBuildCost();
                int total = Convert.ToInt32(value);
                for (int i = 0; i < total; i += 5001)
                {
                    using (OracleConnection con = new OracleConnection(_connectionString))
                    {

                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = "Select count(*) from Build Where Total  Between " + i + " ANd " + (i + 5000) + "";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            repeat_total.Add(int.Parse(reader.GetValue(0).ToString()));
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
            return repeat_total;
        }

        private double MaxBuildCost()
        {
            double maxTotal = 0;
            using (OracleConnection con = new OracleConnection(_connectionString))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select Max(Total) from Build";
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    maxTotal = double.Parse(reader.GetValue(0).ToString());
                }
            }
            return maxTotal;
        }

        public List<int> GetBuildPerMonth()
        {
            List<int> info_list = new List<int>();
            string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            string year_string = (DateTime.Now.Year).ToString();
            string year_short = year_string[2].ToString() + year_string[3].ToString();
            string start_date, end_date, month;

            try
            {
                for (int i = 1; i < 13; i++)
                {
                    int montharr = i - 1;
                    month = months[montharr];

                    start_date = "01/" + month + "/" + year_short;

                    if (i == 2)
                    {
                        end_date = "28/" + month + "/" + year_short;
                    }
                    else if (i == 4 || i == 6 || i == 9 || i == 11)
                    {
                        end_date = "30/" + month + "/" + year_short;
                    }
                    else
                    {
                        end_date = "31/" + month + "/" + year_short;
                    }


                    using (OracleConnection con = new OracleConnection(_connectionString))
                    {
                        con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.CommandText = "Select count(*) from Build Where buildDate between '" + start_date + "' and '" + end_date + "'";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        OracleDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            info_list.Add(int.Parse(reader.GetValue(0).ToString()));
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }

            return info_list;
        }

        public IEnumerable<Build> GetAllUserBuilds(int user_id)
        {
            List<Build> buildList = new List<Build>();
            try
            {
                using (OracleConnection con = new OracleConnection(_connectionString))
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.CommandText = "Select * from Build Where customerid = " + user_id + "";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Build _build = new Build
                        {
                            ID = int.Parse(reader.GetValue(0).ToString()),
                            CustomerID = int.Parse(reader.GetValue(2).ToString()),
                            Date = DateTime.Parse(reader.GetValue(1).ToString()).Date,
                            Total = double.Parse(reader.GetValue(3).ToString()),
                            OrderDetails = reader.GetValue(4).ToString(),
                        };
                        buildList.Add(_build);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
            return buildList;
        }
    }
}
