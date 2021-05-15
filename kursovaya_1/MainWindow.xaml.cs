using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.Common;
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

namespace kursovaya_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
            //List<User> users = db.Users.ToList();
            //string str = "";
            //foreach (User user in users)
            //{
            //    str += "Login: " + user.login + "\t" + "Pass: " + user.pass;
            //}
            //vivod.Text = str; 
        }

        private void registraciya_Click(object sender, RoutedEventArgs e)
        {
            if (log.Text == "" || pas.Text == "" || pas_Copy.Text == "")
            { MessageBox.Show("У вас остались незаполненые поля"); }
            else
            {
                if (pas.Text == pas_Copy.Text)
                {
                    string Login = log.Text;
                    string Pass = pas.Text;
                    int Zadachi = 0;
                    User user = new User(Login, Pass, Zadachi);
                    db.Users.Add(user);
                    db.SaveChanges();
                    var idshnik = user.Id.ToString();

                    /*
                     * SQLiteCommand command = new SQLiteCommand(connection);
        command = new SQLiteCommand(connection);
        command.CommandText = "SELECT *FROM 'Table'";
        SQLiteDataReader reader = command.ExecuteReader();
                     */
                    MessageBox.Show(idshnik);
                    SQLiteConnection conn = new SQLiteConnection(string.Format("Data Source={0};", db));
                    conn.Open();
                    string str =  $"SELECT Login FROM Users WHERE Zadachi = 0";
                    SQLiteCommand command = new SQLiteCommand(string.Format("Data Source={0};", db));
                    command.CommandText = str;
                    MessageBox.Show(command.ToString());
                    SQLiteDataReader reader = command.ExecuteReader();
                    MessageBox.Show(reader.ToString());
                    var newwin = new Menu(idshnik);
                    newwin.Show();
                    Close();
                }
                else MessageBox.Show("Пароли не совпадают");
            }
        }

        private void vhod_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Close();
        }
        //Window1 window1 = new Window1();
        //NavigationService.GetNavigationService(window1);
        //    window1.Show();
    }
}
