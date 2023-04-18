using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarksManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.url, item.title);

        }

        public static List<BookmarkItem> GetItems()
        {
            try
            {
                var adapter = new BookmarksTableAdapter();
                var output = new List<BookmarkItem>();
                var rows = adapter.GetData();

                foreach (var row in rows)
                {
                    var item = new BookmarkItem();
                    item.url = row.URL;
                    item.title = row.Title;
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
