using Microsoft.Win32;
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
    /// Interaction logic for UploadPicture.xaml
    /// </summary>
    public partial class UploadPicture : UserControl
    {
        public UploadPicture()
        {
            InitializeComponent();
            this.Browse.Click += Browse_Click;
            this.Add.Click += Add_Click;
            this.arrow.MouseLeftButtonUp += Arrow_MouseLeftButtonUp;
        }

        private void Arrow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string saveMsg = "Recipe Photo Added";
            MessageBox.Show(saveMsg);
            this.Visibility = Visibility.Hidden;
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select a Picture";
            if (open.ShowDialog() == true)
            {
                Image.Source = new BitmapImage(new Uri(open.FileName));
            }
        }
    }
}
