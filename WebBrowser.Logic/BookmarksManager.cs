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

        public static void DeleteItem(BookmarkItem item)
        {
            try
            {
                var adapter = new BookmarksTableAdapter();
                adapter.Delete(item.id, item.url, item.title);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static BookmarkItem getSingleItem(int id)
        {
            BookmarkItem output = new BookmarkItem();
            List < BookmarkItem > items = BookmarksManager.GetItems();
            foreach (var item in items)
            {
                if (item.id == id)
                {
                    output.id = item.id;
                    output.url = item.url;
                    output.title = item.title;
                    break;
                }
            }
            return output;
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
                    item.id = row.Id;
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
