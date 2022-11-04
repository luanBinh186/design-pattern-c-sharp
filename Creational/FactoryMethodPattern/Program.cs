
using FactoryMethodPattern.FactoryMethod;

namespace FactoryMethodPattern
{
    static class Program
    {

        public static void Main()
        {
            string methodLogistic = "Road";
            Logistic lg;
            switch (methodLogistic)
            {
                case "Road":
                    lg = new RoadLogistic();
                    lg.PlanDelivery();
                    break;
                case "Sea":
                    lg = new SeaLogistic();
                    lg.PlanDelivery();
                    break;
                default:
                    break;
            }
        }
    }
}