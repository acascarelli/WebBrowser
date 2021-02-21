using System;
using System.Collections.Generic;
using System.Text;
using WebBrowser.Data2.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static HistoryItem lastSite;
        public static HistoryTableAdapter adapter = new HistoryTableAdapter();

        public static void AddItem(HistoryItem item)
        {
            if(lastSite == null || item.Title != lastSite.Title)
            {
                adapter.Insert(item.URL, item.Title, item.Date);
                lastSite = item;                
            }            
        }

        public static List<HistoryItem> GetItems()
        {
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach(var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;
                results.Add(item);
            }

            return results;
        }

        public static void deleteItem(HistoryItem item)
        {
            adapter.Delete(item.Id, item.Date);
        }

        public static void deleteAll()
        {
            var rows = adapter.GetData();
            foreach(var row in rows)
            {
                adapter.Delete(row.Id, row.Date);
            }
        }
    }
}
