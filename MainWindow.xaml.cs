using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FPC_Lec23Jan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Q. How to add a class?
        //Ans: Right click on under the solution (Right Side, File name with C# symbol)
        //Select Add
        //Then Class

        //Q. What is an instance ?
        //Ans: We declare and instantiate.

        //Q. How to create new instance of a movie?
        //Ans: new keyword means we are creating a New Object in memory.

        //Q. How do you access members of an object
        //Ans: Use the dot operator.(Ex: darknight.MovieName)

        // There are 2 Types of date: 
        //1. Value 
        //2. Reference

        //********************************************************************

        //Movie darknight = new Movie();
        //darknight.MovieName = "Dark knight";
        //darknight.Year = 2008;
        //MessageBox.Show(darknight.Year.ToString());

        //*********************************************************************

        List<Students> students = new List<Students>();
        public MainWindow()
        {
            InitializeComponent();

            Instructor Manjula = new Instructor( "Rajan", "Manjula", "2551118");


            Manjula.LastName = "";// <--------------This is called Value 
            MessageBox.Show(Manjula.LastName);

            //Creating a new intance of a student object

            //Students student = new Students();
            //student.Firstname = "Manjula";
            //student.Lastname = "Rajan";
            //student.CSIGrade = 110;
            //student.GenEdGrade = 115;

            Students student = new Students("Manjula", "Rajan", 110, 115);
            Students student2 = new Students("Will", "Cram");

            students.Add(student);
            students.Add(student2);

            //What is the new Student () calling ?
            // The default constructor of student

            //Q what happens to the default constructor when I make a new constructor?
            //Ans. It goes away


            MessageBox.Show(FormattedStudents(student2));
           
        }

        public string FormattedStudents(Students student)
        {

            string studentInformation = student.Firstname + " " + student.Lastname + "-" + student.CSIGrade + "-" + student.GenEdGrade;

            return studentInformation;
        }
    }
}
