using Cafeteria2.Model;
using Cafeteria2.Manager;
using Cafeteria2.Model.Enum;

CoffeeManager coffeeManager = new CoffeeManager();
OrderManager orderManager = new OrderManager();

Topping topping11 = new Topping(ToppingType.Milk, 100);
Topping topping12 = new Topping(ToppingType.BrownSugar, 50);
List<Topping> toppings1 = new List<Topping>();
toppings1.Add(topping11);
toppings1.Add(topping12);

Coffee coffee1 = new Coffee(CoffeeType.Cappuccino, GlassSize.Large, 150, toppings1, ServiceType.Coupon);
coffeeManager.CalculateCoffeePrice(coffee1);

Coffee coffee2 = new Coffee(CoffeeType.Espresso, GlassSize.Regular, 100, ServiceType.InHouse);
coffeeManager.CalculateCoffeePrice(coffee2);

List<Coffee> coffees = new List<Coffee>();
coffees.Add(coffee1);
coffees.Add(coffee2);

Order order1 = new Order(coffees);
orderManager.CalculateOrderPrice(order1);

Console.WriteLine($"Order1: {order1.TotalPrice}");

orderManager.PrintAsReceipt(order1);