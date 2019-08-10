using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    public class Check
    {
        public int id;
        public DateTime date;
        public List<CheckLine> productsInCheck;
    }
}
