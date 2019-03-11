public class NewOldHouse : OldHouse, IRenovator
{
    public string WithNew(int story)
    {
        return With(story) + " and now i am shiny as new!";
    }
}
