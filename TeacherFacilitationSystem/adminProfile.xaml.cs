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
    /// Interaction logic for adminProfile.xaml
    /// </summary>
    public partial class adminProfile : Window
    {
        public adminProfile()
        {
            InitializeComponent();
        }

        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }

        private void add(object sender, RoutedEventArgs e)
        {

            addStudent s = new addStudent();
            s.Show();
        }

        private void view(object sender, RoutedEventArgs e)
        {
            mainDal m = new mainDal();
            user u = m.getDetail(name);
            MessageBox.Show("Name: " + u.Name + "\n Password:" + u.Password + "\nEmail:" + u.Email + "\n Designation:" + u.Designation);
        }

        private void updateDetails(object sender, RoutedEventArgs e)
        {
            updater u = new updater();
            u.Name1 = this.Name1;
            u.Show();
        }

        private void changePwd(object sender, RoutedEventArgs e)
        {
            pwdScreen s = new pwdScreen();
            s.Name1 = this.Name1;
            s.Show();
        }
    }
}
