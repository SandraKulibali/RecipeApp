using System.Windows;

namespace RecipeApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalad_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
            lbRecipe.ItemsSource = new[] { new { Name = "Цезарь", Image = "icons/dishes.jpg" }, new { Name = "Оливье", Image = "icons/dishes.jpg" } };
        }

        private void btnFirstCourse_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
        }

        private void btnSecondCourse_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
        }

        private void btnDessert_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
        }

        private void btnOpenRecipe_Click(object sender, RoutedEventArgs e)
        {
            gridChangeDelete.Visibility = Visibility.Visible;
            gridDescription.Visibility = Visibility.Visible;
            gridPreview.Visibility = Visibility.Visible;
            lbRecipe.Visibility = Visibility.Collapsed;
        }

        private void btnDelTypeKitchen_Click(object sender, RoutedEventArgs e)
        {
            DelKitchenWindow delKitchenWindow = new DelKitchenWindow();
            delKitchenWindow.gridDelKitchen.Visibility = Visibility.Visible;
            delKitchenWindow.gridDelRecipe.Visibility = Visibility.Collapsed;
            delKitchenWindow.Owner = this;
            delKitchenWindow.Show();
        }

        private void btnCreateRecipe_Click(object sender, RoutedEventArgs e)
        {
            CreateRecipeWindow createRecipeWindow = new CreateRecipeWindow();
            createRecipeWindow.Owner = this;
            createRecipeWindow.Show();
        }

        private void btnDelTypeRecipe_Click(object sender, RoutedEventArgs e)
        {
            DelKitchenWindow delKitchenWindow = new DelKitchenWindow();
            delKitchenWindow.gridDelKitchen.Visibility = Visibility.Collapsed;
            delKitchenWindow.gridDelRecipe.Visibility = Visibility.Visible;
            delKitchenWindow.Owner = this;
            delKitchenWindow.Show();
        }

        private void btnBackToList_Click(object sender, RoutedEventArgs e)
        {
            gridChangeDelete.Visibility = Visibility.Collapsed;
            gridDescription.Visibility = Visibility.Collapsed;
            gridPreview.Visibility = Visibility.Collapsed;
            lbRecipe.Visibility = Visibility.Visible;
        }

        private void btnChangeRecipe_Click(object sender, RoutedEventArgs e)
        {
            CreateRecipeWindow createRecipeWindow = new CreateRecipeWindow();
            createRecipeWindow.Owner = this;
            createRecipeWindow.Show();
        }

        private void btnStepByStepDescription_Click(object sender, RoutedEventArgs e)
        {
            gridDescription.Visibility = Visibility.Collapsed;
            gridStepByStepDescription.Visibility = Visibility.Visible;
        }
    }
}
