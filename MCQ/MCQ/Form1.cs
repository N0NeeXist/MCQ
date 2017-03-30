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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int countwrong = 0;
            if (txtwr1.Text == "")
            {
                txtwr1.Text = " ";
                countwrong++;
            }
            if (txtwr2.Text == "")
            {
                txtwr2.Text = " ";
                countwrong++;
            }
            if (txtwr3.Text == "")
            {
                txtwr3.Text = " ";
                countwrong++;
            }
            if (txtquiz.Text == "" || txtcorr.Text == "" || countwrong==3)
            {
                MessageBox.Show("Must have Quiz and Correct Answer and 1 Wrong Answer");
            }
          

            string[] addtext = { txtquiz.Text, txtcorr.Text, txtwr1.Text, txtwr2.Text, txtwr3.Text };
            if(!File.Exists("quiz.txt"))
            {
                File.Create("quiz.txt").Close();
            }
            File.AppendAllLines("quiz.txt", addtext);

            txtquiz.Text = "";
            txtcorr.Text = "";
            txtwr1.Text = "";
            txtwr2.Text = "";
            txtwr3.Text = "";
            txtquiz.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtquiz.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
