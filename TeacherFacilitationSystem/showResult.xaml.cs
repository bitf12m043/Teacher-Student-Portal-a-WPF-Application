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
using System.Data;

namespace TeacherFacilitationSystem
{
    /// <summary>
    /// Interaction logic for showResult.xaml
    /// </summary>
    public partial class showResult : Window
    {
        public showResult()
        {
            InitializeComponent();
           
        }

        public void setData()
        {
            mainDal m=new mainDal();

            DataTable t = m.getReport();

            _reportViewer.LocalReport.DataSources.Clear();
            // it will clear the data source of 
            //report if any.
            _reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",t.DefaultView));
            // it will set the data source of report. First argument is dataset and 2nd in the table. 
            _reportViewer.LocalReport.ReportPath = "../../Report1.rdlc";
            // this sets the path of //report.
            _reportViewer.LocalReport.EnableExternalImages = true;
            _reportViewer.Visible = true;
            _reportViewer.RefreshReport();
        }

        public void setDataParticular(string name)
        {
            mainDal m = new mainDal();

            DataTable t = m.getPArticularReport(name);

            _reportViewer.LocalReport.DataSources.Clear();
            // it will clear the data source of 
            //report if any.
            _reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", t.DefaultView));
            // it will set the data source of report. First argument is dataset and 2nd in the table. 
            _reportViewer.LocalReport.ReportPath = "../../Report1.rdlc";
            // this sets the path of //report.
            _reportViewer.LocalReport.EnableExternalImages = true;
            _reportViewer.Visible = true;
            _reportViewer.RefreshReport();
        }





    }
}
