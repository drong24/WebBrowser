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
        /*
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AddressTextBox.Text);
        }
        private void AddressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolStripButton4_Click(this, new EventArgs());
            }
        }*/
    }
}
