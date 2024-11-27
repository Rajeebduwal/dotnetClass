using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseExmaple
{
    class CrudeOperation
    {
        public void createTable()
        {
            try
            {
                //1.create connection string
                string cs = "Data Source=DESKTOP-1GSF0CC;Integrated Security=True;Connect Timeout=30;";
                //server name

                //2.create database
                SqlConnection conn = new SqlConnection(cs);

                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("connected with server");
                }
                conn.Open();//connection secured
                Console.WriteLine("connected with server");

                string tblquery = "create table tbl_reg (id int primary key,username varchar(50), password varchar(50),repassword varchar(50)," + "gender varchar(50),faculty varchar(50))";
                //executing query
                SqlCommand sc = new SqlCommand(tblquery, conn);
                sc.ExecuteNonQuery();//for create insert update and others
                Console.WriteLine("table created");
                Console.ReadLine();
                conn.Close();//closing connection
            }
            catch (Exception s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
