using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado_net
{
    class Correct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Industries");
            // goto testc;
            while (true)
            {
                Console.WriteLine("Enter Company to Search for company Industries or for exit type exit");
                string company = Console.ReadLine();
                if (company == "exit")
                {
                    return;
                }
                else
                {
                    string query = "select IndustryId from [dbo].[Industries] where JSON_VALUE(IndustriesData,'$.Industry.Software.CompanyName') = '" + company + "' or JSON_VALUE(IndustriesData,'$.Industry.Hardware.CompanyName') ='" + company + "'";
                    SqlConnection con = null;
                    try
                    {
                        con = new SqlConnection("data source=.; database=Hemadri; integrated security=SSPI");
                        SqlCommand cm = new SqlCommand(query, con);
                        con.Open();
                        SqlDataReader sdr = cm.ExecuteReader();
                        int count = 0;
                        while (sdr.Read())
                        {
                            count += 1;
                            Console.WriteLine("Country:" + sdr[0]);
                            //Console.WriteLine(" CLASS : " + sdr["class"] + " SUB1 : " + sdr["sub1"] + " SUB2 : " + sdr["sub2"] + " SUB3 : " + sdr["sub3"] + "ID : " + sdr["rollNo"] + "  NAME : " + sdr["name"]);
                        }
                        if (count == 0)
                        {
                            Console.WriteLine("not exist this company:" + company + "please check spelling oops went wrong your search again");
                        }
                        //Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("OOPs, something went wrong.\n" + e);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }
    }
}