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
    /// Interaction logic for particularResult.xaml
    /// </summary>
    public partial class particularResult : Window
    {
        public particularResult()
        {
            InitializeComponent();
        }

        private void ShowResult(object sender, RoutedEventArgs e)
        {
            showResult r = new showResult();
            r.setDataParticular(nameBox.Text);
            this.Close();
            r.Show();
        }
    }
}
