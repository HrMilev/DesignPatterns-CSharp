using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class DbConnectionProxy : IDbConnection
    {
        private readonly string _connectionString;
        private readonly int _int;

        public DbConnectionProxy(string connectionString)
        {
            //Lazy instantiate expensive object 
            _connectionString = connectionString;
            _int = new Random().Next(0, 10);
        }

        public string Save(object obj)
        {
            if (_int % 2 == 0)
            {
                return "No access for you";
            }
            else
            {
                var db = new DbConnection(_connectionString);
                return db.Save(obj);
            }
        }
    }
}
