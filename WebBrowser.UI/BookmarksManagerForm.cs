using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class BookmarksManagerForm : Form
    {
        public BookmarksManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarksManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarksManager.GetItems();
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("{0} ({1})", item.title, item.url));
            }
        }
    }
}
