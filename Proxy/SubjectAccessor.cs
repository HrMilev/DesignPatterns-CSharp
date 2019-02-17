using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubjectAccessor 
{

    private class Subject
    {
        public string Request() => "Subject Request \n";
    }

    public class Proxy : ISubject
    {
        Subject subject;

        public string Request()
        {
            if (subject == null)
            {
                Console.WriteLine("Subject inactive");
                subject = new Subject();
            }
            Console.WriteLine("Subject active");
            return "Proxy: Call to " + subject.Request();
        }

    }
    public class ProtectionProxy : ISubject
    {
        Subject subject;
        string password = "bla";

        public string Authenticate (string supplied)
        {
            if (supplied!=password)
            {
                return "Protection Proxy: Access denied";
            }
            else
            {
                subject = new Subject();
                return "Protection Proxy: Authenticated";
            }
        }

        public string Request()
        {
            if (subject==null)
            {
                return "Protection Proxy: Authenticate first";
            }
            else
            {
                return "Protection Proxy: Call to " + subject.Request();
            }
        }
    }
}
