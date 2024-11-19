using pr28_kurlishuk;
using pr28_kurlishuk.Classes;
using pr28_kurlishuk.Pages.Club;
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

namespace pr28_kurlishuk.Pages.Club.Items
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        ClubsContext item;
        Main main;
        public Item(ClubsContext item, Main main)
        {
            InitializeComponent();

            Name.Text = item.Name;
            Address.Text = item.Address;
            Time.Text = item.WorkTime;
            this.item = item;
            this.main = main;
            
        }

        private void EditRecord(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPage(new Pages.Club.Add(this.item));
        }

        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            item.Delete();
            main.parent.Children.Remove(this);
        }
    }
}
