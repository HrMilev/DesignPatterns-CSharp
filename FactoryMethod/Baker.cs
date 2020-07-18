class Baker
{
    public ICake MakeCakeFactoryMethod(int time)
    {
        if (time < 8 && time > 0)
        {
            return new ValinaCake();
        }
        else
        {
            return new ChocolateCake();
        }
    }
}
