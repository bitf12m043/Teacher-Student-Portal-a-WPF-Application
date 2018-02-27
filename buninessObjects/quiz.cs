using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buninessObjects
{
    public class quiz
    {
        int qID;

        public int QID
        {
            get { return qID; }
            set { qID = value; }
        }
        string statement, optionA, optionB, optionC, optionD;

        public string OptionD
        {
            get { return optionD; }
            set { optionD = value; }
        }

        public string OptionC
        {
            get { return optionC; }
            set { optionC = value; }
        }

        public string OptionA
        {
            get { return optionA; }
            set { optionA = value; }
        }

        public string OptionB
        {
            get { return optionB; }
            set { optionB = value; }
        }

        public string Statement
        {
            get { return statement; }
            set { statement = value; }
        }
        char correct;

        public char Correct
        {
            get { return correct; }
            set { correct = value; }
        }
    }
}
