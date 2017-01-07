using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
     
       static void Main(string[] args)
        {

            person student1= new person("123456", "abc@gmail.com", "Raju", "XYZ");

            person B = new person("13243", "def@gmail.com", "bob", "james");

            person c = new person();
            c.StudentID = person.count;
            
           
       
            Console.WriteLine(student1.DOB);
            Console.WriteLine(student1.Email);
            Console.WriteLine(student1.LastName);
            Console.WriteLine(student1.FirstName);
            Console.WriteLine(student1.StudentID);

            Console.WriteLine(B.DOB);
            Console.WriteLine(B.Email);
            Console.WriteLine(B.LastName);
            Console.WriteLine(B.FirstName);
            Console.WriteLine(B.StudentID);


            Console.WriteLine(person.count);
          
            Console.ReadLine();

                    }

  


}
    }

