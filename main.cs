using System;
using System.Collections.Generic;

class WarehouseItem
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public DateTime EntryDate { get; set; }
}

class WarehouseManagement
{
    private List<WarehouseItem> items = new List<WarehouseItem>();

    public void AddItem(string name, int quantity)
    {
        WarehouseItem existingItem = items.Find(item => item.Name == name);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new WarehouseItem { Name = name, Quantity = quantity, EntryDate = DateTime.Now });
        }
    }

    public void RemoveItem(string name, int quantity)
    {
        WarehouseItem existingItem = items.Find(item => item.Name == name);
        if (existingItem != null)
        {
            if (existingItem.Quantity >= quantity)
            {
                existingItem.Quantity -= quantity;
            }
            else
            {
                Console.WriteLine("Insufficient quantity in stock.");
            }
        }
        else
        {
            Console.WriteLine("Item not found in stock.");
        }
    }

    public void ListItems()
    {
        Console.WriteLine("Warehouse Inventory:");
        foreach (var item in items)
        {
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Quantity: {item.Quantity}");
            Console.WriteLine($"Entry Date: {item.EntryDate}");
            Console.WriteLine();
        }
    }

    public void SearchItem(string name)
    {
        WarehouseItem item = items.Find(item => item.Name == name);
        if (item != null)
        {
            Console.WriteLine("Item Found:");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Quantity: {item.Quantity}");
            Console.WriteLine($"Entry Date: {item.EntryDate}");
        }
        else
        {
            Console.WriteLine("Item not found in stock.");
        }
    }
}

