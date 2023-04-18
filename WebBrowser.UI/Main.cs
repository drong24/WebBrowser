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
    public partial class Main : Form
    {
        public int BookmarkCount = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void userTools1_Load(object sender, EventArgs e)
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

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage tabPage = new TabPage(title);
            menuStrip1 = new MenuStrip();
            tabPage.Controls.Add(menuStrip1);
            tabPage.Controls[0].Dock = DockStyle.Top;
            UserTools tool = new UserTools();
            tabPage.Controls.Add(tool);
            tabPage.Controls[1].Dock = DockStyle.Fill;
            tabControl1.TabPages.Add(tabPage);
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryManagerForm();
            historyForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarksForm = new BookmarksManagerForm();
            bookmarksForm.ShowDialog();
        }
    }
}
