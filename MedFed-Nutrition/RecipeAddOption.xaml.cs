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
    /// Interaction logic for RecipeAddOption.xaml
    /// </summary>
    public partial class RecipeAddOption : UserControl
    {
        public RecipeAddOption()
        {
            InitializeComponent();
            this.UploadPicture.Visibility = Visibility.Hidden;
            this.AddControl.Visibility = Visibility.Hidden;
            this.TypeButton.Click += TypeButton_Click;
            this.AddPicButton.Click += AddPicButton_Click;
        }

        private void AddPicButton_Click(object sender, RoutedEventArgs e)
        {
            this.UploadPicture.Visibility = Visibility.Visible;
        }

        private void TypeButton_Click(object sender, RoutedEventArgs e)
        {
            this.AddControl.Visibility = Visibility.Visible;
        }
    }
}
