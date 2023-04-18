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

namespace WebBrowser.UI
{
    public partial class UserTools : UserControl
    {
        public UserTools()
        {
            InitializeComponent();
            
        }

        int BookmarkCount = 0;

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

            var VisitedItem = new HistoryItem();
            VisitedItem.url = address;
            VisitedItem.title = webBrowser1.Document.Title;
            VisitedItem.date = DateTime.Now;
            HistoryManager.AddItem(VisitedItem);
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
    }
}
