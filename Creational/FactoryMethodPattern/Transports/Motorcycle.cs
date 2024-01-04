namespace FactoryMethodPattern.Transports
{
    public class Motorcycle : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Motorcycle");
        }
    }
}
