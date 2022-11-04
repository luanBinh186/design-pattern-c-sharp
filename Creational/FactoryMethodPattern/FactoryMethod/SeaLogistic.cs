using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public class SeaLogistic : Logistic
    {
        protected override Transport CreateTransport()
        {
            return new Ship();
        }
    }
}
