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

namespace MedFed_Nutrition
{
    /// <summary>
    /// Interaction logic for Recipe.xaml
    /// </summary>
    public partial class Recipe : UserControl
    {
        public Recipe()
        {
            InitializeComponent();

            this.CloseBtn.Click += CloseBtn_Click;
            this.PrintBtn.Click += PrintBtn_Click;
        }

        private void PrintBtn_Click(object sender, RoutedEventArgs e)
        {
            string printMsg = "Printing Recipe...";
            MessageBox.Show(printMsg);
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
