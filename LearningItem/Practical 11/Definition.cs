using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    class Definition : LearningItem
    {
        private string term;
        private string def;

        public Definition(string termText, string defText) : base(defText)
        {
            Term = termText;
        }

        public string Term
        {
            get
            {
                return term;
            }
            protected set
            {
                term = value;
            }
        }

        public override string ToString()
        {
            return "Definition:" + Term + "\n\n" + base.ToString();
        }
    }
}
