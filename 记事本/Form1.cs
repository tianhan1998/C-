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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private DialogResult AskChangeSave()
        {
            DialogResult choice = MessageBox.Show("是否将改动保存至" + istype.name, "保存", MessageBoxButtons.YesNoCancel);
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

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog()==DialogResult.OK)
                richTextBox1.Font = font.Font;
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
            name = Path.GetFileNameWithoutExtension(open.FileName);
            isopen = true;
        }
        public static void openFileChangeType(SaveFileDialog save)
        {
            openpath = save.FileName;
            name = Path.GetFileNameWithoutExtension(save.FileName);
            isopen = true;
        }
        public static void isOpenInit()//打开文件初始化
        {
            openpath = null;
            isopen = false;
        }
    }
}
