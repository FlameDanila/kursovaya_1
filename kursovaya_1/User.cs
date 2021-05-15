using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya_1
{
    class User
    {
        public int Id { get; set; }
        private string Login, Pass;
        private int Zadachi;
        public string login
        {
            get { return Login; }
            set { Login = value; }
        }
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }
        public int zadachi
        {
            get { return Zadachi; }
            set { Zadachi = value; }
        }
        public User() { }
        public User(string Login, string Pass, int Zadachi)
        {
            this.Login = Login;
            this.Pass = Pass;
            this.Zadachi = Zadachi;
        }

        //public override string ToString()
        //{
        //    return login + pass;
        //}
    }
}
