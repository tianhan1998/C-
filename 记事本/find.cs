﻿using System;
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
            MainForm main = (MainForm)this.Owner;//告诉他谁是爹
            RichText = main.richTextBox1;
        }
        public void Show()
        {
            base.Show();
            if (RichText.SelectionLength != 0)
                textBox1.Text = RichText.SelectedText;
            textBox1.Focus();
            textBox1.SelectAll();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                startfind.Enabled = false;
            else
                startfind.Enabled = true;
        }

        public void Startfind_Click(object sender, EventArgs e)
        {
            int findindex;
            int searchindex = RichText.SelectionStart;//一定要创建这个局部变量来存开始搜索的索引
            if (radioButton2.Checked)//向下查找
            {
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
            else//向上查找
            {
                if (RichText.SelectedText != "")//选中状态（自己选或者搜索到高亮）
                    searchindex -= RichText.SelectedText.Length;//跳过选中区域
                findindex = RichText.Find(textBox1.Text, 0, searchindex, RichTextBoxFinds.Reverse);//倒着找
                if (findindex < 0)
                {
                    if (checkBox2.Checked && RichText.SelectionStart != RichText.Text.Length)//判断循环
                    {
                        RichText.SelectionStart = RichText.Text.Length;
                        RichText.SelectionLength = 0;
                        Startfind_Click(this, new EventArgs());

                    }
                    else
                        MessageBox.Show("找不到" + "\"" + textBox1.Text + "\"", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = radioButton2.Checked;
        }

        private void FindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
