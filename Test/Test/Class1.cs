using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Test
{
    internal class Class1
    {
        private static String strCon = @"Data Source=LAPTOP-ISMPP6L8\SQLEXPRESS;Initial Catalog=account;Integrated Security=True";
        public SqlConnection GetConnection() {
            return new SqlConnection(strCon);        
        }
      
    }
}
