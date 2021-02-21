using System;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowswer.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            HistoryLB.Items.Clear();

            foreach(var item in items)
            {
                HistoryLB.Items.Add(String.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            //clear ListBox each time find is clicked
            HistoryLB.Items.Clear();
            //if textbox contains characters and not whitespace or null
            if (!String.IsNullOrWhiteSpace(SearchTB.Text))
            {
                //obtain target word
                string target = SearchTB.Text.ToLower();
                var items = HistoryManager.GetItems();
                foreach (var item in items)
                {
                    if (item.Title.ToLower().Contains(target) || item.URL.ToLower().Contains(target))
                    {
                        HistoryLB.Items.Add(String.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                    }
                }
            }
        }

        private void ClearSearchBTN_Click(object sender, EventArgs e)
        {
            HistoryManagerForm_Load(sender, e);
            SearchTB.Text = "";
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            deleteItem(HistoryLB.SelectedIndex);
            HistoryManagerForm_Load(sender, e);
        }
        private void deleteItem(int i)
        {
            var items = HistoryManager.GetItems();
            if (i >= 0)                
                HistoryManager.deleteItem(items[i]);
        }
        private void ClearHistoryBTN_Click(object sender, EventArgs e)
        {
            HistoryManager.deleteAll();
            HistoryManagerForm_Load(sender, e);
        }
    }
}
