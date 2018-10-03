using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    class LectureNotes:LearningItem
    {
        private string date;

        public LectureNotes(string indate, string inNotes):base(inNotes)
        {
            Date = indate;
        }

        public string Date
        {
            get
            {
                return date;
            }
            protected set
            {
                date = value;
            }
        }

        public override string ToString()
        {
            return "Lecture notes for" + Date + "\n\n" + base.ToString();
        }
    }
}
