using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class Form1 : Form
    {
        public Dictionary<int, string> history = new Dictionary<int, string>();
        public int historyLen = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Daisy Rong\nID: dzr0070\n" +
               "Date: 03/26/2023\nSimple Web Browser");
        }

        private void userTools1_Load(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(userTools1.AddressTextBox.Text);
        }

    }
}
