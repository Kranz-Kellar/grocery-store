using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    public class Product 
    {
        public int id;
        public int article;
        public string name;
        public string description;
        public int unitsInStock;
        public float price;

        public ProductCategory category;
        public Provider provider;
    }
}
