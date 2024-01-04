using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public abstract class Factory
    {
        public static ITransport CreateTransport(string type) {
            if (type.Equals("truck")) {
                return new Truck();
            }
            else if (type.Equals("motorcycle")) {
                return new Motorcycle();
            } else {
                throw new Exception("There is no vehicle with the name of" + type);
            }
        }
    }
}
