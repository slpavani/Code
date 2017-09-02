using System;

namespace WindowsFormsThreading
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
            this.Consume = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.ListBoxNumbers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Consume
            // 
            this.Consume.Location = new System.Drawing.Point(114, 37);
            this.Consume.Name = "Consume";
            this.Consume.Size = new System.Drawing.Size(329, 23);
            this.Consume.TabIndex = 0;
            this.Consume.Text = "Do time Consuming Work";
            this.Consume.UseVisualStyleBackColor = true;
            this.Consume.Click += new System.EventHandler(this.btnConsume_click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(114, 89);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(329, 23);
            this.Print.TabIndex = 1;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ListBoxNumbers
            // 
            this.ListBoxNumbers.FormattingEnabled = true;
            this.ListBoxNumbers.Location = new System.Drawing.Point(114, 147);
            this.ListBoxNumbers.Name = "ListBoxNumbers";
            this.ListBoxNumbers.Size = new System.Drawing.Size(329, 186);
            this.ListBoxNumbers.TabIndex = 2;
            this.ListBoxNumbers.Click += new System.EventHandler(this.btnList_click);
            // 
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 526);
            this.Controls.Add(this.ListBoxNumbers);
            this.Controls.Add(this.Consume);
            this.Controls.Add(this.Print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button Consume;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.ListBox ListBoxNumbers;
    }
}

