using NoteBook.logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LogicText logicText = new LogicText();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string contextString = richTextBox1.Text;
            string title = textBox1.Text;

            logicText.save(title, contextString);

            MessageBox.Show("保存成功");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string subTitle = txtSearch.Text;

           DataTable dataTable=  logicText.query(subTitle);

            DGVSearch.DataSource = dataTable;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello world");

            MessageBox.Show("hello world");
        }
    }
}
