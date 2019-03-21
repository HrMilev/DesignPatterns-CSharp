class Multiphone
{
    public delegate void Call(string call, string from);
    Call innerCall;

    public void Sign(Call method)
    {
        innerCall += method;
    }

    public void MakeCall(string call,string from)
    {
        innerCall(call, from);
    }
}
