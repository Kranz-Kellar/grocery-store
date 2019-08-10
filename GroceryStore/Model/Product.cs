using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Model
{
    public class Product : INotifyPropertyChanged
    {
        private int id;
        private int article;
        private string name;
        private string description;
        private int unitsInStock;
        private float price;

        public ProductCategory category;
        public Provider provider;

        public int Id { get => id; }

        public int Article { get => article;
            set
            {
                article = value;
                OnPropertyChanged("Article");
            } }

        public string Name { get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            } }

        public string Description { get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            } }

        public int UnitsInStock { get => unitsInStock;
            set
            {
                unitsInStock = value;
                OnPropertyChanged("UnitsInStock");
            } }

        public float Price { get => price;
            set
            {
                price = value;
                OnPropertyChanged("Price");
            } }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
