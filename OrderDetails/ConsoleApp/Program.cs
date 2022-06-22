using OrderDetails;
using OrderDetails.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CRUDManager obj = new CRUDManager();

            Console.WriteLine("Adding a new item");
            obj.Insert(new Item { ItemName = "Phone", ItemRate = 19000, ItemQuantity = 1 });
            obj.Insert(new Item { ItemName = "Watch", ItemRate = 2000, ItemQuantity =1 });
            PrintAllitems();

            //Console.WriteLine("Updating Items with customerID 2");
            //obj.Update(2, new Employee { Name = "Modified Items", ItemRate = "Modified ItemRate",ItemQTY="Modified ItemQTY" });
            //PrintAllEmployees();

            //Console.WriteLine("Retrieving Item details for customerID 2");
            //var employee = obj.GetitemById(2);
            //Console.WriteLine($"Item Name of item ID 2 is {item.Name}");

            //Console.WriteLine("Deleting Items details for customer 2");
            //obj.Delete(2);
            //PrintAllItem();

            Console.ReadLine();
        }

        private static void PrintAllitems()
        {
            Console.WriteLine("Printing all items");
            CRUDManager obj = new CRUDManager();
            foreach (Item? item in obj.GetAllItems())
            {
                Console.WriteLine($"Items Name is {item.ItemName} and Rate is {item.ItemRate}");
            }
        }
    }
}