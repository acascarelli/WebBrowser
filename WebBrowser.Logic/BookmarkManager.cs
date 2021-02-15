﻿using System;
using System.Collections.Generic;
using System.Text;
using WebBrowser.Data2.BookmarksDataSetTableAdapters;

namespace WebBrowser.Logic
{
    class BookmarkManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }

        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
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
    }
}