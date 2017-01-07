using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class person
    {

        public string DOB;
        public string Email;
        public string FirstName;
        public string LastName;
        public int StudentID;

      
       
        public person(string DOB, string Email, string FirstName, string LastName):this()
        {
            this.DOB = DOB;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.StudentID = count;

           // for (StudentID = 1000; StudentID <= 5; StudentID++) ;

          
        }

        public static int count=1000;

        public static int Getcount()
        {
            return count-1000;
        }

        public person()
        {
            count++;
        }

    }
}