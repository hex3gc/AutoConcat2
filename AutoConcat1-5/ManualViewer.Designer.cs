namespace AutoConcat1_5
{
    partial class ManualViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualViewer));
            this.WebBrowser_Manual = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebBrowser_Manual
            // 
            this.WebBrowser_Manual.AllowNavigation = false;
            this.WebBrowser_Manual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser_Manual.IsWebBrowserContextMenuEnabled = false;
            this.WebBrowser_Manual.Location = new System.Drawing.Point(0, 0);
            this.WebBrowser_Manual.Margin = new System.Windows.Forms.Padding(0);
            this.WebBrowser_Manual.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser_Manual.Name = "WebBrowser_Manual";
            this.WebBrowser_Manual.Size = new System.Drawing.Size(880, 661);
            this.WebBrowser_Manual.TabIndex = 0;
            // 
            // ManualViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(880, 661);
            this.Controls.Add(this.WebBrowser_Manual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(896, 700);
            this.Name = "ManualViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoConcat Manual";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowser_Manual;
    }
}