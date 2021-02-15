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
    }
}
