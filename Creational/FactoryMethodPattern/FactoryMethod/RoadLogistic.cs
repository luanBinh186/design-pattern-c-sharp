using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public class RoadLogistic : Logistic
    {
        protected override Transport CreateTransport()
        {
            return new Truck();
        }
    }
}
