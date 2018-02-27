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
    /// Interaction logic for quizManagement.xaml
    /// </summary>
    public partial class quizManagement : Window
    {
        public quizManagement()
        {
            InitializeComponent();
        }

        private void addQuestions(object sender, RoutedEventArgs e)
        {
            addquestion q = new addquestion();
            q.Show();
        }

        private void ViewData(object sender, RoutedEventArgs e)
        {
            allQuizez q = new allQuizez();
            q.Show();
        }

        private void deleteQuiz(object sender, RoutedEventArgs e)
        {
            deleteQuizScreen d = new deleteQuizScreen();
            d.Show();
        }
    }
}
