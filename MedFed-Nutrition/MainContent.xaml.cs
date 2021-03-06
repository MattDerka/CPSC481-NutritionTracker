﻿using System;
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
    /// Interaction logic for MainContent.xaml
    /// </summary>
    public partial class MainContent : UserControl
    {
        public MainContent()
        {
            InitializeComponent();

            this.search_View.Visibility = Visibility.Hidden;
            this.addControl.Visibility = Visibility.Hidden;
            this.calorieANDNutrition.Visibility = Visibility.Hidden;
            this.GoalsControl.Visibility = Visibility.Hidden;
            this.settings.Visibility = Visibility.Hidden;

            this.Logout.MouseLeftButtonUp += Logout_MouseLeftButtonUp;
            this.Search.Click += SearchClick;
            this.AddRecipe.Click += AddRecipe_Click;
            this.NutritionButton.Click += NutritionButton_Click;
            this.Goal.Click += Goal_Click;
            this.image.MouseLeftButtonUp += Logout_MouseLeftButtonUp1;
        }

        private void Logout_MouseLeftButtonUp1(object sender, MouseButtonEventArgs e)
        {
            this.settings.Visibility = Visibility.Visible;
        }

        private void Goal_Click(object sender, RoutedEventArgs e)
        {
            this.search_View.Visibility = Visibility.Hidden;
            this.addControl.Visibility = Visibility.Hidden;
            this.calorieANDNutrition.Visibility = Visibility.Hidden;
            this.GoalsControl.Visibility = Visibility.Visible;
        }

        private void NutritionButton_Click(object sender, RoutedEventArgs e)
        {
            this.search_View.Visibility = Visibility.Hidden;
            this.addControl.Visibility = Visibility.Hidden;
            this.calorieANDNutrition.Visibility = Visibility.Visible;
            this.GoalsControl.Visibility = Visibility.Hidden;
        }

        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            this.search_View.Visibility = Visibility.Hidden;
            this.addControl.Visibility = Visibility.Visible;
            this.calorieANDNutrition.Visibility = Visibility.Hidden;
            this.GoalsControl.Visibility = Visibility.Hidden;
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {
            this.search_View.Visibility = Visibility.Visible;
            this.addControl.Visibility = Visibility.Hidden;
            this.calorieANDNutrition.Visibility = Visibility.Hidden;
            this.GoalsControl.Visibility = Visibility.Hidden;
        }

        private void Logout_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            this.search_View.Visibility = Visibility.Hidden;
            this.addControl.Visibility = Visibility.Hidden;
            this.calorieANDNutrition.Visibility = Visibility.Hidden;
            this.GoalsControl.Visibility = Visibility.Hidden;
        }
    }
}
