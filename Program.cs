public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        this.ItemName = itemName; 
        this.ItemId = itemId;
        this.Price = price;
        this.QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        this.Price = newPrice;
        
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        this.QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (quantitySold > this.QuantityInStock)
        {
            Console.WriteLine($"Only {this.QuantityInStock} items are available to sell.");
            return;
        }
        
        this.QuantityInStock -= quantitySold;
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return this.QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"{this.ItemName} {this.ItemId} {this.Price} {this.QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        Console.WriteLine("Item2 Details:");
        item1.PrintDetails();
        Console.WriteLine("Item2 Details:");
        item2.PrintDetails();
        // 2. Sell some items and then print the updated details.item1.SellItem(2);
         item1.SellItem(2);
        item2.SellItem(3);
        
        Console.WriteLine("Item1 Details after Sale of 2 items:");
        item1.PrintDetails();
        Console.WriteLine("Item2 Details after Sale of 3 items:");
        item2.PrintDetails();

        // 3. Restock an item and print the updated details.
        item1.RestockItem(4);
        item2.RestockItem(5);

        Console.WriteLine("Item2 Details after restocking of 4 items:");
        item1.PrintDetails();
        Console.WriteLine("Item2 Details after restocking of 4 items:");
        item2.PrintDetails();
        // 4. Check if an item is in stock and print a message accordingly.

         if(item1.IsInStock()) {
            Console.WriteLine("Item1 is in stock");
        }else {
            Console.WriteLine("Item1 is out of stock");
        }


        if(item2.IsInStock()) {
            Console.WriteLine("Item2 is in stock");
        }else {
            Console.WriteLine("Item2 is out of stock");
        }

       
    }
}
