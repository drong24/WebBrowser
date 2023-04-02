using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class UserTools : UserControl
    {
        public UserTools()
        {
            InitializeComponent();
            
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl newTab = new TabControl();
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Daisy Rong\nID: dzr0070\n" +
              "Date: 03/26/2023\nSimple Web Browser");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddressTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoButton_Click(this, new EventArgs());
            }
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string address = AddressTextBox.Text;
            Form1 form = this.ParentForm as Form1;
            form.webBrowser1.Navigate(address);
            form.history.Add(form.historyLen, address);
            form.historyLen++;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            form.webBrowser1.Navigate(form.history[form.historyLen - 1]);
            form.historyLen--;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            form.webBrowser1.Navigate(form.history[form.historyLen + 1]);
            form.historyLen++;
        }
    }
}
