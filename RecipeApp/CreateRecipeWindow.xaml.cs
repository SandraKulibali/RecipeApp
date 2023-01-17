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
using System.Windows.Shapes;

namespace RecipeApp
{
    /// <summary>
    /// Логика взаимодействия для CreateRecipeWindow.xaml
    /// </summary>
    public partial class CreateRecipeWindow : Window
    {
        public CreateRecipeWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            gridSave.Visibility = Visibility.Visible;
            gridCreate.Visibility = Visibility.Collapsed;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            gridSave.Visibility = Visibility.Collapsed;
            gridCreate.Visibility = Visibility.Visible;
        }
    }
}
