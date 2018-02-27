using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buninessObjects
{
    public class announcement
    {
        string title, date, contents;

        public string Contents
        {
            get { return contents; }
            set { contents = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

    }
}
