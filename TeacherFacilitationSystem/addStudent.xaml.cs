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
using System.Windows.Shapes;
using Dal;
using buninessObjects;
namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for addStudent.xaml
    /// </summary>
    public partial class addStudent : Window
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void addStudent1(object sender, RoutedEventArgs e)
        {
            user student = new user();
            mainDal add = new mainDal();
            student.Name = this.nameBox.Text;
            student.Password = this.pwdBox.Text;
            student.Email = this.emailBox.Text;
            student.Designation = "student";
            add.addStudent1(student);
            this.Close();
        }
    }
}
