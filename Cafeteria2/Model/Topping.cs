using Cafeteria2.Model.Enum;

namespace Cafeteria2.Model
{
    public class Topping
    {
        public ToppingType Type { get; set; }
        public double Price { get; set; }

        public Topping() { }

        public Topping(ToppingType type, double price)
        {
            Type = type;
            Price = price;
        }
    }
}
