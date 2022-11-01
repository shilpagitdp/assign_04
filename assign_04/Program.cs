using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_04_C_sharp_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConnectionStr = "Data Source=INLPF2KZ387\\MSSQLSERVER1;initial catalog=Ivy;trusted_connection=true";
            SqlConnection sqlconn = new SqlConnection(ConnectionStr);

                SqlConnection conn = new SqlConnection(connection);
                conn.Open();

                Console.WriteLine("Enter the Name:");
                string name = Console.ReadLine();



                SqlCommand cmd = new SqlCommand("p2", conn);
                // SqlCommand cmd1 = new SqlCommand("p1", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd1.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@d_s_name", System.Data.SqlDbType.VarChar).Value = name;

                // cmd1.Parameters.Add("@s_name", System.Data.SqlDbType.VarChar).Value = name;

                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine();
                while (reader.Read())
                {

                    Console.Write("\n" + reader[0] + "  ");
                    Console.Write(reader[1] + "  ");
                    Console.WriteLine();

                }
                reader.Close();
                // SqlDataReader reader_p1 = cmd1.ExecuteReader();
                // Console.WriteLine();
                // while (reader_p1.Read())
                // {
                //     Console.Write("\n"+reader_p1[0] + "  ");
                //     Console.WriteLine(reader_p1[1] + "  ");
                // }

                Console.WriteLine("Code Running Successfully successfully");

                // reader_p1.Close();
                conn.Close();
            }
            catch (SqlException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine("SQL Based Error!!");
            }
            catch (Exception ep)
            {
                Console.WriteLine(ep.Message);
                Console.WriteLine("C-Sharp Based Error!!");
            }
        }
    }
}
