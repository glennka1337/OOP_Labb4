namespace OOP_Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            MenuItem pizza = new MenuItem(1, "Pizza", 120);
            MenuItem hamburger = new MenuItem(2, "Hamburgare", 115);
            MenuItem fries = new MenuItem(3, "Pommes", 35);
            MenuItem carbonara = new MenuItem(4, "Carbonara", 145);

            restaurant.AddToMenu(pizza);
            restaurant.AddToMenu(hamburger);
            restaurant.AddToMenu(fries);
            restaurant.AddToMenu(carbonara);

            restaurant.ShowMenu();

            List<MenuItem> order1 = new List<MenuItem>();
            order1.Add(hamburger);
            order1.Add(fries);
            order1.Add(pizza);
            Order table1 = new Order(order1, 1);
            restaurant.CreateOrder(table1);
            
            List<MenuItem> order2 = new List<MenuItem>();
            order2.Add(carbonara);
            order2.Add(carbonara);
            order2.Add(pizza);
            order2.Add(hamburger);
            Order table2 = new Order(order2, 2);
            restaurant.CreateOrder(table2);

            List<MenuItem> order3 = new List<MenuItem>();
            order3.Add(hamburger);
            order3.Add(hamburger);
            order3.Add(fries);
            order3.Add(carbonara);
            order3.Add(pizza);
            Order table3 = new Order(order3, 3);
            restaurant.CreateOrder(table3);

            restaurant.ShowOrders();

            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();

            restaurant.HandleOrder();

            restaurant.ShowOrderCount();

            List<MenuItem> order4 = new List<MenuItem>();
            order4.Add(hamburger);
            order4.Add(pizza);
            order4.Add(fries);
            order4.Add(carbonara);
            Order table4 = new Order(order4, 4);
            restaurant.CreateOrder(table4);

            restaurant.ShowOrderCount();

            restaurant.HandleOrder();
            restaurant.HandleOrder();

            restaurant.ShowOrderCount();

            restaurant.ShowNextOrder();

            restaurant.HandleOrder();

            restaurant.ShowOrderCount();
        }
    }
}
