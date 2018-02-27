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
    /// Interaction logic for studentBoard.xaml
    /// </summary>
    public partial class studentBoard : Window
    {
        string name;

        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        public studentBoard()
        {
            InitializeComponent();
        }

        private void showProfile(object sender, RoutedEventArgs e)
        {
            studentProfile p = new studentProfile();
            p.Show();
        }

        private void rofile(object sender, RoutedEventArgs e)
        {
            studentProfile p = new studentProfile();
            p.Name1 = this.Name1;
            p.Show();
        }

        private void getAnnounce(object sender, RoutedEventArgs e)
        {
            viewAnnouncement v = new viewAnnouncement();
            v.Show();
        }

        private void startQuiz(object sender, RoutedEventArgs e)
        {
            startQuiz s = new startQuiz();
            s.Name1 = this.Name1;
           
            s.Show();
        }

        private void showResult(object sender, RoutedEventArgs e)
        {
            showResult r = new showResult();
            r.setDataParticular(this.Name1);
            this.Close();
            r.Show();
        }
    }
}
