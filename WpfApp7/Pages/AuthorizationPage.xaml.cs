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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        bdEntities bd = new bdEntities();
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var objUser = bd.User.Where(x => x.UserLogin == logo.Text && x.UserPassword == password.Password).First();

                if (objUser != null)
                {
                    switch (objUser.UserRole)
                    {
                        case 1:
                            this.NavigationService.Navigate(new Pages.ClientPage());
                            break;
                        case 2:
                            this.NavigationService.Navigate(new Pages.ClientPage());
                            break;
                        case 3:
                            this.NavigationService.Navigate(new Pages.AdministratorPage());
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь отсутствует!", "Уведомление");
                }
            }
            catch 
            {
                MessageBox.Show("Такой пользователь отсутствует!", "Уведомление");
            }
        }
    }
}
