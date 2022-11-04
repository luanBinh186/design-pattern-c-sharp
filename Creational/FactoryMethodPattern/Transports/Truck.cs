namespace FactoryMethodPattern.Transports
{
    public class Truck : Transport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by land");
        }
    }
}
