using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    class HistoryItem
    {
        string url; string title; DateTime date;

        public HistoryItem(string urlIn, string titleIn, DateTime dateIn)
        {
            url = urlIn;
            title = titleIn;
            date = dateIn;
        }
    }
}
