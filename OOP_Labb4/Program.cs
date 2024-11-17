namespace OOP_Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett nytt objekt av Restaurant-klassen.
            Restaurant restaurant = new Restaurant();

            //Lägg till fyra olika rätter i menyn.
            MenuItem pizza = new MenuItem(1, "Pizza", 120);
            MenuItem hamburger = new MenuItem(2, "Hamburgare", 115);
            MenuItem fries = new MenuItem(3, "Pommes", 35);
            MenuItem carbonara = new MenuItem(4, "Carbonara", 145);

            restaurant.AddToMenu(pizza);
            restaurant.AddToMenu(hamburger);
            restaurant.AddToMenu(fries);
            restaurant.AddToMenu(carbonara);

            //Skriv ut menyn.
            restaurant.ShowMenu();

            //Skapa 3 st nya ordrar, med minst två olika rätter i varje, och lägg till dem i orderkön.
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

            //Visa alla aktuella ordrar.
            restaurant.ShowOrders();

            //Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();

            //Visa nästa order på kö.
            restaurant.ShowNextOrder();

            //Hantera en order.
            restaurant.HandleOrder();

            //Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();

            //Lägg till en ny order.
            List<MenuItem> order4 = new List<MenuItem>();
            order4.Add(hamburger);
            order4.Add(pizza);
            order4.Add(fries);
            order4.Add(carbonara);
            Order table4 = new Order(order4, 4);
            restaurant.CreateOrder(table4);

            //Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();

            //Hantera två ordrar.
            restaurant.HandleOrder();
            restaurant.HandleOrder();

            //Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();

            //Visa nästa order på kö.
            restaurant.ShowNextOrder();

            //Hantera en order.
            restaurant.HandleOrder();

            //Visa antalet ordrar i kön.
            restaurant.ShowOrderCount();
        }
    }
}
