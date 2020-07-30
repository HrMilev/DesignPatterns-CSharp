namespace FactoryMethod
{
    public class BiscuitFactory : IFactory
    {
        private readonly string secretIngredient;

        public BiscuitFactory(string secretIngredient)
        {
            this.secretIngredient = secretIngredient;
        }
        public IBakedGood GetSomeGood()
        {
            return new Biscuit(secretIngredient);
        }
    }
}
