using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    class Examples : LearningItem
    {
        private string concept;
        private string text;

        public Examples(string inConcept, string inText):base(inText)
        {
            Concept = inConcept;
        }

        public string Concept
        {
            get
            {
                return concept;
            }
            protected set
            {
                concept = value;
            }
        }

        public override string ToString()
        {
            return "##" + Concept + "##\n\n" + base.ToString();
        }
    }
}
