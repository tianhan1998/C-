using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class FindForm : Form
    {
        private RichTextBox RichText = new RichTextBox();
        public FindForm()
        {
            InitializeComponent();
        }
        private void FindForm_Load(object sender, EventArgs e)
        {
            MainForm main = (MainForm)this.Owner;
            RichText = main.richTextBox1;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                startfind.Enabled = false;
            else
                startfind.Enabled = true;
            
        }

        private void Startfind_Click(object sender, EventArgs e)
        {
            int findindex;
            int searchindex = RichText.SelectionStart;
            if (RichText.SelectedText != "")
                searchindex += RichText.SelectedText.Length;
            findindex = RichText.Find(textBox1.Text, searchindex, RichTextBoxFinds.None);
            if (findindex < 0) 
            {
                MessageBox.Show("找不到" + "\"" + textBox1.Text + "\"","记事本", MessageBoxButtons.OK);
            }
            
        }
    }
}
