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
using System.IO;
namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for addquestion.xaml
    /// </summary>
    public partial class addquestion : Window
    {
        List<quiz> li;
        List<char> options;
        public addquestion()
        {
            options = new List<char>();
            options.Add('A');
            options.Add('B');
            options.Add('C');
            options.Add('D');
            
            InitializeComponent();
            this.correctop.ItemsSource = options;
            li = new List<quiz>();
        }

        private void openFileWindow(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            this.Close();
            dlg.ShowDialog();

            MessageBox.Show(dlg.FileName);
            if (!dlg.FileName.Equals(null))
            {
                StreamReader r = new StreamReader(dlg.FileName);
                string Data;
                while ((Data = r.ReadLine()) != null)
                {
                    quiz q = new quiz();
                    q.Statement = Data;
                    Data = r.ReadLine();
                    string[] breaker = Data.Split(';');
                    q.OptionA = breaker[0];
                    q.OptionB = breaker[1];
                    q.OptionC = breaker[2];
                    q.OptionD = breaker[3];
                    MessageBox.Show(breaker[3]);
                    q.Correct = char.Parse(breaker[4]);
                    li.Add(q);
                }

                Done1(null, null);
            }
        }

        private void addToList(object sender, RoutedEventArgs e)
        {
            quiz q = new quiz();
            q.Statement=statement.Text;
            q.OptionA = opA.Text;
            q.OptionB = opB.Text;
            q.OptionC = opC.Text;
            q.OptionD = opD.Text;
            //MessageBox.Show(correctop.SelectedItem.ToString());
            q.Correct = (char)correctop.SelectedItem;
            li.Add(q);
        }

        private void Done1(object sender, RoutedEventArgs e)
        {
            mainDal d1 = new mainDal();
            d1.addQuiz(li);
            this.Close();
        }
    }
}
