using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client 
{
    static void Main(string[] args)
    {
        ISubject subject = new SubjectAccessor.Proxy();
        Console.WriteLine(subject.Request());
        Console.WriteLine(subject.Request());

        subject = new SubjectAccessor.ProtectionProxy();
        Console.WriteLine(subject.Request());
        Console.WriteLine((subject as SubjectAccessor.ProtectionProxy).Authenticate("gru"));
        Console.WriteLine((subject as SubjectAccessor.ProtectionProxy).Authenticate("bla"));
        Console.WriteLine(subject.Request());

    }
}
