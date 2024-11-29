using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseExmaple
{
    class CrudOperation
    {
        public void createTable() 
        {
            try
            {
                //1. create connection string
                string cs = "Data Source=DESKTOP-1GSF0CC;Initial Catalog=db_nccs; Integrated Security=true;Trusted_Connection = True";
                // server name                                          database name           windowm authentication

                //2. creating connection
                SqlConnection conn = new SqlConnection(cs);
                
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connected with server");
                }
                conn.Open();// connection secured
                Console.WriteLine("connected");

                string tblquery = "create table tbl_reg (id int primary key," + "username varchar(50), password varchar(50), repassword varchar(50)," +
                                "gender varchar(50), faculty varchar(50))";
                // executing query
                SqlCommand sc= new SqlCommand(tblquery, conn);
                sc.ExecuteNonQuery();// for create insert update and delete
                Console.WriteLine("table created");
                conn.Close();// closing connection
            }
            catch (Exception s)
            {
                Console.WriteLine(s);
            }
        }
        // inserting data into table
        public void insertData()
        {
            try
            {
                string cs = "Data Source=DESKTOP-1GSF0CC;Initial Catalog=db_nccs; Integrated Security=true;Trusted_Connection = True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                // writing query for inserting data
                //string insquery = "insert into tbl_reg values(1, 'pukar', 'abcd', 'abcd', 'male', 'csit')";
                Console.WriteLine("enter your id");
                string id= Console.ReadLine();
                Console.WriteLine("Enter Username");
                string uname=Console.ReadLine();
                Console.WriteLine("Enter Password");
                string pass=Console.ReadLine();
                Console.WriteLine("ReEnter Password");
                string repass= Console.ReadLine();
                Console.WriteLine("Enter Gender");
                string gen = Console.ReadLine();
                Console.WriteLine("Enter Faculty");
                string fac=Console.ReadLine();
                // writing insert query using prepared statement(paramete)
                string insquery1 = "insert into tbl_reg values(@id, @username, @password, @repassword,@gender, @faculty)";
                SqlCommand sc= new SqlCommand(insquery1, conn);
                sc.Parameters.AddWithValue("id", id);
                sc.Parameters.AddWithValue("username", uname);
                sc.Parameters.AddWithValue("password", pass);
                sc.Parameters.AddWithValue("repassword", repass);
                sc.Parameters.AddWithValue("gender", gen);
                sc.Parameters.AddWithValue("faculty", fac);
                int res=sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + " Data inserted");
                }
                conn.Close() ;
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
            
        }
        public void updateData()
        {
            try
            {
                string cs = "Data Source=DESKTOP-1GSF0CC;Initial Catalog=db_nccs; Integrated Security=true;Trusted_Connection = True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                // update query
                string upquery = "update tbl_reg set username='mandish',faculty='bim' where id=100";
                SqlCommand sc = new SqlCommand(upquery, conn);
                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + " Data inserted");
                }
                conn.Close();

            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
        }
        // update table dynamically
        //fetch data from database
        public void displayData()
        {
            try
            {
                string cs = "Data Source=DESKTOP-1GSF0CC;Initial Catalog=db_nccs; Integrated Security=true;Trusted_Connection = True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                //fetch query
                string disQuery = "select *from tbl_reg";
                SqlCommand sc=new SqlCommand(disQuery,conn);
                //to fecth data executeReader() method is used, it returns object of sqlDataReader that contains all the base of databse table
                SqlDataReader row=sc.ExecuteReader();
                //it contains all the row of table. to fetch one row at a time read() method is used
                while (row.Read())
                {
                    Console.WriteLine("id is " + row["id"]);
                    Console.WriteLine("username is " + row["username"]);
                    Console.WriteLine("password " + row["password"]);
                    Console.WriteLine("repassword  is " + row["repassword"]);
                    Console.WriteLine("gender is " + row["gender"]);
                    Console.WriteLine("faculty is " + row["faculty"]);
                   

                }
                conn.Close ();
            }
            catch(SqlException s)
            {
                Console.WriteLine(s);
            }
        }
        public void delData()
        {
            try
            {
                string cs = "Data Source=DESKTOP-1GSF0CC;Initial Catalog=db_nccs; Integrated Security=true;Trusted_Connection = True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                //fetch query
                string delQuery = "delete from tbl_reg where id=@id";
                Console.WriteLine("Enter id of a person which you want to del record");
                string delId=Console.ReadLine();    
                SqlCommand sc = new SqlCommand(delQuery, conn);
                sc.Parameters.AddWithValue("id",delId);
                int res=sc.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine(res + "data deleted");
                }
                conn.Close();
            }
            catch (SqlException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}