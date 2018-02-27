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
    /// Interaction logic for deleteQuizScreen.xaml
    /// </summary>
    public partial class deleteQuizScreen : Window
    {
        public deleteQuizScreen()
        {
            InitializeComponent();
        }

        private void delQuiz(object sender, RoutedEventArgs e)
        {
            mainDal m = new mainDal();

            string val = delVal.Text;
            int id = 0;
            try
            {
                id = int.Parse(val);
            }
            catch
            {
                delVal.Text = "Enter Valid id";
            }

            m.deleteQuiz(id);
        
        }
    }
}
