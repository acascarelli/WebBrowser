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

namespace WebBrowswer.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            BookmarkLB.Items.Clear();

            foreach (var item in items)
            {
                BookmarkLB.Items.Add(String.Format("{0} ({1})", item.Title, item.URL));
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            //clear ListBox each time find is clicked
            BookmarkLB.Items.Clear();
            //if textbox contains characters and not whitespace or null
            if (!String.IsNullOrWhiteSpace(SearchTB.Text))
            {
                //obtain target word
                string target = SearchTB.Text.ToLower();
                var items = BookmarkManager.GetItems();
                foreach (var item in items)
                {
                    if (item.Title.ToLower().Contains(target) || item.URL.ToLower().Contains(target))
                    {
                        BookmarkLB.Items.Add(String.Format("{0} ({1})", item.Title, item.URL));
                    }
                }
            }
        }

        private void ClearSearchBTN_Click(object sender, EventArgs e)
        {
            BookmarkManagerForm_Load(sender, e);
            SearchTB.Text = "";
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            deleteItem(BookmarkLB.SelectedIndex);
            BookmarkManagerForm_Load(sender, e);
        }

        private void deleteItem(int i)
        {
            var items = BookmarkManager.GetItems();
            if (i >= 0)
                BookmarkManager.deleteItem(items[i]);
        }
    }
}
