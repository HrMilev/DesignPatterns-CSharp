class Content
{
    private string input;
    private double output;

    public Content(string input)
    {
        this.input = input;
    }

    public string Input
    {
        get => input;
        set => input = value;
    }

    public double Output
    {
        get => output;
        set => output = value;
    }
}

