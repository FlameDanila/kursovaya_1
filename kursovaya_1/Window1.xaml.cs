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
using System.Data;
using System.Data.SqlClient;

namespace kursovaya_1
{
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            list.ItemsSource = users;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
