
namespace WebBrowswer.UI
{
    partial class BookmarkManagerForm
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
            this.BookmarkLB = new System.Windows.Forms.ListBox();
            this.ClearSearchBTN = new System.Windows.Forms.Button();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookmarkLB
            // 
            this.BookmarkLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.BookmarkLB.FormattingEnabled = true;
            this.BookmarkLB.Location = new System.Drawing.Point(0, 0);
            this.BookmarkLB.Name = "BookmarkLB";
            this.BookmarkLB.Size = new System.Drawing.Size(485, 450);
            this.BookmarkLB.TabIndex = 0;
            // 
            // ClearSearchBTN
            // 
            this.ClearSearchBTN.Location = new System.Drawing.Point(561, 38);
            this.ClearSearchBTN.Name = "ClearSearchBTN";
            this.ClearSearchBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearSearchBTN.TabIndex = 6;
            this.ClearSearchBTN.Text = "Clear Seach";
            this.ClearSearchBTN.UseVisualStyleBackColor = true;
            this.ClearSearchBTN.Click += new System.EventHandler(this.ClearSearchBTN_Click);
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(493, 38);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(50, 23);
            this.SearchBTN.TabIndex = 5;
            this.SearchBTN.Text = "Search";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(493, 12);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(143, 20);
            this.SearchTB.TabIndex = 4;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(493, 84);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 7;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.ClearSearchBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.BookmarkLB);
            this.Name = "BookmarkManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarkLB;
        private System.Windows.Forms.Button ClearSearchBTN;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.Button DeleteBTN;
    }
}