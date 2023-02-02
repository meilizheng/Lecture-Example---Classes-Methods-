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

namespace Lecture_Example___Classes___Methods__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        Course csi122;
        public MainWindow()
        {
            InitializeComponent();
            csi122 = new Course("CSI 122", "Will Cram");
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //display student in student list;           
            AddStudentToList();            
            int lastStudentEntered = students.Count - 1;
            Student lastStudent = students[lastStudentEntered];
            runDisplay1.Text = "";
            runDisplay1.Text = "csi122.Course.Name" + " " + csi122.Teacher +"\n";

            foreach (Student student in csi122.ClassRoster)
            {
                runDisplay1.Text += student + "\n";
            }

            csi122.EnrollStudent(lastStudent);

            //DisplayStudetns();
        }
        public void AddStudentToList()
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            double CSI = double.Parse(txtCSI.Text);
            double GenED = double.Parse(txtGenEd.Text);
            //Add student to student list;
            students.Add(new Student(FirstName, LastName, CSI, GenED));
            //use dot operator to acess member inside of the instanced class;
        }

        public void DisplayStudetns() 
        {
            //clear the display;
            runDisplay1.Text = "";
            for (int i = 0; i < students.Count; i++)
            {
                runDisplay1.Text += students[i] + "\n";
            }
        }
    }
}
