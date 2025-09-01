// Simple Store Management Program

using System;

// Product class to represent a store item
class Product
{
    public string Name { get; set; }         // Name of the product
    public int Quantity { get; set; }        // Quantity in stock
    public decimal Price { get; set; }       // Unit price
    public bool IsAvailable { get; set; }    // Availability status
}

class Program
{
    static void Main(string[] args)
    {
        // Display header for product entry
        Console.WriteLine("=== Product Information Entry ===");

        // Prompt for product name
        Console.WriteLine("Enter the product name.");
        string productName = Console.ReadLine();

        // Prompt for stock quantity and validate input
        int stockQuantity;
        Console.WriteLine("Enter the stock quantity of the above product.");
        string quantityInput = Console.ReadLine();
        if (!int.TryParse(quantityInput, out stockQuantity))
        {
            Console.WriteLine("❌ Invalid quantity. Please enter a valid integer.");
            return; // Exit if input is invalid
        }

        // Prompt for unit price and validate input
        decimal unitPrice;
        Console.WriteLine("Enter the unit price of the above product.");
        string priceInput = Console.ReadLine();
        if (!decimal.TryParse(priceInput, out unitPrice))
        {
            Console.WriteLine("❌ Invalid price. Please enter a valid decimal number.");
            return; // Exit if input is invalid
        }

        // Prompt for availability status
        Console.Write("Is the product available? (yes/no): ");
        string availabilityInput = Console.ReadLine();
        bool isAvailable = availabilityInput.Trim().ToLower() == "yes";

        // Create a Product object with the entered data
        Product product = new Product
        {
            Name = productName,
            Quantity = stockQuantity,
            Price = unitPrice,
            IsAvailable = isAvailable
        };

        // Define emoji strings for display
        string boxEmoji = "\U0001F4E6";     // 📦
        string chartEmoji = "\U0001F4CA";   // 📊
        string moneyEmoji = "\U0001F4B5";   // 💵
        string checkEmoji = "\U00002705";   // ✅
        string abacusEmoji = "\U0001F9EE";  // 🧮

        // Set console output encoding to UTF-8 to support emojis
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Display product summary with emojis and formatted output
        Console.WriteLine($@"
{boxEmoji} Product: {product.Name}
{chartEmoji} Quantity: {product.Quantity}
{moneyEmoji} Unit Price: {product.Price:C}
{checkEmoji} Available: {(product.IsAvailable ? "Yes" : "No")}
{abacusEmoji} Total Price: {(product.Quantity * product.Price):C}
");
    }
}
