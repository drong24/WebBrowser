using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.url, item.title, item.date);
           
        }

        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var output = new List<HistoryItem>;
        }
    }
}
