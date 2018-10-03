using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    class LearningItem
    {
        private string text;
        public LearningItem(string textstuff)
        {
            Text = textstuff;
        }

        public string Text
        {
            get
            {
                return text;
            }
            protected set
            {
                text = value; 
            }
        }

        public virtual string ToString()
        {
            return Text;
        }
    }
}
