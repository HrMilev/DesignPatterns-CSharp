using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibility
{
    public class SecondPipe : Pipeline
    {
        protected override void DoYourMagic(Request request)
        {
            request.Body += Environment.NewLine + "Second pipe was also useful";
        }
    }
}
