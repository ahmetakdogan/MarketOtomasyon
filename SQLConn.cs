using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace market
{
    class SQLConn
    {
        public static DBOperationsForSql DB = new DBOperationsForSql();
        SqlConnection con = new SqlConnection("Server=srvdev\atlas; database=BOAERP; Integrated Security=true;");
    }
}
