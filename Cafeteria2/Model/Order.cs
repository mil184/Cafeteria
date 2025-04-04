using Cafeteria2.Model.Enum;

namespace Cafeteria2.Model
{
    public class Order
    {
        public List<Coffee> Coffees { get; set; }
        public double TotalPrice { get; set; }

        public Order() 
        {
            Coffees = new List<Coffee>();
            TotalPrice = 0;
        }

        public Order(List<Coffee> coffees)
        {
            Coffees = coffees;
            TotalPrice = 0;
        }
    }
}
