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
    /// Interaction logic for studentProfile.xaml
    /// </summary>
    public partial class studentProfile : Window
    {
        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        public studentProfile()
        {
            InitializeComponent();
        }

        private void viewDetail(object sender, RoutedEventArgs e)
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
            pwdScreen p = new pwdScreen();
            p.Name1 = this.Name1;
            p.Show();
        }
    }
}
