namespace FactoryMethodPattern.Transports
{
    public class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by land");
        }
    }
}
