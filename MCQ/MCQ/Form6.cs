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
    public partial class Form6 : Form
    {
        int wrongselect;
        string[] select;
        public Form6(int wrongselects,string[] selects)
        {
            InitializeComponent();
            wrongselect = wrongselects;
            select = selects;
        }
        
     
        

        private void Form2_Load(object sender, EventArgs e)
        {

           string[] useless=File.ReadAllLines("quiz.txt");
            int n=0;
            string[,] quiz=new string[useless.Length/5,5];
            for(int i=0;i<useless.Length/5;i++)
            {
                for(int j=0;j<5;j++,n++)
                    quiz[i,j]=useless[n];
            }
            textBox1.Text = quiz[wrongselect, 0];
            btnrad1.ForeColor = System.Drawing.Color.Green;
            btnrad1.Text = quiz[wrongselect, 1];            
            btnrad2.Text = quiz[wrongselect, 2];
            btnrad3.Text = quiz[wrongselect, 3];
            btnrad4.Text = quiz[wrongselect, 4];

            if(btnrad2.Text==select[wrongselect])
            {
                btnrad2.ForeColor = System.Drawing.Color.Red;
                btnrad2.Checked = true;
            }
            if (btnrad3.Text == select[wrongselect])
            {
                btnrad3.ForeColor = System.Drawing.Color.Red;
                btnrad3.Checked = true;
            }
            if (btnrad4.Text == select[wrongselect])
            {
                btnrad4.ForeColor = System.Drawing.Color.Red;
                btnrad4.Checked = true;
            }


          
        }











        private void btnrad1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

      

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}
