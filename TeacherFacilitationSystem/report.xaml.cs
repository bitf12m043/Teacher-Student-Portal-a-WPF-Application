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
    /// Interaction logic for report.xaml
    /// </summary>
    public partial class report : Window
    {
        public report()
        {
            InitializeComponent();
        }

        private void showAll(object sender, RoutedEventArgs e)
        {
            showResult s = new showResult();
            this.Close();
            s.setData();
            s.Show();
        }

        private void showParticualr(object sender, RoutedEventArgs e)
        {
            particularResult p = new particularResult();
            p.Show();
        }
    }
}
