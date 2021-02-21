using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebBrowser.Logic;


namespace WebBrowswer.UI
{
    public partial class BrowserBar : UserControl
    {

        Stack<string> BackLinks = new Stack<string>();
        Stack<string> ForwardLinks = new Stack<string>();
        public HistoryItem lastPage;

        public BrowserBar()
        {
            InitializeComponent();
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            LoadingStatusLabel.Text = "Loaded";
            webBrowser1.ScriptErrorsSuppressed = true;
            URLTextBox.Text = webBrowser1.Url.ToString();
            var item = new HistoryItem();
            item.URL = URLTextBox.Text;
            item.Title = webBrowser1.DocumentTitle;
            item.Date = DateTime.Now;
            HistoryManager.AddItem(item);
            if(lastPage == null || (item.Title != lastPage.Title && item.URL != lastPage.URL))
            {
                BackLinks.Push(item.URL);
                lastPage = item;
            }
        }


        private void URLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                this.webBrowser1.Navigate(URLTextBox.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(BackLinks.Count > 0)
            {
                ForwardLinks.Push(URLTextBox.Text);
                if (URLTextBox.Text == BackLinks.Peek())
                    BackLinks.Pop();
                URLTextBox.Text = BackLinks.Peek();
                this.webBrowser1.Navigate(BackLinks.Pop());              
            }
        }

        private void ForwardButton_Click_1(object sender, EventArgs e)
        {
            if (ForwardLinks.Count > 0)
            {
                BackLinks.Push(URLTextBox.Text);
                URLTextBox.Text = ForwardLinks.Peek();
                this.webBrowser1.Navigate(ForwardLinks.Pop());
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(URLTextBox.Text);
        }

        private void BookmarkBTN_Click(object sender, EventArgs e)
        {
            var item = new BookmarkItem();
            item.URL = URLTextBox.Text;
            item.Title = webBrowser1.DocumentTitle;
            BookmarkManager.AddItem(item);
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            LoadingBar.Maximum = (int)e.MaximumProgress;
            if((int)e.CurrentProgress > 0 && (int)e.CurrentProgress < LoadingBar.Maximum)
                LoadingBar.Value = (int)e.CurrentProgress;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            LoadingStatusLabel.Text = "Loading";
        }
    }
}
