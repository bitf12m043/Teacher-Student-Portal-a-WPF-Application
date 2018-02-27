using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buninessObjects
{
   public  class result
    {
        int total, attempt, correct, qid;

        public int Qid
        {
            get { return qid; }
            set { qid = value; }
        }

        public int Correct
        {
            get { return correct; }
            set { correct = value; }
        }

        public int Attempt
        {
            get { return attempt; }
            set { attempt = value; }
        }

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        string timing;

        public string Timing
        {
            get { return timing; }
            set { timing = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
