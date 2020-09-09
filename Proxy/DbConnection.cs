using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class DbConnection : IDbConnection
    {
        private readonly string _connectionString;

        public DbConnection(string connectionString)
        {
            //Some expensive to create object which is not used every time,
            //because of some access restrictions 
            _connectionString = connectionString;
        }

        public string Save(object obj)
        {
            return "Saved " + obj.ToString();
        }
    }
}
