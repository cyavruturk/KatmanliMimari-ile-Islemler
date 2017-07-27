using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.DAL.Repositories
{
    public class AbstractManagement    //Sql bağlama classımız
    {
        public SqlConnection _conn = new SqlConnection("Server=.;Database=EsnaflarDB;Integrated Security=True; MultipleActiveResultSets=True;");
    }
}
