using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;
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
        List<Tuple<string, string, string>> users = new List<Tuple<string, string, string>>();

        public MainWindow()
        {
            InitializeComponent();
            this.registerUser.Visibility = Visibility.Hidden;
            this.mainContent.Visibility = Visibility.Hidden;
            this.SignIn.Click += SignIn_Click;
            this.RegButton.Click += RegButton_Click;

            users.Add(new Tuple<string, string, string>("matthew", "kanderka", "jack"));
            users.Add(new Tuple<string, string, string>("jim", "joe", "jj"));
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            this.registerUser.Visibility = Visibility.Visible;
            passwordError.Text = String.Empty;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string UsernameString = Username.Text;
            string Pass = passwordBox.Password.ToString();
            bool check = false;

            foreach(Tuple<string, string, string> u in users)
            {
                if(u.Item1 == UsernameString && u.Item3 == Pass)
                {
                    passwordError.Text = String.Empty;
                    Username.Text = String.Empty;
                    passwordBox.Clear();
                    check = true;
                    this.mainContent.Visibility = Visibility.Visible;
                }
            }
            if (check == false)
            {
                passwordError.Text = "Incorrect username or password";
            }
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //public static string UsernameString { get; private set; }

        //public static string Pass { get; private set; }
    }
}
