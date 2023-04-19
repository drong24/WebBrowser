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
using WebBrowser.Logic;
using System.Threading;

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


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Main form = this.ParentForm as Main;
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            Main form = this.ParentForm as Main;
            webBrowser1.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Main form = this.ParentForm as Main;
            webBrowser1.Refresh();
        }

        private void BookmarkButton_ButtonClick(object sender, EventArgs e)
        {
            List<BookmarkItem> currBookmarks = BookmarksManager.GetItems();
            foreach (var curr in currBookmarks)
            {
                if (curr.url == AddressTextBox.Text)
                {
                    return;
                }
            }
            var bookmarkItem = new BookmarkItem();
            bookmarkItem.url = AddressTextBox.Text;
            bookmarkItem.title = webBrowser1.Document.Title;
            BookmarksManager.AddItem(bookmarkItem);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, ea) => Thread.Sleep(TimeSpan.FromSeconds(2));
            backgroundWorker.RunWorkerCompleted += (s, ea) =>
            {
                ProgressLabel.Text = "";
            };
            ProgressLabel.Text = "Done";
            backgroundWorker.RunWorkerAsync();

            var VisitedItem = new HistoryItem();
            VisitedItem.url = webBrowser1.Url.ToString();
            try
            {
                VisitedItem.title = webBrowser1.Document.Title;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
                VisitedItem.title = "History";

            }
            VisitedItem.date = DateTime.Now;
            HistoryManager.AddItem(VisitedItem);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            ProgressLabel.Text = "Loading";
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            this.BrowserProgressBar.Maximum = (int) e.MaximumProgress;
            if (e.CurrentProgress > 0)
            {
                this.BrowserProgressBar.Value = (int)e.CurrentProgress;
            }
        }
    }
}
