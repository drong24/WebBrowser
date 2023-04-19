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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                listBox1.Items.Add(string.Format("{0}:{1}:{2}:{3}", item.id, item.date, item.title, item.url));
            }
        }

        private void HistorySearchButton_Click(object sender, EventArgs e)
        {
            string searchItem = HistorySearchText.Text;
            var items = HistoryManager.GetItems();
            listBox1.Items.Clear();

            try {
                foreach (var item in items)
                {
                    if (item.title.Contains(searchItem) || item.url.Contains(searchItem))
                    {
                        listBox1.Items.Add(string.Format("[{0}] {1} ({2})", item.date, item.title, item.url));
                    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            string item_info = listBox1.SelectedItem.ToString();
            string[] attributes = item_info.Split(':');
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //listBox1.Items.Remove(listBox1.SelectedItem);
            //MessageBox.Show(attributes[1]);
            
            int id = Convert.ToInt32( attributes[0]);
            HistoryItem item = HistoryManager.get_single_item(id);
            HistoryManager.delete_item(item);
            HistoryManagerForm_Load(sender, e);
        }

        private void ClearHistory_Click(object sender, EventArgs e)
        {
            List<HistoryItem> items = HistoryManager.GetItems();
            foreach(var item in items)
            {
                HistoryManager.delete_item(item);
            }
            listBox1.Items.Clear();
        }
    }
}
