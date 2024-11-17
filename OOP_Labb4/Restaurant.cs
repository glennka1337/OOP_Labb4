namespace OOP_Labb4
{
    internal class Restaurant
    {
        public List<MenuItem> menuList = new List<MenuItem>();
        public Queue<Order> orderQueue = new Queue<Order>();

        public void AddToMenu(MenuItem menuItem)
        {
            menuList.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} has been added to the menu.");
        }

        public void ShowMenu()
        {
            Console.WriteLine("------------------------------");
            foreach (var item in menuList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------------------------------");
        }

        public void CreateOrder(Order order)
        {
            orderQueue.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.OrderId} har lagts till.");
        }

        public void HandleOrder()
        {
            Console.WriteLine($"\nOrder {orderQueue.Peek().OrderId} färdig.");
            orderQueue.Dequeue();
        }

        public void ShowOrders()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Aktuella beställningar:");
            foreach (var order in orderQueue)
            {
                order.Display();
            }
            Console.WriteLine("------------------------------");
        }

        public void ShowNextOrder()
        {
            Console.WriteLine("Nästa order i kön:");
            orderQueue.Peek().Display();
        }

        public void ShowOrderCount()
        {
            Console.WriteLine($"Det är {orderQueue.Count} " + ((orderQueue.Count == 1) ? "order" : "ordrar") + " i kön.");
        }
    }
}
