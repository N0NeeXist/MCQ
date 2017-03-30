namespace MCQ
{
    partial class Form5
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Quizbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(252, 40);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(356, 40);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(80, 23);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "REMOVE";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Quizbox});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(16, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(437, 324);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Quizbox
            // 
            this.Quizbox.Text = "Quiz";
            this.Quizbox.Width = 419;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 511);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Name = "Form5";
            this.Text = "Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Quizbox;
    }
}