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
using buninessObjects;
using Dal;

namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for updater.xaml
    /// </summary>
    public partial class updater : Window
    {
        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        public updater()
        {
            InitializeComponent();
        }

        private void updateinfo(object sender, RoutedEventArgs e)
        {
            user obj = new user();
            obj.Name = this.newName.Text;
            obj.Email = this.newEmail.Text;
            obj.Password = this.newPwd.Text;
            mainDal d = new mainDal();
            d.update(obj, this.Name1);
        }
    }
}
