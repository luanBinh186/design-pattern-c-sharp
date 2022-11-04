namespace FactoryMethodPattern.Transports
{
    public class Ship : Transport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by sea");
        }
    }
}
