using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        class Student
        {
            private string firstname;
         

            public string getFirstName()
            {
                return firstname;
            }

            public void setFirstName(string fstname)
            {
                firstname = fstname;
            }

            public string FirstName
            {
                               get { return firstname; }
                set { firstname = value; }
            }
        }

        class Test
        {
            static void Main()
            {
                Student obj = new Student();
                obj.setFirstName("ramesh");
                Console.WriteLine(obj.getFirstName());
                obj.FirstName = "ramesh";
                Console.WriteLine(obj.FirstName);

            }
        }
    }

