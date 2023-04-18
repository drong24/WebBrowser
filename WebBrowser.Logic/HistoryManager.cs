using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            try
            {
                var adapter = new HistoryTableAdapter();
                adapter.Insert(item.url, item.title, item.date);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        public static List<HistoryItem> GetItems()
        {
            try {
                var adapter = new HistoryTableAdapter();
                var output = new List<HistoryItem>();
                var rows = adapter.GetData();

                foreach (var row in rows)
                {
                    var item = new HistoryItem();
                    item.url = row.URL;
                    item.title = row.Title;
                    item.date = row.Date;

                    output.Add(item);
                }
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            }
        
    }
}
