class Program
{
    static void Main()
    {
        WarehouseManagement warehouse = new WarehouseManagement();

        while (true)
        {
            Console.WriteLine("Warehouse Management System");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. List Items");
            Console.WriteLine("4. Search Item");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine();
                    Console.Write("Enter quantity to add: ");
                    int quantityToAdd = int.Parse(Console.ReadLine());
                    warehouse.AddItem(itemName, quantityToAdd);
                    Console.WriteLine("Item added to stock.");
                    break;
                case 2:
                    Console.Write("Enter item name: ");
                    string itemToRemove = Console.ReadLine();
                    Console.Write("Enter quantity to remove: ");
                    int quantityToRemove = int.Parse(Console.ReadLine());
                    warehouse.RemoveItem(itemToRemove, quantityToRemove);
                    break;
                case 3:
                    warehouse.ListItems();
                    break;
                case 4:
                    Console.Write("Enter item name to search: ");
                    string itemToSearch = Console.ReadLine();
                    warehouse.SearchItem(itemToSearch);
                    break;
                case 5:
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
