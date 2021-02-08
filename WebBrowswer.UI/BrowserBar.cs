using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowswer.UI
{
    public partial class BrowserBar : UserControl
    {

        Stack<string> BackLinks = new Stack<string>();
        Stack<string> ForwardLinks = new Stack<string>();

        public BrowserBar()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(URLTextBox.Text);
            BackLinks.Push(URLTextBox.Text);
            
        }

        private void URLTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                this.webBrowser1.Navigate(URLTextBox.Text);
                BackLinks.Push(URLTextBox.Text);
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

        
    }
}
