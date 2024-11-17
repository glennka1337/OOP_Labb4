namespace OOP_Labb4
{
    internal class Order
    {
        static int orderIdCounter = 1;
        public int OrderId { get; private set; }
        private List<MenuItem> _orderItems;
        private int _tableNumber;
        private decimal _total;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            OrderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void Display()
        {
            Console.WriteLine($"\nOrder {OrderId}:");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"1 st {item.Name}");
            }

            foreach (var item in _orderItems)
            {
                _total += item.Price;
            }
            Console.WriteLine($"Summa: {_total:C}");
            Console.WriteLine($"Till bord nummer {_tableNumber}");
        }
    }
}
