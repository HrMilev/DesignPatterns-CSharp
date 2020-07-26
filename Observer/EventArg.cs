using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class EventArg
    {
        public EventArg(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
