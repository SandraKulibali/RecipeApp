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
            lbRecipe.ItemsSource = new[] { new { Name = "Цезарь", Image = "icons/цезарь.jpg" }, new { Name = "Оливье", Image = "icons/оливье.jpg" } };
        }

        private void btnFirstCourse_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
            lbRecipe.ItemsSource = new[] { new { Name = "Борщ", Image = "icons/борщ.jpg" }, new { Name = "Солянка", Image = "icons/солянка.jpg" } };
        }

        private void btnSecondCourse_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
            lbRecipe.ItemsSource = new[] { new { Name = "Жаркое", Image = "icons/жаркое.jpg" }, new { Name = "Стэйк из говядины", Image = "icons/стэйк.jpg" } };
        }

        private void btnDessert_Click(object sender, RoutedEventArgs e)
        {
            gridListRecipe.Visibility = Visibility.Visible;
            lbRecipe.ItemsSource = new[] { new { Name = "Чизкейк классический", Image = "icons/чизкейк.jpg" }, new { Name = "Наполеон", Image = "icons/наполеон.jpg" } };
        }

        private void btnOpenRecipe_Click(object sender, RoutedEventArgs e)
        {
            gridChangeDelete.Visibility = Visibility.Visible;
            gridDescription.Visibility = Visibility.Visible;
            gridPreview.Visibility = Visibility.Visible;
            lbRecipe.Visibility = Visibility.Collapsed;

            lbIngridients.ItemsSource = new[] { new { Ingridients = "Картофель вареный (желательно не молодой, а старый) – 4 шт. средних" }, new { Ingridients = "Морковка - 1 шт." }, new { Ingridients = "Яйца сваренные вкрутую – 4 шт." }, new { Ingridients = "Колбаса вареная докторская – 300 г" }, new { Ingridients = "огурцы маринованные (можно свежие) – 4 шт. средних" }, new { Ingridients = "горошек зеленый консервированный – 1 банка весом 200 г" }, new { Ingridients = "майонез – 3-4 ст. л." }, new { Ingridients = "" }, new { Ingridients = "соль, свежемолотый черный перец" }, new { Ingridients = "листья петрушки и укропа по желанию" } };

            tbDescription.Text = "Огурцы — один из ключевых ингредиентов в оливье. Без них этот салат потеряет свою изюминку. Причем использовать можно как свежие, так и соленые огурцы. Некоторые хозяйки и вовсе добавляют оба виду сразу. По их мнению, салат от этого только выигрывает. Если же вы не хотите экспериментировать, обратитесь к проверенной классике и приготовьте оливье с маринованными огурцами.";
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
