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
using System.Diagnostics;

namespace 记事本
{
    public partial class MainForm : Form
    {
        FindForm findForm = new FindForm();
        ReplaceForm replaceForm = new ReplaceForm();
        
        public MainForm()
        {
            InitializeComponent();
            findForm.Owner = this;//我是他爸爸
            replaceForm.Owner = this;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            if(Clipboard.GetText()=="")//判断剪贴板是否为空（粘贴选项En/disable）
                PastePToolStripMenuItem.Enabled = false;
            else
                PastePToolStripMenuItem.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void IndexChanged(object sender,EventArgs e)
        {
            /*SelectionStart返回的是从选中第一个字符开始的光标位置索引
             * GetLineFromCharIndex(index)方法会返回index索引的行号(从0开始)
             * GetFirstCharIndexOfCurrentLine()方法会返回当前光标行的第一个字符的索引
             */
            int line = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart)+1;
            int column = richTextBox1.SelectionStart-richTextBox1.GetFirstCharIndexOfCurrentLine()+1;
            toolStripStatusLabel3.Text = "  第 " + line.ToString()+" 行，第 "+column.ToString()+" 列";
            if(richTextBox1.SelectedText.Length>0)
            {
                CopyToolStripMenuItem.Enabled = true;
                CutToolStripMenuItem.Enabled = true;
                DelToolStripMenuItem.Enabled = true;
            }
            else
            {
                CopyToolStripMenuItem.Enabled = false;
                CutToolStripMenuItem.Enabled = false;
                DelToolStripMenuItem.Enabled = false;
            }
            if(Clipboard.GetText()=="")
                PastePToolStripMenuItem.Enabled = false;
            else
                PastePToolStripMenuItem.Enabled = true;
        }
        private DialogResult AskChangeSave()
        {
            DialogResult choice;
            if (openfile.isopen)
            choice = MessageBox.Show("是否将改动保存到 " + openfile.openpath, "保存", MessageBoxButtons.YesNoCancel);
            else
            choice = MessageBox.Show("是否将改动保存到 " + openfile.name, "保存", MessageBoxButtons.YesNoCancel);
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
            if (!openfile.isopen)//未打开文件（无标题）
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "文本文件|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)//选择保存路径
                {
                    richTextBox1.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                    richTextBox1.Modified = false;
                }
                else return false;//文件不选
            }
            else//打开了直接保存
            {
                richTextBox1.SaveFile(openfile.openpath, RichTextBoxStreamType.PlainText);
                richTextBox1.Modified = false;
            } 
            return true;//保存完成
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(richTextBox1.Modified)
            {
                if (AskChangeSave() == DialogResult.Cancel)
                    e.Cancel = true;
            }
            findForm.Dispose();
            replaceForm.Dispose();
            e.Cancel = false;
        }
        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Modified)
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
                openfile.openFileChangeType(open);
                this.Text = openfile.name+" - 记事本";
                sr.Close();
                richTextBox1.Modified = false;
            }
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                撤销ZToolStripMenuItem.Enabled = true;
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Modified)
            {
                if(AskChangeSave()==DialogResult.Cancel)
                    return;
            }
            openfile.isOpenInit();
            richTextBox1.Clear();
            this.Text = "无标题 - 记事本";
            openfile.name = "无标题";
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
                openfile.openFileChangeType(saveFile);
                this.Text = openfile.name+" - 记事本";
                richTextBox1.Modified = false;
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

        private void 撤销ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void 前进ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void PastePToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cn.bing.com/?scope=web&FORM=NPCTXT");
        }
        //子窗口传值
        private void 查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findForm.Show();
        }

        private void 查找下一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (findForm.textBox1.TextLength == 0)
                findForm.Show();
            else
                findForm.Startfind_Click(findForm, new EventArgs());
        }

        private void 替换RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaceForm.Show();
        }
    }
    public static class openfile
    {
        public static string openpath;//当前打开文件路径
        public static string name="无标题";//当前打开文件名
        public static bool isopen = false;//是否打开了文本
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
