namespace WebBrowser.UI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.HistorySearchText = new System.Windows.Forms.TextBox();
            this.HistorySearchButton = new System.Windows.Forms.Button();
            this.ClearHistory = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 326);
            this.listBox1.TabIndex = 0;
            // 
            // HistorySearchText
            // 
            this.HistorySearchText.Location = new System.Drawing.Point(344, 23);
            this.HistorySearchText.Name = "HistorySearchText";
            this.HistorySearchText.Size = new System.Drawing.Size(123, 20);
            this.HistorySearchText.TabIndex = 1;
            // 
            // HistorySearchButton
            // 
            this.HistorySearchButton.Location = new System.Drawing.Point(344, 49);
            this.HistorySearchButton.Name = "HistorySearchButton";
            this.HistorySearchButton.Size = new System.Drawing.Size(64, 23);
            this.HistorySearchButton.TabIndex = 2;
            this.HistorySearchButton.Text = "Search";
            this.HistorySearchButton.UseVisualStyleBackColor = true;
            this.HistorySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // ClearHistory
            // 
            this.ClearHistory.Location = new System.Drawing.Point(344, 166);
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(75, 23);
            this.ClearHistory.TabIndex = 3;
            this.ClearHistory.Text = "Clear History";
            this.ClearHistory.UseVisualStyleBackColor = true;
            this.ClearHistory.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(344, 125);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 326);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearHistory);
            this.Controls.Add(this.HistorySearchButton);
            this.Controls.Add(this.HistorySearchText);
            this.Controls.Add(this.listBox1);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox HistorySearchText;
        private System.Windows.Forms.Button HistorySearchButton;
        private System.Windows.Forms.Button ClearHistory;
        private System.Windows.Forms.Button DeleteButton;
    }
}