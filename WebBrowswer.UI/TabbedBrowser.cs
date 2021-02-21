using System;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowswer.UI
{
    public partial class TabbedBrowser : Form
    {
        int TabCounter = 1;

        public TabbedBrowser()
        {
            InitializeComponent();
            TabPage tp = new TabPage($"Tab {TabCounter++}");
            BrowserBar bb = new BrowserBar();
            bb.Dock = DockStyle.Fill;
            tp.Controls.Add(bb);
            tabControl.TabPages.Add(tp);
        }

        public void newTabButton_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage($"Tab {TabCounter++}");
            BrowserBar bb = new BrowserBar();
            bb.Dock = DockStyle.Fill;
            tp.Controls.Add(bb);
            tabControl.TabPages.Add(tp);            
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void exitWebBrowserButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser was created as part of Auburn University's Software Construction course CPSC-2712-AO1." +
                "\nDeveloped by Austin Cascarelli (ajc0109) 2021.");
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryManagerForm();
            historyForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarkForm = new BookmarkManagerForm();
            bookmarkForm.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.deleteAll();
        }
    }
}
