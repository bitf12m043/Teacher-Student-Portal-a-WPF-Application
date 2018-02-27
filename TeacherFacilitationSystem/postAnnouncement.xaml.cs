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
    /// Interaction logic for postAnnouncement.xaml
    /// </summary>
    public partial class postAnnouncement : Window
    {
        public postAnnouncement()
        {
            InitializeComponent();
        }

        private void postTodb(object sender, RoutedEventArgs e)
        {
            mainDal post = new mainDal();
            announcement a = new announcement();
            a.Title = this.titleBox.Text;
            a.Contents = this.contentBox.Text;
            DateTime d = DateTime.Now;
            a.Date = d.ToString();
            post.post(a);
            this.Close();
        }


    }
}
