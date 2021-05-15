using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace kursovaya_1
{
    /// <summary>
    /// Логика взаимодействия для Easy.xaml
    /// </summary>
    public partial class Easy : Window
    {
        ApplicationContext db = new ApplicationContext();

        public Easy(int H)
        {
            InitializeComponent();
            List<Test> Tests = db.Tests.ToList();
            List.ItemsSource = Tests;
            Test test = new Test();
            //text.Text = db.Tests.ToString();
            //List<Test> Tests = db.Tests.ToList();
            //string str = "";
            //str += Tests[0].Easy;
            //text.Text = str;
        }

        private void menu_click(object sender, RoutedEventArgs e)
        {
            string idishnik = "";
            Menu menu = new Menu(idishnik);
            menu.Show();
            Close();
        }

        private void ping_click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            Test test = List.SelectedItem as Test;
            db.Tests.Remove(test);
            db.SaveChanges();
            List<Test> Tests = db.Tests.ToList();
            List.ItemsSource = Tests;
        }
    }
}
