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
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : UserControl
    {
        List<Tuple<string, string, string>> users = new List<Tuple<string, string, string>>();

        public RegisterUser()
        {
            InitializeComponent();
            this.button.Click += Button_Click;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fName = FirstName.Text;
            string lName = LastName.Text;
            string password = Password.Password.ToString();
            users.Add(new Tuple<string, string, string>(fName, lName, password));
            users.ForEach(Console.WriteLine);

            FirstName.Text = String.Empty;
            LastName.Text = String.Empty;
            Password.Clear();
            PasswordBox2.Clear();

            this.Visibility = Visibility.Hidden;
        }
    }
}
