using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    public class Person
    {
        string name;
        string phone;
        string mail;
        string surname;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Mail
        {
            get { return mail; }
            set{ mail = value; }
        }
        public string Surname
        {
            get { return surname; } 
            set { surname = value; }
        }
    }
}
