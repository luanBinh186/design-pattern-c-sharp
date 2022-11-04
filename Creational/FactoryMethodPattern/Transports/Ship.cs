namespace FactoryMethodPattern.Transports
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by sea");
        }
    }
}
