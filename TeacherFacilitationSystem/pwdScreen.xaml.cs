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
namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for pwdScreen.xaml
    /// </summary>
    public partial class pwdScreen : Window
    {
        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        public pwdScreen()
        {
            InitializeComponent();
        }

        private void changepwd(object sender, RoutedEventArgs e)
        {
            mainDal m = new mainDal();
            m.updatePassword(this.Name1,this.newpwd.Password);
            this.Close();
        }
    }
}
