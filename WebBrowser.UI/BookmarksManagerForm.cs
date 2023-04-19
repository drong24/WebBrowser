﻿using System;
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string searchItem = SearchBox.Text;
            var items = BookmarksManager.GetItems();
            listBox1.Items.Clear();

            try
            {
                foreach (var item in items)
                {
                    if (item.title.Contains(searchItem) || item.url.Contains(searchItem))
                    {
                        listBox1.Items.Add(string.Format("{0} ({1})", item.title, item.url));
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Refresh();
        }
    }
}
