using Cafeteria2.Model;
using Cafeteria2.Model.Enum;

namespace Cafeteria2.Manager
{
    public class CoffeeManager
    {
        public void CalculateCoffeePrice(Coffee coffee)
        {
            CalculateCoffeeFinalPrice(coffee);
            CalculateToppingsPrice(coffee);
            ApplyServicePrice(coffee);
        }

        private void CalculateCoffeeFinalPrice(Coffee coffee)
        {
            coffee.FinalPrice = coffee.GlassSize == GlassSize.Large
                ? coffee.BasePrice * 1.7
                : coffee.BasePrice;
        }

        private void CalculateToppingsPrice(Coffee coffee)
        {
            coffee.TotalPrice = coffee.FinalPrice;

            foreach (Topping topping in coffee.Toppings)
            {
                coffee.TotalPrice += topping.Price;
            }
        }

        private void ApplyServicePrice(Coffee coffee)
        {
            if (coffee.ServiceType == ServiceType.Coupon)
            {
                coffee.TotalPrice *= 0.95;
                return;
            }
            
            if (coffee.ServiceType == ServiceType.Takeway && coffee.TotalPrice <= 820)
            {
                coffee.TotalPrice *= 1.02;
            }
        }
    }
}
