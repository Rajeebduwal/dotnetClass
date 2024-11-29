using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//tp connect to SQl and for sql lang
//to connect with the eternal datasource like sql server,xml file,sql client
//packet should be imported
//steps to connect with database
//1.create connection string that have all the parameter required to connect with database
//2.

namespace DatabaseExmaple
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudOperation co = new CrudOperation();
            //co.insertData();
            //co.updateData();
            co.displayData();
            co.delData();
            co.displayData();
            Console.ReadLine();
        }
    }
}
