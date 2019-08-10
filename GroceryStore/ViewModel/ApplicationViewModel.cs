using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GroceryStore.Model;

namespace GroceryStore.ViewModel
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        private Product selectedProduct;

        public ObservableCollection<Product> products { get; set; }

        public Product SelectedProduct
        {
            get => selectedProduct;
            set {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        public ProductsViewModel()
        {
            products = new ObservableCollection<Product>
            {
                new Product {Name="Potato", Article=1231, Description="Description of potato", Price=665, UnitsInStock=5},
                new Product {Name="Tomato", Article=123, Description="Description of tomato", Price=213, UnitsInStock=23},

            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
