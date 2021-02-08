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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This web browser was created as part of Auburn University's Software Construction course CPSC-2712-AO1." +
                "\nDeveloped by Austin Cascarelli (ajc0109) 2021.");
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(URLTextBox.Text);
            BackLinks.Push(URLTextBox.Text);
            
        }

        // After adding my toolbar(BrowserBar) to my Browswer(TabbedBrowser). This function stopped working and I was not able to figure out what the problem was.
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

        //I cannot figure out how to get access to my TabControl class.
        //There seems to be an issue with the visibility of the parent class (TabbedBroswer).
        //Hopefully I can understand what is happening with this issue before next week's project is due.
        private void FileNewTabButton_Click(object sender, EventArgs e)
        {            
            int counter = 2;
            TabPage tp = new TabPage($"Tab {counter}");
            
            //tabControl.TabPages.Add(tp);
            //TabbedBrowser.tabControl.TabPages.Add(tp);
        }
    }
}
