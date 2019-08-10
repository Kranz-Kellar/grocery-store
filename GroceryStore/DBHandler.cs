using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.IO;

namespace GroceryStore
{
    public class DBHandler
    {
        private static string DBFileName = "storeDB.sqlite";
        private static string connectionString  = $"Data Source={DBFileName}";

        /// <summary>
        /// Class without instance
        /// </summary>
        private DBHandler() { }

    }
}
