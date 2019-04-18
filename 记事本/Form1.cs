using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void IndexChanged(object sender,EventArgs e)
        {
            /*SelectionStart返回的是从第一个字符开始的光标位置索引
             * GetLineFromCharIndex(index)方法会返回index索引的行号(从0开始)
             * GetFirstCharIndexOfCurrentLine()方法会返回当前光标行的第一个字符的索引
             */
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart)+1;
            int column = richTextBox1.SelectionStart-richTextBox1.GetFirstCharIndexOfCurrentLine()+1;
            toolStripStatusLabel3.Text = "  第 " + line.ToString()+" 行，第 "+column.ToString()+" 列";
        }
        private DialogResult AskChangeSave()
        {
            DialogResult choice;
            if (istype.isopen)
            choice = MessageBox.Show("是否将改动保存到 " + istype.openpath, "保存", MessageBoxButtons.YesNoCancel);
            else
            choice = MessageBox.Show("是否将改动保存到 " + istype.name, "保存", MessageBoxButtons.YesNoCancel);
            if (choice == DialogResult.Yes)
            {
                if (Save())
                    return DialogResult.Yes;
                else
                    return DialogResult.Cancel;
            }
            else return choice;
        }
        private bool Save()//true保存成功 false取消保存
        {
            if (!istype.isopen)//未打开文件（无标题）
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "文本文件|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)//选择保存路径
                {
                    richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                    istype.ischange = false;
                }
                else return false;//文件不选
            }
            else//打开了直接保存
            {
                richTextBox1.SaveFile(istype.openpath, RichTextBoxStreamType.PlainText);
                istype.ischange = false;
            } 
            return true;//保存完成
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(istype.ischange)
            {
                if (AskChangeSave() == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(istype.ischange)
            {
                if(AskChangeSave()==DialogResult.Cancel)
                    return;
            }
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "文本文件|*.txt";
            if (open.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Clear();
                StreamReader sr = new StreamReader(open.FileName, Encoding.GetEncoding("gbk"));
                string str = sr.ReadLine();
                while (str != null)
                {
                    richTextBox1.AppendText(str + "\n");
                    str = sr.ReadLine();
                }
                istype.openFileChangeType(open);
                this.Text = istype.name+" - 记事本";
                sr.Close();
                istype.ischange = false;
            }
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            istype.ischange = true;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(istype.ischange)
            {
                if(AskChangeSave()==DialogResult.Cancel)
                    return;
            }
            istype.isOpenInit();
            richTextBox1.Clear();
            this.Text = "无标题 - 记事本";
            istype.name = "无标题";
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "文本文件|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)//选择保存路径
            {
                richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                istype.openFileChangeType(saveFile);
                this.Text = istype.name+" - 记事本";
                istype.ischange = false;
            }
        }

        private void FontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog.ShowDialog();
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog print= new PrintDialog();
            print.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 格式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 字体ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog()==DialogResult.OK)
                richTextBox1.Font = font.Font;
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = 自动换行ToolStripMenuItem.Checked;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
    public static class istype
    {
        public static string openpath;//当前打开文件路径
        public static string name="无标题";//当前打开文件名
        public static bool isopen = false;//是否打开了文本
        public static bool ischange = false;//文本改变
        public static void openFileChangeType(OpenFileDialog open)//打开文件改变类型
        {
            openpath = open.FileName;
            name = Path.GetFileName(open.FileName);
            isopen = true;
        }
        public static void openFileChangeType(SaveFileDialog save)//另存为后进入
        {
            openpath = save.FileName;
            name = Path.GetFileName(save.FileName);
            isopen = true;
        }
        public static void isOpenInit()//打开文件初始化
        {
            openpath = null;
            isopen = false;
        }
    }
}
