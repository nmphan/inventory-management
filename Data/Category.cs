using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data
{
    public class Category
    {
        int categoryId;
        string CategoryName;

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName1 { get => CategoryName; set => CategoryName = value; }

        public Category()
        {
            
        }

        public Category(int categoryId, string categoryName)
        {
            this.categoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}
