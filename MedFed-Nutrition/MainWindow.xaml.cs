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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedFed_Nutrition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.registerUser.Visibility = Visibility.Hidden;
            this.mainContent.Visibility = Visibility.Hidden;
            this.SignIn.Click += SignIn_Click;
            this.RegButton.Click += RegButton_Click;

        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.registerUser.Visibility = Visibility.Visible;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            this.mainContent.Visibility = Visibility.Visible;
        }

    }
}
