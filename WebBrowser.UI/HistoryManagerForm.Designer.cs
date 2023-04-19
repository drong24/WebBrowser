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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(484, 263);
            this.listBox1.TabIndex = 0;
            // 
            // HistorySearchText
            // 
            this.HistorySearchText.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistorySearchText.Location = new System.Drawing.Point(0, 0);
            this.HistorySearchText.Name = "HistorySearchText";
            this.HistorySearchText.Size = new System.Drawing.Size(484, 20);
            this.HistorySearchText.TabIndex = 1;
            // 
            // HistorySearchButton
            // 
            this.HistorySearchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistorySearchButton.Location = new System.Drawing.Point(0, 20);
            this.HistorySearchButton.Name = "HistorySearchButton";
            this.HistorySearchButton.Size = new System.Drawing.Size(484, 23);
            this.HistorySearchButton.TabIndex = 2;
            this.HistorySearchButton.Text = "Search";
            this.HistorySearchButton.UseVisualStyleBackColor = true;
            this.HistorySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 306);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HistorySearchButton);
            this.Controls.Add(this.HistorySearchText);
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
    }
}