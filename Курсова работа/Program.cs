using Project49.Builder_Pattern;
using Project49.Customer;
using Project49.Decorator_Pattern;
using Project49.Factory_Pattern;
using Project49.Order;
using Project49.Strategy_Pattern;
using Project49;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Dish burger = DishFactory.CreateDish("burger");
        burger = new CheeseDecorator(burger);

        Customer customer = new Customer
        {
            Name = "Иван",
            DiscountStrategy = new RegularCustomerDiscount()
        };

        Order order = new Order();
        order.Dishes.Add(burger);

        double total = order.GetTotal();
        total = customer.ApplyDiscount(total);

        ReceiptBuilder builder = new ReceiptBuilder();
        builder.AddHeader();
        builder.AddItem(burger.Name, burger.Price);
        builder.AddTotal(total);

        Console.WriteLine(builder.GetReceipt());
    }
}
