namespace ContactList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.ContactList = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(75, 110);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number ";
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Lucida Calligraphy", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameText.Location = new System.Drawing.Point(242, 58);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(171, 24);
            this.firstNameText.TabIndex = 3;
            this.firstNameText.TextChanged += new System.EventHandler(this.firstNameText_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Lucida Calligraphy", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameText.Location = new System.Drawing.Point(242, 114);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(172, 24);
            this.lastNameText.TabIndex = 4;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Lucida Calligraphy", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(242, 168);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(171, 24);
            this.phoneText.TabIndex = 5;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.Location = new System.Drawing.Point(160, 243);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(181, 45);
            this.btnAddContact.TabIndex = 6;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // ContactList
            // 
            this.ContactList.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactList.FormattingEnabled = true;
            this.ContactList.ItemHeight = 27;
            this.ContactList.Location = new System.Drawing.Point(486, 26);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(391, 436);
            this.ContactList.TabIndex = 7;
            this.ContactList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(562, 482);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(262, 27);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort Contact List";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btn_Sort);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 568);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.ContactList);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.ListBox ContactList;
        private System.Windows.Forms.Button btnSort;
    }
}

