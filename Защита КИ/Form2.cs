using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
namespace Защита_КИ
{
    public partial class Form2 : Form
    {

        


        public Form2()
        {
            InitializeComponent();
            
        }
        private void LoadDoc(string filename)
        {
            richTextBox1.ReadOnly = false;
            richTextBox1.SelectAll();
            richTextBox1.SelectionHangingIndent += 15;
            richTextBox1.DeselectAll();
            Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
            object File = filename;
            object nullobject = System.Reflection.Missing.Value;
            wordObject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            richTextBox1.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);
            wordObject.Quit();
            richTextBox1.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem2.Text;
            //this.richTextBox1.Text = 
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory+"themes/theme1.docx");
            this.richTextBox1.SelectionStart = 0;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem3.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory+"themes/theme2.docx");
            this.richTextBox1.SelectionStart = 0;
        }        
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem5.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory + "themes/theme4.docx");
            this.richTextBox1.SelectionStart = 0;
        }
        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem15.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory + "themes/theme14.docx");
            this.richTextBox1.SelectionStart = 0;
        }
        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem4.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory + "themes/theme3.docx");
            this.richTextBox1.SelectionStart = 0;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem6.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory + "themes/theme5.docx");
            this.richTextBox1.SelectionStart = 0;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem7.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory + "themes/theme6.docx");
            this.richTextBox1.SelectionStart = 0;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.groupBox1.Text = this.toolStripMenuItem8.Text;
            LoadDoc(AppDomain.CurrentDomain.BaseDirectory + "themes/theme7.docx");
            this.richTextBox1.SelectionStart = 0;
        }



    }
}
