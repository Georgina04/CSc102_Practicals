using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    class Subject
    {
        private string subjectName;
        private List<Definition> def = new List<Definition>();
        private List<Examples> exa = new List<Examples>();
        private List<LectureNotes> ln = new List<LectureNotes>();

        public Subject(string inSubjectName,List<Definition> inDef, List<Examples> inExa, List<LectureNotes> inLn)
        {
            SubName = inSubjectName;
            Def = inDef;
            Exa = inExa;
            Ln = inLn;
        }

        public Subject(string inSubjectName)
        {
            SubName = inSubjectName;
        }

        public string SubName
        {
            get
            {
                return subjectName;
            }
            protected set
            {
                subjectName = value;
            }
        }

        
        
        public List<Definition> Def
        {
            get
            {
                return def;
            }
            protected set
            {
                def = value;
            }
        }
        
        public List<Examples> Exa
        {
            get
            {
                return exa;
            }
            protected set
            {
                exa = value;
            }
        }
        
        public List<LectureNotes> Ln
        {
            get
            {
                return ln;
            }
            protected set
            {
                ln = value;
            }
        }
        
        public virtual string ToString()
        {
            return SubName;
            
        }
    }
}
