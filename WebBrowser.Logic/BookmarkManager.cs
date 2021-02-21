using System;
using System.Collections.Generic;
using System.Text;
using WebBrowser.Data2.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {

        public static BookmarksTableAdapter adapter = new BookmarksTableAdapter();

        public static void AddItem(BookmarkItem item)
        {
            var rows = adapter.GetData();
            bool noMatch = true;
            foreach (var row in rows)
            {
                if (row.URL == item.URL)
                    noMatch = false;
            }
            if(noMatch)
                adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }

            return results;
        }

        public static void deleteItem(BookmarkItem item)
        {
            adapter.Delete(item.Id);
        }
    }
}
