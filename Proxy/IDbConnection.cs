using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public interface IDbConnection
    {
        string Save(object obj);
    }
}
