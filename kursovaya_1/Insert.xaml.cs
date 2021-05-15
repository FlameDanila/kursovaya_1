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
    /// Логика взаимодействия для Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        ApplicationContext db = new ApplicationContext();
        public int Y;
        public Insert(int H)
        {
            InitializeComponent();
            Y = H;
        }

        private void insert_click(object sender, RoutedEventArgs e)
        {
            if (easy.IsChecked == IsActive)
            {
                string text = TEXT.Text;
                string otvet = ansver.Text;
                Test test = new Test(text, null, null, otvet, null, null);
                db.Tests.Add(test);
                db.SaveChanges();
                MessageBox.Show("Задача успешно добавлена");
            }
            if (medium.IsChecked == IsActive)
            {
                string text = TEXT.Text;
                string otvet = ansver.Text;
                Test test = new Test(null, text, null, null, otvet, null);
                db.Tests.Add(test);
                db.SaveChanges();
                MessageBox.Show("Задача успешно добавлена");
            }
            if (hard.IsChecked == IsActive)
            {
                string text = TEXT.Text;
                string otvet = ansver.Text;
                Test test = new Test(null, null, text, null, null, otvet);
                db.Tests.Add(test);
                db.SaveChanges();
                MessageBox.Show("Задача успешно добавлена");
            }
            string login = "";
            Menu menu = new Menu(login);
            menu.Show();
            Close();
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            string login = "";
            Menu menu = new Menu(login);
            menu.Show();
            Close();
        }
    }
}
