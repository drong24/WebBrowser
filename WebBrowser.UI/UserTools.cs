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
            Form1 form = (Form1)this.ParentForm as Form1;
            string title = "TabPage " + (form.tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            UserTools tool = new UserTools();

            myTabPage.Controls.Add(tool);
            myTabPage.Controls[0].Dock = DockStyle.Fill;
            form.tabControl1.TabPages.Add(myTabPage);
            
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = (Form1)this.ParentForm as Form1;
            form.tabControl1.TabPages.Remove(form.tabControl1.SelectedTab);
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
            form.historyLen++;
            form.history.Add(form.historyLen, address);

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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            form.webBrowser1.Navigate(form.history[form.historyLen]);
        }
    }
}
