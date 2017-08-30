namespace Web_Browser
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.navigate = new System.Windows.Forms.ToolStripMenuItem();
            this.home = new System.Windows.Forms.ToolStripMenuItem();
            this.goBack = new System.Windows.Forms.ToolStripMenuItem();
            this.gOFORWARD = new System.Windows.Forms.ToolStripMenuItem();
            this.goButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigate});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(690, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // navigate
            // 
            this.navigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.goBack,
            this.gOFORWARD});
            this.navigate.Name = "navigate";
            this.navigate.Size = new System.Drawing.Size(66, 20);
            this.navigate.Text = "Navigate";
            this.navigate.Click += new System.EventHandler(this.navigate_Click);
            // 
            // home
            // 
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(135, 22);
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // goBack
            // 
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(135, 22);
            this.goBack.Text = "Go Back";
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // gOFORWARD
            // 
            this.gOFORWARD.Name = "gOFORWARD";
            this.gOFORWARD.Size = new System.Drawing.Size(135, 22);
            this.gOFORWARD.Text = "Go Forward";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(310, 27);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "https://msdn.microsoft.com",
            "https://www.youtube.com/watch?v=OAPfmNaQlt0",
            "https://en.wikipedia.org/wiki"});
            this.comboBox.Location = new System.Drawing.Point(105, 29);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(196, 21);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(42, 83);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(602, 301);
            this.webBrowser.TabIndex = 3;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 417);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem navigate;
        private System.Windows.Forms.ToolStripMenuItem home;
        private System.Windows.Forms.ToolStripMenuItem goBack;
        private System.Windows.Forms.ToolStripMenuItem gOFORWARD;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

