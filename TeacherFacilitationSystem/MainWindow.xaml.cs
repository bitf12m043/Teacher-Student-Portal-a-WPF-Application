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
using buninessObjects;
using Dal;
namespace TeacherFacilitationSystem
{
    
   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckUser(object sender, RoutedEventArgs e)
        {
            mainDal check = new mainDal();
            if (teacher.IsChecked.Equals(true))
            {
               
               if( check.Login(this.username.Text,this.password.Password,"teacher"))
               {
                adminBoard a = new adminBoard();
                name = this.username.Text;
                a.Name1 = name;
                a.Show();
               }
               else
                   MessageBox.Show("Invalid Password");
            }
            else if (student.IsChecked.Equals(true))
            {
                if (check.Login(this.username.Text, this.password.Password, "student"))
                {
                    studentBoard s = new studentBoard();
                    s.Name1 = this.username.Text;
                    s.Show();
                }
                else
                    MessageBox.Show("Invalid Password");
            }

        }
    }
}
