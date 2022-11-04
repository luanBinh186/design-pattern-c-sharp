using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public abstract class Logistic
    {
        public void PlanDelivery()
        {
            ITransport t = CreateTransport();
            t.Deliver();
        }

        // Factory method
        protected abstract ITransport CreateTransport();
    }
}
