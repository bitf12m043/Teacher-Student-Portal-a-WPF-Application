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

namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for adminBoard.xaml
    /// </summary>
    public partial class adminBoard : Window
    {
        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        public adminBoard()
        {
            InitializeComponent();
        }

        private void showQuizWindow(object sender, RoutedEventArgs e)
        {
            quizManagement q = new quizManagement();
            q.Show();
        }

        private void anounce(object sender, RoutedEventArgs e)
        {
            postAnnouncement p = new postAnnouncement();
            p.Show();
        }

        private void reports(object sender, RoutedEventArgs e)
        {
            report r = new report();
            r.Show();
        }

        private void profile(object sender, RoutedEventArgs e)
        {
            adminProfile p = new adminProfile();
            p.Name1 = this.Name1;
            p.Show();
        }
    }
}
