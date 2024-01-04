using FactoryMethodPattern.FactoryMethod;
using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern
{
    static class Program
    {
        public static void Main()
        {
            ITransport truck = Factory.CreateTransport("truck");
            truck.Deliver(); // Xe tải đang giao hàng
            
            ITransport motorcycle = Factory.CreateTransport("motorcycle");
            motorcycle.Deliver(); // Xe máy đang giao hàng
        }
    }
}