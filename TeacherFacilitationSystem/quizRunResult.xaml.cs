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

namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for quizRunResult.xaml
    /// </summary>
    public partial class quizRunResult : Window
    {
        
        public quizRunResult()
        {
            InitializeComponent();
        }

        public void setResult(result r)
        {
            this.Total.Content = r.Total;
            this.attempt.Content = r.Attempt;
            this.incorrect.Content = (r.Attempt - r.Correct);
            this.correct.Content = r.Correct;
            this.skip.Content = (r.Total - r.Attempt);
            this.marks.Content = r.Correct + "/" + r.Total;
            this.correctness.Content=(r.Correct/r.Attempt);
        }


    }
}
