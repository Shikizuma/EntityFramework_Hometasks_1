using Microsoft.EntityFrameworkCore;
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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Product> products { get; set; }

        public MainWindow()
        {
            InitializeComponent();          
        }

        private async void OutputButton_Click(object sender, RoutedEventArgs e)
        {       
            using (AppContext context = new AppContext())
            {
                products = await context.Products.ToListAsync();
            }

            ProductDataGrid.ItemsSource = products;
        }
    }
}
