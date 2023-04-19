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
using WebBrowser.Logic.WebBrowserDBDataSetTableAdapters;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webBrowserDBDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.webBrowserDBDataSet.History);
            foreach (var item in this.webBrowserDBDataSet.History)
            {
                listBox1.Items.Add(item);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        { 
            string searchItem = SearchBox.Text;
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

            try
            {
                foreach (var item in items)
                {
                    
                                  
                }
                if (listBox1.Items.Count < 1)
                {
                    listBox1.Items.Add("No Results Found");
                }

            }
            catch
            {
                listBox1.Items.Add("No Results Found");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.historyBindingSource.RemoveCurrent();
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Refresh();
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
