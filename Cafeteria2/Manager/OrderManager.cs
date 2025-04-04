using Cafeteria2.Model;

namespace Cafeteria2.Manager
{
    public class OrderManager
    {
        public void CalculateOrderPrice(Order order)
        {
            CalculateCoffeesPrice(order);
        }

        public void CalculateCoffeesPrice(Order order)
        {
            foreach (Coffee coffee in order.Coffees)
            {
                order.TotalPrice += coffee.TotalPrice;
            }
        }

        public void PrintAsReceipt1(Order order)
        {
            Console.WriteLine("------- Order -------");
            Console.WriteLine("---- OrderItems: ----");
            foreach(Coffee coffee in order.Coffees)
            {
                Console.WriteLine($"Coffee: {coffee.Type}");
                Console.WriteLine($"Size: {coffee.GlassSize}");
                Console.WriteLine($"Price: {coffee.FinalPrice}");
                Console.WriteLine($"Service: {coffee.ServiceType}");
                
                if (!coffee.Toppings.Any()) break;
                Console.WriteLine("   Toppings:");
                foreach (Topping topping in coffee.Toppings)
                {
                    Console.WriteLine($"   Topping: {topping.Type}");
                    Console.WriteLine($"   Topping price: {topping.Price}");
                }
                Console.WriteLine("-----------------");
            }
            Console.WriteLine($"----- Amount: {order.TotalPrice} -----");

        }

        public void PrintAsReceipt(Order order)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("          CAFETERIA RECEIPT          ");
            Console.WriteLine("=====================================");
            Console.WriteLine($" Order Date: {DateTime.Now}");
            Console.WriteLine("-------------------------------------");

            foreach (Coffee coffee in order.Coffees)
            {
                Console.WriteLine($"{coffee.Type} ({coffee.GlassSize})".PadRight(30) + $" {coffee.FinalPrice,6:C}");
                Console.WriteLine($"   Service: {coffee.ServiceType}");

                if (coffee.Toppings.Any())
                {
                    Console.WriteLine("   + Toppings:");
                    foreach (Topping topping in coffee.Toppings)
                    {
                        Console.WriteLine($"     {topping.Type}".PadRight(30) + $"{topping.Price,6:C}");
                    }
                }
                Console.WriteLine("-------------------------------------");
            }

            Console.WriteLine("TOTAL AMOUNT:".PadRight(30) + $"{order.TotalPrice,6:C}");
            Console.WriteLine("=====================================");
            Console.WriteLine("    Thank you for your purchase!     ");
            Console.WriteLine("=====================================");
        }
    }
}
