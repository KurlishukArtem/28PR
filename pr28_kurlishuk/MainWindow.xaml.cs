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
using pr28_kurlishuk.Pages.Club;

namespace pr28_kurlishuk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;

        public MainWindow()
        {
            InitializeComponent();
            OpenPage(new pr28_kurlishuk.Pages.Club.Main());
            init = this;
        }

        public void OpenPage(Page Page)
        {
            frame.Navigate(Page);
        }

        private void OpenClubs(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new pr28_kurlishuk.Pages.Club.Main());
        }

        private void OpenUsers(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new pr28_kurlishuk.Pages.Users.Main());
        }
    }
}
