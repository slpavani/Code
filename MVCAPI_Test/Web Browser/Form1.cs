using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            webBrowser.GoHome();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void navigate_Click(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(new Uri(comboBox.SelectedItem.ToString()));
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void goForward_Click(object sender, System.EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }


    }
}
