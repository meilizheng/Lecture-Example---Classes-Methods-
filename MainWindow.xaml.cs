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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            double CSI = double.Parse(txtCSI.Text);
            double GenED = double.Parse(txtGenEd.Text);
            //Add student to student list;
            students.Add(new Student(FirstName, LastName, CSI, GenED));
            //display student in student list;
            //use dot operator to acess member inside of the instanced class;
            Student s = students[0];
            runDisplay1.Text = s.ToString();
        }
    }
}
