using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCQ
{
    public partial class Form3 : Form
    {
        string[,] quizs;
        string[] selects;
        int wrongselect;
        List<int> temp = new List<int>();
        public Form3(string[] select,string[,] quiz)
        {
            InitializeComponent();
            int score=new int();
            quizs = quiz;
            selects = select;
            for (int i = 0; i < select.Length; i++)
            {
                if (select[i] == quiz[i, 1])
                    score += 1;
                else
                {
                    ListViewItem li = new ListViewItem(quiz[i,0]);
                    listView1.Items.Add(li);
                    temp.Add(i);
                   
                }
               
            }

            label2.Text = score + " / "+ select.Length;
                        
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm1 = new Form4(); 
            frm1.Closed+=(s,args)=>this.Close();
            frm1.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        //string printt;
        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    for (int i = 0; i < selects.Length; i++)
        //    {
        //        printt += quizs[i, 0] + "\n\n";
        //        for (int j = 1; j < 5; j++)
        //        {
        //            label1.ForeColor = System.Drawing.Color.Red;
        //            printt += "\t" + quizs[i, j] + "\n";
        //        }
        //        printt += "\n\n";
        //    }

        //    e.Graphics.DrawString(printt, new Font("arial", 16),new SolidBrush(Color.Black), new Point(10, 10));
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    printPreviewDialog1.Document = printDocument1;
        //    printPreviewDialog1.ShowDialog();
        //}
        int count = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Form6 frm = new Form6(wrongselect,selects);
            frm.ShowDialog();
            count++;
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            //wrongselect = listView1.SelectedIndices[0];
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)

                wrongselect = temp[listView1.SelectedIndices[0]] ;
        }
    }
}
