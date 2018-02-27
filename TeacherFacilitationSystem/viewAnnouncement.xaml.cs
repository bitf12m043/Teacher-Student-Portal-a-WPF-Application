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
    /// Interaction logic for viewAnnouncement.xaml
    /// </summary>
    public partial class viewAnnouncement : Window
    {
        mainDal posts;
        List<announcement> li;
        List<string> tiltes;
        public viewAnnouncement()
        {
            tiltes = new List<string>();
            posts = new mainDal(); 
            InitializeComponent();
            li=posts.getALLPost();
            foreach (announcement a in li)
            {
                string til = a.Title;
                tiltes.Add(til);
            }
            this.titleOfAnouncement.ItemsSource = tiltes;
            
        }

        private void openAnnouncement(object sender, RoutedEventArgs e)
        {

            string s=(string)this.titleOfAnouncement.SelectedItem;

            foreach (announcement a in li)
            {
                if (a.Title.Equals(s))
                {
                    this.anounce.Text = a.Contents;
                }
            }
           
        }
    }
}
