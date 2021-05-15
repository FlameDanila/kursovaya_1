using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovaya_1
{
    class Test
    {
        public int Id { get; set; }
        private string easy, medium, hard, easy_ansver, medium_ansver, hard_ansver;
        public string Easy
        {
            get { return easy; }
            set { easy = value; }
        }
        public string Medium
        {
            get { return medium; }
            set { medium = value; }
        }
        public string Hard
        {
            get { return hard; }
            set { hard = value; }
        }
        public string Medium_ansver
        {
            get { return medium_ansver; }
            set { medium_ansver = value; }
        }
        public string Hard_ansver
        {
            get { return hard_ansver; }
            set { hard_ansver = value; }
        }
        public string Easy_ansver
        {
            get { return easy_ansver; }
            set { easy_ansver = value; }
        }
        public Test() { }
        public Test(string Easy, string Medium, string Hard, string Easy_ansver, string Medium_ansver, string Hard_ansver)
        {
            this.easy_ansver = Easy_ansver;
            this.medium_ansver = Medium_ansver;
            this.hard_ansver = Hard_ansver;
            this.hard = Hard;
            this.medium = Medium;
            this.easy = Easy;
        }
    }
}
