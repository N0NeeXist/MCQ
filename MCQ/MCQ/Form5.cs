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

namespace MCQ
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        string[] useless;
        string[,] quiz;
        int quiztotal;

        private void Form5_Load(object sender, EventArgs e)
        {
            
            useless = File.ReadAllLines("quiz.txt");
            quiztotal=useless.Length/5;
            quiz = new string[quiztotal, 5];
            int n = 0;
            for(int i=0;i<quiztotal;i++)
            {
                for(int j=0;j<5;j++,n++)
                    quiz[i,j]=useless[n];
                ListViewItem li = new ListViewItem(quiz[i, 0]);
                listView1.Items.Add(li);
            }

            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedIndices[0];
            
            useless=new string[(quiztotal-1)*5];

            File.Delete("quiz.txt");
            File.Create("quiz.txt").Close();

            int n=0;
            for (int i = 0; i < quiztotal; i++)
            {
                if (i == index)
                    continue;
                for (int j = 0; j < 5; j++, n++)
                    useless[n] = quiz[i, j];
            }

            File.AppendAllLines("quiz.txt", useless);
            foreach (ListViewItem temp in listView1.SelectedItems)
                listView1.Items.Remove(temp);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            
            frm1.ShowDialog();

            listView1.Clear();
            listView1.Columns.Add(new ColumnHeader());
            listView1.Columns[0].Text = "Quiz";
            useless = File.ReadAllLines("quiz.txt");
            quiztotal = useless.Length / 5;
            quiz = new string[quiztotal, 5];
            int n = 0;
            for (int i = 0; i < quiztotal; i++)
            {
                for (int j = 0; j < 5; j++, n++)
                    quiz[i, j] = useless[n];
                ListViewItem li = new ListViewItem(quiz[i, 0]);
                listView1.Items.Add(li);
            }
            this.Show();

            
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
