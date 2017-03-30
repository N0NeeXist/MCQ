namespace MCQ
{
    partial class Form6
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnrad1 = new System.Windows.Forms.RadioButton();
            this.btnrad2 = new System.Windows.Forms.RadioButton();
            this.btnrad3 = new System.Windows.Forms.RadioButton();
            this.btnrad4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(397, 82);
            this.textBox1.TabIndex = 1;
            // 
            // btnrad1
            // 
            this.btnrad1.AutoSize = true;
            this.btnrad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrad1.Location = new System.Drawing.Point(28, 33);
            this.btnrad1.MaximumSize = new System.Drawing.Size(500, 300);
            this.btnrad1.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnrad1.Name = "btnrad1";
            this.btnrad1.Size = new System.Drawing.Size(107, 50);
            this.btnrad1.TabIndex = 0;
            this.btnrad1.TabStop = true;
            this.btnrad1.Text = "radioButton1";
            this.btnrad1.UseVisualStyleBackColor = true;
            this.btnrad1.CheckedChanged += new System.EventHandler(this.btnrad1_CheckedChanged);
            // 
            // btnrad2
            // 
            this.btnrad2.AutoSize = true;
            this.btnrad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrad2.Location = new System.Drawing.Point(28, 99);
            this.btnrad2.MaximumSize = new System.Drawing.Size(500, 300);
            this.btnrad2.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnrad2.Name = "btnrad2";
            this.btnrad2.Size = new System.Drawing.Size(107, 50);
            this.btnrad2.TabIndex = 0;
            this.btnrad2.TabStop = true;
            this.btnrad2.Text = "radioButton1";
            this.btnrad2.UseVisualStyleBackColor = true;
            this.btnrad2.CheckedChanged += new System.EventHandler(this.btnrad1_CheckedChanged);
            // 
            // btnrad3
            // 
            this.btnrad3.AutoSize = true;
            this.btnrad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrad3.Location = new System.Drawing.Point(29, 162);
            this.btnrad3.MaximumSize = new System.Drawing.Size(400, 300);
            this.btnrad3.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnrad3.Name = "btnrad3";
            this.btnrad3.Size = new System.Drawing.Size(107, 50);
            this.btnrad3.TabIndex = 0;
            this.btnrad3.TabStop = true;
            this.btnrad3.Text = "radioButton1";
            this.btnrad3.UseVisualStyleBackColor = true;
            this.btnrad3.CheckedChanged += new System.EventHandler(this.btnrad1_CheckedChanged);
            // 
            // btnrad4
            // 
            this.btnrad4.AutoSize = true;
            this.btnrad4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrad4.Location = new System.Drawing.Point(28, 233);
            this.btnrad4.MaximumSize = new System.Drawing.Size(500, 300);
            this.btnrad4.MinimumSize = new System.Drawing.Size(0, 50);
            this.btnrad4.Name = "btnrad4";
            this.btnrad4.Size = new System.Drawing.Size(107, 50);
            this.btnrad4.TabIndex = 0;
            this.btnrad4.TabStop = true;
            this.btnrad4.Text = "radioButton1";
            this.btnrad4.UseVisualStyleBackColor = true;
            this.btnrad4.CheckedChanged += new System.EventHandler(this.btnrad1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrad4);
            this.groupBox1.Controls.Add(this.btnrad3);
            this.groupBox1.Controls.Add(this.btnrad2);
            this.groupBox1.Controls.Add(this.btnrad1);
            this.groupBox1.Location = new System.Drawing.Point(15, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 353);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Wrong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton btnrad1;
        private System.Windows.Forms.RadioButton btnrad2;
        private System.Windows.Forms.RadioButton btnrad3;
        private System.Windows.Forms.RadioButton btnrad4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}