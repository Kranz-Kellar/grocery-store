using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    public class CheckLine : INotifyPropertyChanged
    {
        public Product product;
        private int amountOfProduct;

        public int AmountOfProduct { get => amountOfProduct;
            set
            {
                amountOfProduct = value;
                OnPropertyChanged("amountOfProduct");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
