using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public class SeaLogistic : Logistic
    {
        protected override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
