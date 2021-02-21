
namespace WebBrowswer.UI
{
    partial class HistoryManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HistoryLB = new System.Windows.Forms.ListBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.ClearSearchBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.ClearHistoryBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryLB
            // 
            this.HistoryLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.HistoryLB.FormattingEnabled = true;
            this.HistoryLB.Location = new System.Drawing.Point(0, 0);
            this.HistoryLB.Name = "HistoryLB";
            this.HistoryLB.Size = new System.Drawing.Size(485, 450);
            this.HistoryLB.TabIndex = 0;
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(492, 21);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(143, 20);
            this.SearchTB.TabIndex = 1;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(492, 47);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(50, 23);
            this.SearchBTN.TabIndex = 2;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // ClearSearchBTN
            // 
            this.ClearSearchBTN.Location = new System.Drawing.Point(560, 47);
            this.ClearSearchBTN.Name = "ClearSearchBTN";
            this.ClearSearchBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearSearchBTN.TabIndex = 3;
            this.ClearSearchBTN.Text = "Clear Seach";
            this.ClearSearchBTN.UseVisualStyleBackColor = true;
            this.ClearSearchBTN.Click += new System.EventHandler(this.ClearSearchBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(491, 90);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 4;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // ClearHistoryBTN
            // 
            this.ClearHistoryBTN.Location = new System.Drawing.Point(492, 133);
            this.ClearHistoryBTN.Name = "ClearHistoryBTN";
            this.ClearHistoryBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearHistoryBTN.TabIndex = 5;
            this.ClearHistoryBTN.Text = "Clear History";
            this.ClearHistoryBTN.UseVisualStyleBackColor = true;
            this.ClearHistoryBTN.Click += new System.EventHandler(this.ClearHistoryBTN_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.ClearHistoryBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.ClearSearchBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.HistoryLB);
            this.Name = "HistoryManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryLB;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button ClearSearchBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button ClearHistoryBTN;
    }
}