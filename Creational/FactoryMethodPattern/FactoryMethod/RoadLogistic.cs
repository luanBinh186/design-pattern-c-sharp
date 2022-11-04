using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public class RoadLogistic : Logistic
    {
        protected override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
