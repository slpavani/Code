using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Consume.Enabled = false;
            Print.Enabled = false;
            DoTimeConsumingWork();
            Consume.Enabled = true;
            Print.Enabled = true;

        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(3000);
        }

        private void btnConsume_click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                ListBoxNumbers.Items.Add(i);
            }
        }

        private void btnList_click(object sender, EventArgs e)
        {
            
        }
    }
}
