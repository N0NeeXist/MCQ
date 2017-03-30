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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        
        string[,] quiz;
        int num = 0;
        List<int> alreadyNo = new List<int>();
        int[] order;
        string[] select;
        

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] useless = File.ReadAllLines("quiz.txt");
            quiz = new string[useless.Length / 5, 5];

            List<int> alreadynum = new List<int>();
            order = new int[useless.Length / 5];
            for(int i=0;i<useless.Length/5;i++)
            {
            re:
                Random ran = new Random();               
                order[i] = ran.Next(0, useless.Length / 5);
                foreach(int temp in alreadynum)
                {
                    if(temp==order[i])
                        goto re;
                }
                alreadynum.Add(order[i]);
            }

            int once=0;
            for (int i = 0; i < useless.Length / 5;i++ )
            {
                for (int j = 0; j < 5; j++, once++)
                    quiz[i, j] = useless[once];
            }

            textBox1.Text = quiz[order[num], 0];
            btnrad1.Text = quiz[order[num], returnNo()];
            btnrad2.Text = quiz[order[num], returnNo()];
            btnrad3.Text = quiz[order[num], returnNo()];
            btnrad4.Text = quiz[order[num], returnNo()];

            select = new string[order.Length];
            btnnext.Enabled = false;
            btnpre.Enabled = false;

        }

        

        int returnNo()
        {
            int temp;            
            Random ran = new Random();
            re:
            temp = ran.Next(1,5);
            foreach (int tem in alreadyNo)
                if (tem == temp)
                    goto re;
            alreadyNo.Add(temp);
            return temp;
        }

       
        
       

        private void btnnext_Click(object sender, EventArgs e)
        {
            

            btnpre.Enabled = true;
            if (btnrad1.Checked == true)
            {
                select[order[num]] = btnrad1.Text;
                btnrad1.Checked = false;
            }
            else if (btnrad2.Checked == true)
            {
                select[order[num]] = btnrad2.Text;
                btnrad2.Checked = false;
            }
            else if (btnrad3.Checked == true)
            {
                select[order[num]] = btnrad3.Text;
                btnrad3.Checked = false;
            }
            else if (btnrad4.Checked == true)
            {
                select[order[num]] = btnrad4.Text;
                btnrad4.Checked = false;
            }

            btnnext.Enabled = false;

            num++;
            if (num >= order.Length)
            {
                this.Hide();
                var form3 = new Form3(select,quiz);
                form3.Closed += (s, args) => this.Close();
                form3.Show();                
                goto end;
            }
            alreadyNo = new List<int>();
            textBox1.Text = quiz[order[num], 0];
            btnrad1.Text = quiz[order[num], returnNo()];
            btnrad2.Text = quiz[order[num], returnNo()];
            btnrad3.Text = quiz[order[num], returnNo()];
            btnrad4.Text = quiz[order[num], returnNo()];

            
        end:
            btnnext.Enabled=false;
        }

        private void btnrad1_CheckedChanged(object sender, EventArgs e)
        {
            btnnext.Enabled = true;
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            
            num--;
            if (num == 0)
            {
                btnpre.Enabled = false;
                goto end;
            }
            alreadyNo = new List<int>();
            textBox1.Text = quiz[order[num], 0];
            btnrad1.Text = quiz[order[num], returnNo()];
            btnrad2.Text = quiz[order[num], returnNo()];
            btnrad3.Text = quiz[order[num], returnNo()];
            btnrad4.Text = quiz[order[num], returnNo()];

        end: ;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}
