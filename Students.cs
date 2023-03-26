using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPC_Lec23Jan
{
    public class Students
    {
        //Fields

        public string Firstname;
        public string Lastname;
        public double CSIGrade;
        public double GenEdGrade;


        //Constructor
        //How do you create a constructor?
        //Access modifer - className - Parenthesis


        //Constructors allow/ restrict what is needed to create an object
        // Guarantee value for fields with a constructor
        public Students(string firstname, string lastName, int CSI, int GenEd)
        {
            //How you assign values to fields
            Firstname = firstname;
            Lastname = lastName;
            CSIGrade = CSI;
            GenEdGrade = GenEd;

        }

       //Create a second Constructor or overloading
       public Students (string firstname, string lastName)
        {
            Firstname = firstname;
            Lastname = lastName;
            CSIGrade = -1;
            GenEdGrade = -1;
        }


    }
}
