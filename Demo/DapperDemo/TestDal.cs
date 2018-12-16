using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public class TestDal
    {
        public void Query()
        {
            IDbConnection connection = new SqlConnection(@"Data Source=EUHHCGSHQ4AXIOM\SQLSERVERR2;Initial Catalog=techsung;User ID=sa;Password=wthf0515");

            var result = connection.Query<Test>("select * from test");
        }
    }
}
