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
    /// Interaction logic for Search_View.xaml
    /// </summary>
    public partial class Search_View : UserControl
    {
        List<string> recipes = new List<string>();

        public Search_View()
        {
            InitializeComponent();
            this.Recipe.Visibility = Visibility.Hidden;


            recipes.Add("Chicken Tenders");
            recipes.Add("Chicken Breast");
            recipes.Add("Pizza");
            recipes.Add("Greek Salad");

            View.Click += View_Click;
            ResultsBox.MouseDoubleClick += ResultsBox_MouseDoubleClick;
        }

        private void ResultsBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ResultsBox.SelectedItem != null)
            {
                Console.WriteLine(ResultsBox.SelectedItem.ToString());
                this.Recipe.Visibility = Visibility.Visible;
            }
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            ResultsBox.Items.Clear();

            string recipeSearch = SeachBox.Text;

            foreach(string r in recipes)
            {
                if (r.ToUpper().Contains(recipeSearch.ToUpper()))
                {
                    ResultsBox.Items.Add(r);
                }
            }
        }


    }
}
