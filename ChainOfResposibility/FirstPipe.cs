using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibility
{
    public class FirstPipe : Pipeline
    {
        protected override void DoYourMagic(Request request)
        {
            request.Body += Environment.NewLine + "First pipe did something meaningful";
        }
    }
}
