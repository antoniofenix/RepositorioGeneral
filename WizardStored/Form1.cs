using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardStored
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Style GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        Style BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        Style CyanStyle = new TextStyle(new SolidBrush(Color.FromArgb(43, 145, 175)), null, FontStyle.Regular);
        /// <summary>
        /// dfsgfg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            ////new edition
            //Range range = (sender as FastColoredTextBox).VisibleRange;                                                       //FastColoredTextBox).Range

            ////clear style of changed range
            //range.ClearStyle(GreenStyle);

            ////comment highlighting
            //range.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            //range.SetStyle(GreenStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            //range.SetStyle(GreenStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
            //range.SetStyle(CyanStyle, @"\b(class|struct|enum)\s+(?<range>[\w_]+?)\b");

            //// clear style of changed range
            //e.ChangedRange.ClearStyle(GreenStyle);
            ////keyword highlighting
            //e.ChangedRange.SetStyle(BlueStyle, @"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|void|volatile|while|add|alias|ascending|descending|dynamic|from|get|global|group|into|join|let|orderby|partial|remove|select|set|value|var|where|yield)\b|#region\b|#endregion\b");
            //// comment highlighting
            //e.ChangedRange.SetStyle(GreenStyle, @"//.*$", RegexOptions.Multiline);
            //// agrega el color a las palabras despeus de la calse 
            //e.ChangedRange.SetStyle(CyanStyle, @"\b(class|struct|enum)\s+(?<range>[\w_]+?)\b");
            // //keyword highlighting 
            //e.ChangedRange.SetStyle(CyanStyle, @"\b(IEnumerator|Form|Range|Type)\b");
        }
    }
}