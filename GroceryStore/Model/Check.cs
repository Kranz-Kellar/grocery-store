using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    public class Check : INotifyPropertyChanged
    {
        private int id;
        private DateTime date;
        private List<CheckLine> productsInCheck;

        public int Id { get => id;
            set
            {
                id = value; OnPropertyChanged("Id");
            }
        }

        public DateTime Date { get => date;
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public List<CheckLine> ProductsInCheck { get => productsInCheck;
            set
            {
                productsInCheck = value;
                OnPropertyChanged("productsInCheck");
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
