using System;

namespace Builder
{
    public class Client
    {
        static void Main()
        {
            IJwtSecurityTokenBuilder builder = new JwtSecurityTokenBuilder();
            Console.WriteLine("Constructing of the object");
            builder.Issuer = Console.ReadLine();
            Console.WriteLine("Can be separated in different places");
            builder.Audience = Console.ReadLine();
            Console.WriteLine("In code and can be build when it is needed:");
            Console.WriteLine(builder.Build().ToString());
        }
    }
}
