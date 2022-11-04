using FactoryMethodPattern.Transports;

namespace FactoryMethodPattern.FactoryMethod
{
    public abstract class Logistic
    {
        public void PlanDelivery()
        {
            Transport t = CreateTransport();
            t.Deliver();
        }
        protected abstract Transport CreateTransport();
    }
}
