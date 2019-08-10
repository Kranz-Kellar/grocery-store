using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroceryStore.Frames
{
    /// <summary>
    /// Interaction logic for ProductFrame.xaml
    /// </summary>
    public partial class ProductFrame : Page
    {
        public ProductFrame()
        {
            InitializeComponent();


            DataContext = new ViewModel.ProductsViewModel();

        }
    }
}
