namespace MCQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtquiz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcorr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtwr1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtwr2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtwr3 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz";
            // 
            // txtquiz
            // 
            this.txtquiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquiz.Location = new System.Drawing.Point(113, 97);
            this.txtquiz.Multiline = true;
            this.txtquiz.Name = "txtquiz";
            this.txtquiz.Size = new System.Drawing.Size(310, 86);
            this.txtquiz.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correct Answer";
            // 
            // txtcorr
            // 
            this.txtcorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorr.Location = new System.Drawing.Point(113, 202);
            this.txtcorr.Multiline = true;
            this.txtcorr.Name = "txtcorr";
            this.txtcorr.Size = new System.Drawing.Size(310, 43);
            this.txtcorr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wrong Answer 1";
            // 
            // txtwr1
            // 
            this.txtwr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwr1.Location = new System.Drawing.Point(113, 276);
            this.txtwr1.Multiline = true;
            this.txtwr1.Name = "txtwr1";
            this.txtwr1.Size = new System.Drawing.Size(310, 43);
            this.txtwr1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Wrong Answer 2";
            // 
            // txtwr2
            // 
            this.txtwr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwr2.Location = new System.Drawing.Point(113, 330);
            this.txtwr2.Multiline = true;
            this.txtwr2.Name = "txtwr2";
            this.txtwr2.Size = new System.Drawing.Size(310, 43);
            this.txtwr2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wrong Answer 3";
            // 
            // txtwr3
            // 
            this.txtwr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwr3.Location = new System.Drawing.Point(113, 386);
            this.txtwr3.Multiline = true;
            this.txtwr3.Name = "txtwr3";
            this.txtwr3.Size = new System.Drawing.Size(310, 43);
            this.txtwr3.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(348, 448);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 504);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtwr3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtwr2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtwr1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcorr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtquiz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MCQ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcorr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtwr1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtwr2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtwr3;
        private System.Windows.Forms.Button btnadd;
    }
}

