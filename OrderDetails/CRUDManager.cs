using Microsoft.EntityFrameworkCore;
using OrderDetails.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails
{
    public  class CRUDManager
    {
        private DemoDbContext demoDbContext;
        public CRUDManager()
        {
            demoDbContext = new DemoDbContext();
        }
        public Item GetitemById(int customerID)
        {
            // Tracking not required
            var a = demoDbContext.items.Where(x => x.ID == customerID)
                            .AsNoTracking()
                            .FirstOrDefaultAsync().Result;

            if (a == null)
            {
                Console.WriteLine($"item with ID:{customerID} Not Found");
            }

            return a;
        }



        public List<Item> GetAllItems()
        {
            var items = demoDbContext.items.ToList();
            return items;
        }

        public void Insert(Item cd)
        {
            demoDbContext.items.Add(cd);
            demoDbContext.SaveChanges();
        }

        public void Update(int customer, Item modifieditem)
        {
            var item = demoDbContext.items.Where(x => x.ID == customer).FirstOrDefault();
            if (item == null)
            {
                throw new Exception($"item with ID:{customer} Not Found");
            }

            item.ItemName = modifieditem.ItemName;
            item.ItemRate = modifieditem.ItemRate;
            item.ItemQuantity = modifieditem.ItemQuantity;

            // Entity state : Modified
            demoDbContext.items.Update(item);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }

        public void Delete(int customerID)
        {
            var item = demoDbContext.items.Where(x => x.ID == customerID).FirstOrDefault();
            if (item == null)
            {
                throw new Exception($"Employee with ID:{customerID} Not Found");
            }

            // Entity state : Deleted
            demoDbContext.items.Remove(item);

            // This issues insert statement
            demoDbContext.SaveChanges();
        }
    }
}