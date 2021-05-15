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

namespace kursovaya_1
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public string T;
        ApplicationContext db =  new ApplicationContext();
        public int H;
        public Menu(string idshnik)
        {
            
            InitializeComponent();
            List<User> users = db.Users.ToList();
            int v = Convert.ToInt32(idshnik);
            H = Convert.ToInt32(idshnik);
            string str = users[v - 1].zadachi + "/3";
            Text.Text = str;
        }

        private void Easy_click(object sender, RoutedEventArgs e)
        {
            var newwin = new Easy (H);
            newwin.Show();
            Close();
        }

        private void medium_click(object sender, RoutedEventArgs e)
        {
            Medium medium = new Medium();
            medium.Show();
            Close();
        }

        private void hard_click(object sender, RoutedEventArgs e)
        {
            Hard hard = new Hard();
            hard.Show();
            Close();
        }

        private void person_click(object sender, RoutedEventArgs e)
        {
            var newwin = new Insert(H);
            newwin.Show();
            Close();
        }
    }
}
