using Cafeteria2.Model.Enum;

namespace Cafeteria2.Model
{
    public class Coffee
    {
        public CoffeeType Type  { get; set; }
        public GlassSize GlassSize { get; set; }
        public double BasePrice { get; set; }
        public double FinalPrice { get; set; }
        public double TotalPrice { get; set; }
        public List<Topping> Toppings { get; set; }
        public ServiceType ServiceType { get; set; }

        public Coffee() 
        {
            TotalPrice = 0;
            Toppings = new List<Topping>();
        }

        public Coffee(CoffeeType type, GlassSize glassSize, double basePrice, ServiceType serviceType)
        {
            Type = type;
            GlassSize = glassSize;
            BasePrice = basePrice;
            ServiceType = serviceType;

            TotalPrice = 0;
            Toppings = new List<Topping>();
        }

        public Coffee(CoffeeType type, GlassSize glassSize, double basePrice, List<Topping> toppings, ServiceType serviceType)
        {
            Type = type;
            GlassSize = glassSize;
            BasePrice = basePrice;
            ServiceType = serviceType;

            TotalPrice = 0;
            Toppings = toppings;
        }
    }
}
