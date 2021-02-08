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

        private void newTabButton_Click(object sender, EventArgs e)
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

        
    }
}
