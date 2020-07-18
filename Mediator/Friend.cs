using System;

class Friend
{
    Multiphone phone;
    private string name;

    public Friend(Multiphone phone, string name )
    {
        this.phone = phone;
        phone.Sign(GetTheCall);
        this.name = name;
    }

    public void GetTheCall(string call,string from)
    {
        if (!from.Equals(name))
        {
            Console.WriteLine($"{name} is getting the call from {from}: {call}");
        }
    }

    public void MakeCall(string call)
    {
        Console.WriteLine($"{name} is making the call.");
        Console.WriteLine();
        phone.MakeCall(call,name);
    }
}
