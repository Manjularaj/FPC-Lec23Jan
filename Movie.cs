using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPC_Lec23Jan
{
    //Q. What do you need to change in your class to make it public?
    //Ans: Change the access modifier or specifier to public (Usually by default it will be internal)

    //Q. Classes have 4 components.
    //Ans:They are called as members. A member is anything that is a part of a class
    //1. Fields - Variables
    //2. Constructors - Letting you create an object
    //3. Properties - Acess to the fields
    //4. Methods - Behaviors

    public class Movie
    {
        //Fields
        public string MovieName;
        public double Rating;
        public string Director;
        public int Year;


    }
}
