using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_invoice_rdlc
{
    [Serializable]
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }


        public Student()
        {

        }

        public Student(string id, string name, string age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }
}