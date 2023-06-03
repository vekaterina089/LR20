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

namespace WpfApp7.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        bdEntities bd = new bdEntities();
        public AdministratorPage()
        {
            InitializeComponent();
            dg.ItemsSource = bd.Product.ToList();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd add = new WindowAdd();
            add.Show();
        }
    }
}
