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
        


        private void AddressTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoButton_Click_1(this, new EventArgs());
            }
        }
        private void GoButton_Click_1(object sender, EventArgs e)
        {
            string address = AddressTextBox.Text;
            webBrowser1.Navigate(address);

            Form1 form = this.ParentForm as Form1;
            form.historyLen++;
            form.history.Add(form.historyLen, address);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            webBrowser1.Navigate(form.history[form.historyLen - 1]);
            form.historyLen--;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            webBrowser1.Navigate(form.history[form.historyLen + 1]);
            form.historyLen++;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Form1 form = this.ParentForm as Form1;
            webBrowser1.Navigate(form.history[form.historyLen]);
        }

        private void BookmarkButton_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
