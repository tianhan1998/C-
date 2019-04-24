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
    public partial class ReplaceForm : Form
    {
        private RichTextBox RichText;
        public ReplaceForm()
        {
            InitializeComponent();
        }
        public void Show()
        {
            base.Show();
            if(RichText.SelectionLength!=0)
            {
                textBox1.Text = RichText.SelectedText;
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                startfind.Enabled = false;
            else
                startfind.Enabled = true;
        }

        private void ReplaceForm_Load(object sender, EventArgs e)
        {
            MainForm main = (MainForm)Owner;
            RichText = main.richTextBox1;
        }

        private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void Startfind_Click(object sender, EventArgs e)
        {
            int findindex;
            int searchindex = RichText.SelectionStart;//一定要创建这个局部变量来存开始搜索的索引
            if (RichText.SelectedText != "")//选中状态（自己选或者搜索到高亮）
                searchindex += RichText.SelectedText.Length;//跳过选中区域
            if (checkBox1.Checked)//大小写匹配
                findindex = RichText.Find(textBox1.Text, searchindex, RichTextBoxFinds.MatchCase);
            else
                findindex = RichText.Find(textBox1.Text, searchindex, RichTextBoxFinds.None);//默认查找
            if (findindex < 0)
            {
                if (checkBox2.Checked && RichText.SelectionStart != 0)//判断循环选项
                {
                    RichText.SelectionStart = 0;//从头
                    RichText.SelectionLength = 0;
                    Startfind_Click(this, new EventArgs());
                }
                else
                    MessageBox.Show("找不到" + "\"" + textBox1.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
