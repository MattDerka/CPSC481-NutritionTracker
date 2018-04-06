using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for AddControl.xaml
    /// </summary>
    public partial class AddControl : UserControl
    {
        public AddControl()
        {
            InitializeComponent();
            this.Browse.Click += Browse_Click;
            this.Save.Click += Save_Click;
            this.Add.Click += Add_Click;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string saveMsg = "Recipe Added";
            MessageBox.Show(saveMsg);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string saveMsg = "Recipe Saved";
            MessageBox.Show(saveMsg);
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
