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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LearningSpace;

namespace Practical_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Subject comsci = new Subject("Computer Science");
        private Subject sta = new Subject("Statistics");
        
        private int page = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PreviousBttn_Click(object sender, RoutedEventArgs e)
        {
            if (page >= 0 && page < CompileList().Length)
            {
                txtRevise.Text = CompileList()[page++];
            }
            else
            {
                page = 0;
                txtRevise.Text = CompileList()[page];
            }
        }

        private string[] CompileList()
        {
            List<string> mast = new List<string>();

            switch (SubComboBox.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < comsci.Def.ToArray().Length; i ++)
                    {
                        if (!(comsci.Def is null))
                            mast.Add(comsci.Def[i].ToString());
                    }
                    for (int i = 0; i < comsci.Ln.ToArray().Length; i++)
                    {
                        if (!(comsci.Ln is null))
                            mast.Add(comsci.Ln[i].ToString());
                    }
                    for (int i = 0; i < comsci.Exa.ToArray().Length; i++)
                    {
                        if (!(comsci.Exa is null))
                            mast.Add(comsci.Exa[i].ToString());
                    }
                    break;
                case 1:
                    for (int i = 0; i < sta.Def.ToArray().Length; i++)
                    {
                        if (!(sta.Def is null))
                            mast.Add(sta.Def[i].ToString());
                    }
                    for (int i = 0; i < sta.Ln.ToArray().Length; i++)
                    {
                        if (!(sta.Ln is null))
                            mast.Add(sta.Ln[i].ToString());
                    }
                    for (int i = 0; i < sta.Exa.ToArray().Length; i++)
                    {
                        if (!(sta.Exa is null))
                            mast.Add(sta.Exa[i].ToString());
                    }
                    break;
                default:
                    break;
            }
            return mast.ToArray();
        }

        private void AddNote_Click(object sender, RoutedEventArgs e)
        {
            switch(SubComboBox.SelectedIndex)
            {
                case 0:
                    List<LectureNotes> tempCom = comsci.Ln;
                    tempCom.Add(new LectureNotes(Convert.ToString(DateTime.Today), LnTxt.Text));
                    comsci.Ln = tempCom;
                    break;
                case 1:
                    List<LectureNotes> tempSta = sta.Ln;
                    tempSta.Add(new LectureNotes(Convert.ToString(DateTime.Today), LnTxt.Text));
                    sta.Ln = tempSta;
                    break;
                default:
                    break;
            }
        }

        private void AddDef_Click(object sender, RoutedEventArgs e)
        {
            switch(SubComboBox.SelectedIndex)
            {
                case 0:
                    List<Definition> tempCom = comsci.Def;
                    tempCom.Add(new Definition(TermTxt.Text, deftxt.Text));
                    comsci.Def = tempCom;
                    break;
                case 1:
                    List<Definition> tempSta = sta.Def;
                    tempSta.Add(new Definition(TermTxt.Text, deftxt.Text));
                    sta.Def = tempSta;
                    break;
                default:
                    break;
            }
        }

        private void AddExaBttn_Click(object sender, RoutedEventArgs e)
        {
            switch(SubComboBox.SelectedIndex)
            {
                case 0:
                    List<Examples> tempCom = comsci.Exa;
                    tempCom.Add(new Examples(ConceptTxt.Text, ExTxt.Text));
                    comsci.Exa = tempCom;
                    break;
                case 1:
                    List<Examples> tempSta = sta.Exa;
                    tempSta.Add(new Examples(ConceptTxt.Text, ExTxt.Text));
                    sta.Exa = tempSta;
                    break;
                default:
                    break;
            }
        }

        private void RevTab_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            if ((CompileList().Length != 0))
            {
                txtRevise.Text = CompileList()[page];
            }
            else
            {
                txtRevise.Text = "";
            }
        }
    }
}
