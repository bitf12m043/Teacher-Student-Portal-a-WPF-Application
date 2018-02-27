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
    /// Interaction logic for startQuiz.xaml
    /// </summary>
    public partial class startQuiz : Window
    {
        string name;
        mainDal db;
        public string Name1
        {
            get { return name; }
            set { name = value; }
        }
        result r;
        int i = 0;
        List<quiz> li;
        public startQuiz()
        {
            db = new mainDal();
            DateTime d = DateTime.Now;
            InitializeComponent();
            r = new buninessObjects.result();
            r.Qid = 1;
            r.Attempt = 0;
            r.Correct = 0;
            r.Timing = d.ToString();

            li = db.startQuiz();

            this.statement.Content=li[i].Statement;
            opA.Content = li[i].OptionA;
            opB.Content = li[i].OptionB;
            opC.Content = li[i].OptionC;
            opD.Content = li[i].OptionD;
            r.Total = li.Count;

        }

        private void result1(object sender, RoutedEventArgs e)
        {
            r.Name = this.Name1;           
            mainDal r1 = new mainDal();
            r1.addResult(r);
            quizRunResult re = new quizRunResult();
            re.setResult(r);
            this.Close();
            re.Show();
            
        }

        private void nextQuestion(object sender, RoutedEventArgs e)
        {
            if (i >= li.Count)
                result1(null, null);
            else
            {
                char userSelection;
                if (opA.IsChecked.Equals(true))
                {
                    r.Attempt++;
                    opA.IsChecked=false;                   
                    userSelection = 'A';
                }
                else if (opB.IsChecked.Equals(true))
                {
                    r.Attempt++;
                    opB.IsChecked = false;
                   
                    userSelection = 'B';
                }
                else if (opC.IsChecked.Equals(true))
                {
                    r.Attempt++;
                    opC.IsChecked = false;                    
                    userSelection = 'C';
                }
                else if (opD.IsChecked.Equals(true))
                {
                    r.Attempt++;
                    opD.IsChecked = false;                  
                    userSelection = 'D';
                }
                else
                {
                    
                    userSelection = 'E';                
                }

                if (userSelection.Equals(li[i].Correct))
                    r.Correct++;

                 i++;
                
                   


                if (i < li.Count)
                {
                    statement.Content = li[i].Statement;
                    opA.Content = li[i].OptionA;
                    opB.Content = li[i].OptionB;
                    opC.Content = li[i].OptionC;
                    opD.Content = li[i].OptionD;
                }
            }

            
        }
    }
}
