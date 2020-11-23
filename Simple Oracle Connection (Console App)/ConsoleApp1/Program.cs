using System;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = "Data Source=localhost:1521/ORCL;User Id=SYSTEM;Password=Operator12;";

            using (OracleConnection con = new OracleConnection(conString))
            {
                using OracleCommand cmd = con.CreateCommand();
                try
                {
                    con.Open();
                    cmd.BindByName = true;

                    //use the table
                    cmd.CommandText = "select * from EMPLOYEE";

                    //assign id to 50
                    OracleParameter id = new OracleParameter("id", 50);
                    cmd.Parameters.Add(id);

                    //execute the cmd and use DataReader
                    OracleDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("Some data e.g employee Name: " + reader.GetString(0));
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");

                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
