using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FPC_Lec23Jan
{
    public class Instructor
    {
        //Fields 
        string lastName;
        string firstName;
        string phone;

        //Constructor
        public Instructor(string lastName, string firstName, string phone)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.phone = phone;
        }
        // property 

        //How do you define a property ?
        //Access modifer - type of the field - name of the field (Upper Case)-No parenthesis

        //Two New keywords
        //Getter and Setter
        //Getter allows the user to READ the value
        //Setter allows the user to write the value

        public string LastName

        {//get
            get
            {
                return lastName;

            }
            set
            {  
                // This code block runs if the value is not an empty string
                if(value != "")
                {
                    lastName = value;

                }
                else
                {

                    MessageBox.Show("please enter a valid last name");
                }
                
                

            }

            
        }//Lastname

    }
}
