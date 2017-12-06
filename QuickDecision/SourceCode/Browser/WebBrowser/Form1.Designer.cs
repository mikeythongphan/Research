namespace WebBrowser
{
    partial class QuickDecision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickDecision));
            this.ErpWeb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ErpWeb
            // 
            this.ErpWeb.CausesValidation = false;
            this.ErpWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErpWeb.IsWebBrowserContextMenuEnabled = false;
            this.ErpWeb.Location = new System.Drawing.Point(0, 0);
            this.ErpWeb.Margin = new System.Windows.Forms.Padding(0);
            this.ErpWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.ErpWeb.Name = "ErpWeb";
            this.ErpWeb.Size = new System.Drawing.Size(284, 262);
            this.ErpWeb.TabIndex = 0;
            this.ErpWeb.Url = new System.Uri("", System.UriKind.Relative);
            this.ErpWeb.Visible = false;
            this.ErpWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.ErpWeb_DocumentCompleted);
            this.ErpWeb.FileDownload += new System.EventHandler(this.ErpWeb_FileDownload);
            this.ErpWeb.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ErpWeb_Navigated);
            this.ErpWeb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.ErpWeb_Navigating);
            this.ErpWeb.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ErpWeb_PreviewKeyDown);
            // 
            // QuickDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WebBrowser.Properties.Resources.desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ErpWeb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickDecision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickDecision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuickDecision_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuickDecision_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser ErpWeb;
    }
}

